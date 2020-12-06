using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Fractals
{
    static class Utilities
    {
        public static Color ColorLerp(Color from, Color to, float progress)
        {
            if (progress < 0.0f || progress > 1.0f)
            {
                throw new ArgumentException("Progress is out of range.", "progress");
            }

            float newAlphaChannel = from.A + (to.A - from.A) * progress;
            float newRedChannel = from.R + (to.R - from.R) * progress;
            float newGreenChannel = from.G + (to.G - from.G) * progress;
            float newBlueChannel = from.B + (to.B - from.B) * progress;

            return Color.FromArgb((int)newAlphaChannel, (int)newRedChannel, (int)newGreenChannel, (int)newBlueChannel);
        }
    }
}
