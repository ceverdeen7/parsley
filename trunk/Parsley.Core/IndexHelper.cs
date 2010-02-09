﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parsley.Core {
  /// <summary>
  /// Help convert two-dimensional indices to one-dimensional array indices
  /// </summary>
  public static class IndexHelper {

    /// <summary>
    /// Convert pixel to one-dimensional array index
    /// </summary>
    /// <param name="pixel">Pixel to convert to index</param>
    /// <returns>Index</returns>
    public static int ArrayIndexFromPixel(System.Drawing.Point pixel, System.Drawing.Size s) {
      return pixel.Y * s.Width + pixel.X;
    }

    /// <summary>
    /// Make pixel coordinate relative to rectangle frame
    /// </summary>
    /// <param name="pixel">Pixel</param>
    /// <param name="r">Rectangle</param>
    /// <returns>Relative coordinates</returns>
    public static System.Drawing.Point MakeRelative(System.Drawing.Point pixel, System.Drawing.Rectangle r) {
      return new System.Drawing.Point(r.X - pixel.X, r.Y - pixel.Y);
    }
  }
}
