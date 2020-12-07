using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Fractals
{
    static class Utilities
    {
        public static int Round(float x)
        {
            return (int)Math.Round(x, MidpointRounding.AwayFromZero);
        }

        public static float Lerp(float from, float to, float progress)
        {
//             if (progress < 0.0f || progress > 1.0f)
//             {
//                 throw new ArgumentException("Progress is out of range.", "progress");
//             }

            return from + (to - from) * progress;
        }

        public static Color ColorLerp(Color from, Color to, float progress)
        {
            float newAlphaChannel = Lerp(from.A, to.A, progress);
            float newRedChannel = Lerp(from.R, to.R, progress);
            float newGreenChannel = Lerp(from.G, to.G, progress);
            float newBlueChannel = Lerp(from.B, to.B, progress);

            return Color.FromArgb(Round(newAlphaChannel), Round(newRedChannel), Round(newGreenChannel), Round(newBlueChannel));
        }
    }
}
