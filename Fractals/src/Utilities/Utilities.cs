﻿using System;
using System.Drawing;
using System.Numerics;

namespace Fractals
{
    static class Utilities
    {
        public static int Round(float x)
        {
            return (int)Math.Round(x, MidpointRounding.AwayFromZero);
        }

        public static float DegreesToRadians(float angle)
        {
            return (float)(Math.PI / 180 * angle);
        }

        /// <summary>
        /// Linear interpolation for numbers.
        /// </summary>
        public static float Lerp(float from, float to, float progress)
        {
            return from + (to - from) * progress;
        }

        /// <summary>
        /// Linear interpolation for points.
        /// </summary>
        public static PointF Lerp(PointF a, PointF b, float progress)
        {
            var vector = new Vector2(b.X - a.X, b.Y - a.Y) * progress;
            return new PointF(a.X + vector.X, a.Y + vector.Y);
        }

        /// <summary>
        /// Linear interpolation for colors.
        /// </summary>
        public static Color Lerp(Color from, Color to, float progress)
        {
            float newAlphaChannel = Lerp(from.A, to.A, progress);
            float newRedChannel = Lerp(from.R, to.R, progress);
            float newGreenChannel = Lerp(from.G, to.G, progress);
            float newBlueChannel = Lerp(from.B, to.B, progress);

            return Color.FromArgb(Round(newAlphaChannel), Round(newRedChannel), Round(newGreenChannel), Round(newBlueChannel));
        }
    }
}
