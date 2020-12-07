using System;
using System.Drawing;
using System.Numerics;

namespace Fractals
{
    class KochCurve : Fractal
    {
        public KochCurve(int recursionLevel, Color gradientBeginning, Color gradientEnding, Render render)
            : base(recursionLevel, gradientBeginning, gradientEnding, render)
        {

        }

        public override void Draw(Graphics graphics)
        {
            Draw(graphics, 0f, 2f, new PointF(-1f, 0.0f), new PointF(1f, 0.0f));
        }

        private void Draw(Graphics graphics, float angle, float length, PointF a, PointF b, int recursionLevel = 0, int gradientLevel = 0)
        {
            if (recursionLevel == _recursionLevelLimit)
            {
                var gradientColor = Utilities.Lerp(_gradientBeginning, _gradientEnding, (float)gradientLevel / _recursionLevelLimit);
                _render.DrawLine(graphics, new Pen(gradientColor, 2), a, b);
                return;
            }

            // Left point.
            PointF c = Utilities.Lerp(a, b, 1f / 3);
            // Right point.
            PointF d = Utilities.Lerp(a, b, 2f / 3);

            float leftAngle = angle - 1f / 3 * (float)Math.PI;
            float rightAngle = angle + 1f / 3 * (float)Math.PI;

            var newLength = length / 3;

            // Top point.
            var eVector = new Vector2(c.X, c.Y) + new Vector2(
                (float)Math.Cos(leftAngle) * newLength,
                (float)Math.Sin(leftAngle) * newLength);
            var e = new PointF(eVector.X, eVector.Y);

            Draw(graphics, angle, newLength, a, c, recursionLevel + 1, gradientLevel);
            Draw(graphics, angle, newLength, d, b, recursionLevel + 1, gradientLevel);

            Draw(graphics, leftAngle, newLength, c, e, recursionLevel + 1, gradientLevel + 1);
            Draw(graphics, rightAngle, newLength, e, d, recursionLevel + 1, gradientLevel + 1);
        }
    }
}
