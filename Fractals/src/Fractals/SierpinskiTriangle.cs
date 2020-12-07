using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Fractals
{
    class SierpinskiTriangle : Fractal
    {
        public SierpinskiTriangle(int recursionLevel, Color gradientBeginning, Color gradientEnding, Render render)
            : base(recursionLevel, gradientBeginning, gradientEnding, render)
        {

        }

        public override void Draw(Graphics graphics)
        {
            var a = new PointF(-0.9f, 0.9f);
            var b = new PointF(0f, 0.9f - 0.9f * (float)Math.Sqrt(3));
            var c = new PointF(0.9f, 0.9f);
            _render.DrawTriangle(graphics, new Pen(_gradientBeginning, 2), a, b, c);
            Draw(graphics, a, b, c);
        }

        public void Draw(Graphics graphics, PointF a, PointF b, PointF c, int recursionLevel = 1)
        {
            // Segments middles.
            PointF newA = Utilities.Lerp(b, c, 0.5f);
            PointF newB = Utilities.Lerp(a, c, 0.5f);
            PointF newC = Utilities.Lerp(a, b, 0.5f);
            _render.DrawTriangle(graphics,
                new Pen(Utilities.Lerp(_gradientBeginning, _gradientEnding, (float)recursionLevel / _recursionLevelLimit), 2),
                newA, newB, newC
            );

            if (recursionLevel == _recursionLevelLimit)
            {
                return;
            }

            Draw(graphics, a, newB, newC, recursionLevel + 1);
            Draw(graphics, newA, b, newC, recursionLevel + 1);
            Draw(graphics, newA, newB, c, recursionLevel + 1);
        }
    }
}
