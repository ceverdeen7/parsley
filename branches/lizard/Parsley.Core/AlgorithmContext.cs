﻿/*
 * Parsley http://parsley.googlecode.com
 * Copyright (c) 2010, Christoph Heindl. All rights reserved.
 * Code license:	New BSD License
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parsley.Core {
  public class AlgorithmContext : IAlgorithmContext {
    System.Drawing.Rectangle _roi;
    Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte> _image;
    Emgu.CV.IntrinsicCameraParameters _intrinsics;
    private Plane[] _reference_planes;

    public AlgorithmContext() { }

    public Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte> Image {
      get { return _image; }
      set { _image = value; }
    }

    public Emgu.CV.IntrinsicCameraParameters Intrinsics {
      get { return _intrinsics; }
      set { _intrinsics = value; }
    }

    public Plane[] ReferencePlanes {
      get { return _reference_planes; }
      set { _reference_planes = value; }
    }

    public System.Drawing.Rectangle ROI {
      get { return _roi; }
      set { _roi = value; }
    }
  }
}