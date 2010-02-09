﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;

namespace Parsley {
  public partial class IntrinsicCalibrationSlide : FrameGrabberSlide {
    private Core.IntrinsicCalibration _ic;
    private Core.ExtrinsicCalibration _ec; // used for illustration of coordinate frame only.
    private bool _take_image_request;
    private bool _calibrate_request;
    private Timer _timer_auto;
    private bool _was_pattern_found;
    private bool _first_time;

    public IntrinsicCalibrationSlide(Context c) : base(c) {
      InitializeComponent();
      
      _timer_auto = new Timer();
      _timer_auto.Interval = 3000;
      _timer_auto.Tick += new EventHandler(_timer_auto_Tick);
    }


    protected override void OnSlidingIn() {
      this.OnConfigurationLoaded(this, null);
      _first_time = true;
      base.OnSlidingIn();
    }

    protected override void OnSlidingOut(CancelEventArgs args) {
      _timer_auto.Enabled = false;
      base.OnSlidingOut(args);
    }

    protected override void OnConfigurationLoaded(object sender, EventArgs e) {
      _ic = new Parsley.Core.IntrinsicCalibration(Context.World.IntrinsicPattern.ObjectPoints, Context.World.Camera.FrameSize);
      _ic.ClearViews();
      _timer_auto.Enabled = false;
      _cb_auto_take.Checked = false;
      _btn_calibrate.Enabled = false;
      _btn_take_image.Enabled = true;
      _calibrate_request = false;
      if (this.Context.FrameGrabber.Camera.HasIntrinsics) {
        this.Logger.Info("The camera already has a calibration. You can restart the calibration process by taking images.");
      } else {
        this.Logger.Info("Start the calibration process by taking images of your chessboard.");
      }
      
    }

    void _timer_auto_Tick(object sender, EventArgs e) {
      _take_image_request = true;
    }

    protected override void OnFrame(Parsley.Core.BuildingBlocks.FrameGrabber fp, Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte> img) {
      Core.CalibrationPattern pattern = this.Context.World.IntrinsicPattern;
      Image<Gray, Byte> gray = img.Convert<Gray, Byte>();
      gray._EqualizeHist();
      pattern.FindPattern(gray);
      this.UpdateStatusDisplay(pattern.PatternFound);
      this.HandleCalibrateRequest();
      this.HandleTakeImageRequest();
      this.DrawCoordinateFrame(img);
      pattern.DrawPattern(img, pattern.ImagePoints, pattern.PatternFound);
    }

    private void UpdateStatusDisplay(bool pattern_found) {
      bool status_changed = _was_pattern_found != pattern_found || _first_time;
      _was_pattern_found = pattern_found;
      _first_time = false;

      if (_ic.Views.Count == 0 && status_changed) {
        if (pattern_found) {
          this.Logger.Info("Pattern found");
        } else {
          this.Logger.Warn("Pattern not found");
        }
      }
    }

    void DrawCoordinateFrame(Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte> img) {
      if (_ec != null && Context.World.IntrinsicPattern.PatternFound && Context.World.Camera.HasIntrinsics) {
        Emgu.CV.ExtrinsicCameraParameters ecp = _ec.Calibrate(Context.World.IntrinsicPattern.ImagePoints);
        Context.World.IntrinsicPattern.DrawCoordinateFrame(img, ecp, Context.World.Camera.Intrinsics);
      }
    }

    void HandleTakeImageRequest() {
      if (_take_image_request) {
        if (Context.World.IntrinsicPattern.PatternFound) {
          _ic.AddView(Context.World.IntrinsicPattern.ImagePoints);
          this.Logger.Info(String.Format("You have successfully acquired {0} calibration images.", _ic.Views.Count));
          this.Invoke((MethodInvoker)delegate {  
            _btn_calibrate.Enabled = _ic.Views.Count > 2 && !_cb_auto_take.Checked;
          });
        }
      }
      _take_image_request = false;
    }

    void HandleCalibrateRequest() {
      if (_calibrate_request) {
        this.Context.FrameGrabber.Camera.Intrinsics = _ic.Calibrate();
        _ec = new Parsley.Core.ExtrinsicCalibration(Context.World.IntrinsicPattern.ObjectPoints, Context.World.Camera.Intrinsics);
        this.Logger.Info("Calibration succeeded");
        this.Invoke((MethodInvoker)delegate {
          _btn_calibrate.Enabled = false;
          _btn_take_image.Enabled = true;
          _cb_auto_take.Enabled = true;
          _cb_auto_take.Checked = false;
        });
      }
      _calibrate_request = false;
    }

    private void btn_take_image_Click(object sender, EventArgs e) {
      _take_image_request = true;
    }

    private void btn_calibrate_Click(object sender, EventArgs e) {
      _take_image_request = false;
      _timer_auto.Enabled = false;
      _cb_auto_take.Enabled = false;
      _btn_take_image.Enabled = false;
      _btn_calibrate.Enabled = false;
      _calibrate_request = true;
    }

    private void _cb_auto_take_CheckedChanged(object sender, EventArgs e) {
      _btn_take_image.Enabled = !_cb_auto_take.Checked;
      _btn_calibrate.Enabled = !_cb_auto_take.Checked && _ic.Views.Count > 2;
      if (_cb_auto_take.Checked) {
        this.Logger.Info("Auto-taking calibration images every three seconds.");
      }
      _timer_auto.Enabled = _cb_auto_take.Checked;
    }
  }
}