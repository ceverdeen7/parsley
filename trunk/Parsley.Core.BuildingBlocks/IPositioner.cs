﻿/*
 * Parsley http://parsley.googlecode.com
 * Copyright (c) 2010, Christoph Heindl
 * Copyright (c) 2010, Matthias Plasch
 * All rights reserved.
 * Code license:	New BSD License
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Numerics.LinearAlgebra;
using Emgu.CV.Structure;

namespace Parsley.Core.BuildingBlocks
{
  public interface IPositioner
  {
    /// <summary>
    /// Used to tranform the given points.
    /// </summary>
    /// <param name="points"></param>
    void TransformPoints(List<Vector> points);

    Emgu.CV.ExtrinsicCameraParameters PositionerPoseA
    {
      get;
      set;
    }

    /// <summary>
    /// Updates the Point transformation matrix.
    /// </summary>
    /// <param name="the_cam"></param>
    bool UpdateTransformation(Camera the_cam);

    /// <summary>
    /// Needed for RotaryPositioner.
    /// If a MarkerPositioner is used, this member should be ignored;
    /// </summary>
    double Angle
    {
      get;
      set;
    }
  }
}