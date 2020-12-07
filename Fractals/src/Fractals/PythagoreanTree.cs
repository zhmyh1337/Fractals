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
        public PythagoreanTree(int recursionLevel, Color gradientBeginning, Color gradientEnding, Render render)
            : base(recursionLevel, gradientBeginning, gradientEnding, render)
        {

        }

        public override void Draw(Graphics graphics)
        {
            Draw(graphics, new PointF(0, 1), 0.6f);
        }

        private void Draw(Graphics graphics, PointF point, float length)
        {
            var newPoint = point;
            newPoint.Y -= length;

            _render.DrawLine(graphics, new Pen(Utilities.ColorLerp(_gradientBeginning, _gradientEnding, 0.0f), 2), point, newPoint);
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

            _render.DrawLine(graphics, new Pen(
                Utilities.ColorLerp(_gradientBeginning, _gradientEnding, (float)recursionLevel / (_recursionLevelLimit - 1)), 2),
                point, newPoint
            );
            Draw(graphics, newPoint, newLength, newAngle, recursionLevel + 1);
        }

        private readonly float _lengthRatio = 2.0f / 3;
        private readonly float _angle1 = (float)(-Math.PI / 3);
        private readonly float _angle2 = (float)(Math.PI / 3.5);
    }
}
