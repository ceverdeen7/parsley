﻿namespace Parsley {
  partial class Main {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
      this._save_dialog = new System.Windows.Forms.SaveFileDialog();
      this._open_dlg = new System.Windows.Forms.OpenFileDialog();
      this._ts_container = new System.Windows.Forms.ToolStripContainer();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this._btn_settings = new System.Windows.Forms.ToolStripButton();
      this.toolStrip2 = new System.Windows.Forms.ToolStrip();
      this._btn_back = new System.Windows.Forms.ToolStripButton();
      this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.x = new System.Windows.Forms.ToolStripDropDownButton();
      this._btn_intrinsic_calibration = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this._btn_show_camera_live_feed = new System.Windows.Forms.ToolStripButton();
      this._btn_show_3d_visualization = new System.Windows.Forms.ToolStripButton();
      this._slide_control = new SlickInterface.SlideControl();
      this._properties = new Parsley.PropertyPane();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this._ts_container.ContentPanel.SuspendLayout();
      this._ts_container.RightToolStripPanel.SuspendLayout();
      this._ts_container.TopToolStripPanel.SuspendLayout();
      this._ts_container.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.toolStrip2.SuspendLayout();
      this.SuspendLayout();
      // 
      // _save_dialog
      // 
      this._save_dialog.FileName = "world_configuration.parsley";
      // 
      // _open_dlg
      // 
      this._open_dlg.FileName = "world_configuration.parsley";
      // 
      // _ts_container
      // 
      this._ts_container.BottomToolStripPanelVisible = false;
      // 
      // _ts_container.ContentPanel
      // 
      this._ts_container.ContentPanel.BackColor = System.Drawing.Color.White;
      this._ts_container.ContentPanel.Controls.Add(this._properties);
      this._ts_container.ContentPanel.Controls.Add(this._slide_control);
      this._ts_container.ContentPanel.Padding = new System.Windows.Forms.Padding(10);
      this._ts_container.ContentPanel.Size = new System.Drawing.Size(682, 460);
      this._ts_container.Dock = System.Windows.Forms.DockStyle.Fill;
      this._ts_container.LeftToolStripPanelVisible = false;
      this._ts_container.Location = new System.Drawing.Point(0, 0);
      this._ts_container.Name = "_ts_container";
      // 
      // _ts_container.RightToolStripPanel
      // 
      this._ts_container.RightToolStripPanel.Controls.Add(this.toolStrip1);
      this._ts_container.Size = new System.Drawing.Size(706, 485);
      this._ts_container.TabIndex = 3;
      this._ts_container.Text = "toolStripContainer1";
      // 
      // _ts_container.TopToolStripPanel
      // 
      this._ts_container.TopToolStripPanel.BackColor = System.Drawing.Color.White;
      this._ts_container.TopToolStripPanel.Controls.Add(this.toolStrip2);
      this._ts_container.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
      // 
      // toolStrip1
      // 
      this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
      this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._btn_settings});
      this.toolStrip1.Location = new System.Drawing.Point(0, 3);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(24, 89);
      this.toolStrip1.TabIndex = 0;
      // 
      // _btn_settings
      // 
      this._btn_settings.CheckOnClick = true;
      this._btn_settings.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._btn_settings.Image = global::Parsley.Properties.Resources.agt_utilities;
      this._btn_settings.ImageTransparentColor = System.Drawing.Color.Magenta;
      this._btn_settings.Name = "_btn_settings";
      this._btn_settings.Size = new System.Drawing.Size(22, 84);
      this._btn_settings.Text = "Properties";
      this._btn_settings.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
      this._btn_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this._btn_settings.Click += new System.EventHandler(this._btn_settings_Click);
      // 
      // toolStrip2
      // 
      this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.toolStrip2.GripMargin = new System.Windows.Forms.Padding(0);
      this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._btn_back,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator2,
            this.x,
            this.toolStripSeparator1,
            this._btn_show_camera_live_feed,
            this._btn_show_3d_visualization});
      this.toolStrip2.Location = new System.Drawing.Point(3, 0);
      this.toolStrip2.Name = "toolStrip2";
      this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
      this.toolStrip2.Size = new System.Drawing.Size(196, 25);
      this.toolStrip2.TabIndex = 5;
      // 
      // _btn_back
      // 
      this._btn_back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this._btn_back.Image = global::Parsley.Properties.Resources.previous;
      this._btn_back.ImageTransparentColor = System.Drawing.Color.Magenta;
      this._btn_back.Name = "_btn_back";
      this._btn_back.Size = new System.Drawing.Size(23, 22);
      this._btn_back.Text = "toolStripButton2";
      this._btn_back.ToolTipText = "Go back to previous slide";
      this._btn_back.Click += new System.EventHandler(this._btn_back_Click);
      // 
      // openToolStripButton
      // 
      this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
      this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.openToolStripButton.Name = "openToolStripButton";
      this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.openToolStripButton.Text = "&Open";
      this.openToolStripButton.ToolTipText = "Load Parsley configuration";
      // 
      // saveToolStripButton
      // 
      this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
      this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveToolStripButton.Name = "saveToolStripButton";
      this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.saveToolStripButton.Text = "&Save";
      this.saveToolStripButton.ToolTipText = "Save current Parsley configuration";
      // 
      // x
      // 
      this.x.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.x.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._btn_intrinsic_calibration});
      this.x.Image = global::Parsley.Properties.Resources.package_graphics;
      this.x.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.x.Name = "x";
      this.x.Size = new System.Drawing.Size(29, 22);
      this.x.Text = "Adjust Parsley settings";
      // 
      // _btn_intrinsic_calibration
      // 
      this._btn_intrinsic_calibration.Image = global::Parsley.Properties.Resources.package_games_board;
      this._btn_intrinsic_calibration.Name = "_btn_intrinsic_calibration";
      this._btn_intrinsic_calibration.Size = new System.Drawing.Size(221, 22);
      this._btn_intrinsic_calibration.Text = "Intrinsic Camera Calibration";
      this._btn_intrinsic_calibration.Click += new System.EventHandler(this._btn_intrinsic_calibration_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // _btn_show_camera_live_feed
      // 
      this._btn_show_camera_live_feed.CheckOnClick = true;
      this._btn_show_camera_live_feed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this._btn_show_camera_live_feed.Image = global::Parsley.Properties.Resources.xine;
      this._btn_show_camera_live_feed.ImageTransparentColor = System.Drawing.Color.Magenta;
      this._btn_show_camera_live_feed.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
      this._btn_show_camera_live_feed.Name = "_btn_show_camera_live_feed";
      this._btn_show_camera_live_feed.Size = new System.Drawing.Size(23, 22);
      this._btn_show_camera_live_feed.Text = "toolStripButton3";
      this._btn_show_camera_live_feed.Click += new System.EventHandler(this._btn_show_camera_live_feed_Click);
      // 
      // _btn_show_3d_visualization
      // 
      this._btn_show_3d_visualization.CheckOnClick = true;
      this._btn_show_3d_visualization.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this._btn_show_3d_visualization.Image = global::Parsley.Properties.Resources._3d;
      this._btn_show_3d_visualization.ImageTransparentColor = System.Drawing.Color.Magenta;
      this._btn_show_3d_visualization.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
      this._btn_show_3d_visualization.Name = "_btn_show_3d_visualization";
      this._btn_show_3d_visualization.Size = new System.Drawing.Size(23, 22);
      this._btn_show_3d_visualization.Text = "toolStripButton1";
      this._btn_show_3d_visualization.Click += new System.EventHandler(this._btn_show_3d_visualization_Click);
      // 
      // _slide_control
      // 
      this._slide_control.BackColor = System.Drawing.Color.White;
      this._slide_control.Dock = System.Windows.Forms.DockStyle.Fill;
      this._slide_control.Location = new System.Drawing.Point(10, 10);
      this._slide_control.Margin = new System.Windows.Forms.Padding(0);
      this._slide_control.Name = "_slide_control";
      this._slide_control.Selected = null;
      this._slide_control.Size = new System.Drawing.Size(662, 440);
      this._slide_control.SlideSpeed = 250;
      this._slide_control.TabIndex = 1;
      // 
      // _properties
      // 
      this._properties.Location = new System.Drawing.Point(373, 0);
      this._properties.Name = "_properties";
      this._properties.Size = new System.Drawing.Size(306, 460);
      this._properties.TabIndex = 3;
      this._properties.Visible = false;
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(706, 485);
      this.Controls.Add(this._ts_container);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Main";
      this.Text = "Welcome to Parsely!";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
      this.Resize += new System.EventHandler(this.Main_Resize);
      this._ts_container.ContentPanel.ResumeLayout(false);
      this._ts_container.RightToolStripPanel.ResumeLayout(false);
      this._ts_container.RightToolStripPanel.PerformLayout();
      this._ts_container.TopToolStripPanel.ResumeLayout(false);
      this._ts_container.TopToolStripPanel.PerformLayout();
      this._ts_container.ResumeLayout(false);
      this._ts_container.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.toolStrip2.ResumeLayout(false);
      this.toolStrip2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private SlickInterface.SlideControl _slide_control;
    private System.Windows.Forms.SaveFileDialog _save_dialog;
    private System.Windows.Forms.OpenFileDialog _open_dlg;
    private System.Windows.Forms.ToolStripContainer _ts_container;
    private System.Windows.Forms.ToolStrip toolStrip2;
    private System.Windows.Forms.ToolStripButton _btn_back;
    private System.Windows.Forms.ToolStripButton openToolStripButton;
    private System.Windows.Forms.ToolStripButton saveToolStripButton;
    private System.Windows.Forms.ToolStripDropDownButton x;
    private System.Windows.Forms.ToolStripMenuItem _btn_intrinsic_calibration;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton _btn_show_camera_live_feed;
    private System.Windows.Forms.ToolStripButton _btn_show_3d_visualization;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton _btn_settings;
    private PropertyPane _properties;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
  }
}

