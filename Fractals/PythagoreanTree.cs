using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fractals
{
    class PythagoreanTree : Fractal
    {
        public PythagoreanTree(int recursionLevel)
            : base(recursionLevel)
        {

        }

        public override void Draw(PaintEventArgs paintEventArgs)
        {
            Draw(paintEventArgs.Graphics, new PointF(paintEventArgs.ClipRectangle.Width * 0.5f, paintEventArgs.ClipRectangle.Bottom),
                paintEventArgs.ClipRectangle.Height * 0.3f);
        }

        private void Draw(Graphics graphics, PointF point, float length)
        {
            var newPoint = point;
            newPoint.Y -= length;

            graphics.DrawLine(Pens.Black, point, newPoint);
            Draw(graphics, newPoint, length, (float)(-Math.PI / 2));
        }

        private void Draw(Graphics graphics, PointF point, float length, float angle, int recursionLevel = 1)
        {
            if (recursionLevel == _recursionLevelLimit)
            {
                return;
            }

            Draw(graphics, point, length, angle, _angle1, recursionLevel);
            Draw(graphics, point, length, angle, _angle2, recursionLevel);
        }

        private void Draw(Graphics graphics, PointF point, float length, float angle, float deltaAngle, int recursionLevel)
        {
            float newAngle = angle + deltaAngle;
            float newLength = length * _lengthRatio;
            var newPoint = new PointF(
                point.X + (float)Math.Cos(newAngle) * newLength,
                point.Y + (float)Math.Sin(newAngle) * newLength
            );

            graphics.DrawLine(Pens.Black, point, newPoint);
            Draw(graphics, newPoint, newLength, newAngle, recursionLevel + 1);
        }

        private readonly float _lengthRatio = 2.0f / 3;
        private readonly float _angle1 = (float)(-Math.PI / 4);
        private readonly float _angle2 = (float)(Math.PI / 4);
    }
}
