using System;
using System.Drawing;

namespace Fractals
{
    class PythagoreanTree : Fractal
    {
        public PythagoreanTree(int recursionLevel, Color gradientBeginning, Color gradientEnding, Render render,
            float firstLineLength, float lengthRatio, float angle1, float angle2)
            : base(recursionLevel, gradientBeginning, gradientEnding, render)
        {
            _firstLineLength = firstLineLength;
            _lengthRatio = lengthRatio;
            _angle1 = Utilities.DegreesToRadians(angle1);
            _angle2 = Utilities.DegreesToRadians(angle2);
        }

        public override void Draw(Graphics graphics)
        {
            Draw(graphics, new PointF(0, 1), _firstLineLength);
        }

        /// <summary>
        /// Drawing the first line.
        /// </summary>
        private void Draw(Graphics graphics, PointF point, float length)
        {
            var newPoint = point;
            newPoint.Y -= length;

            _render.DrawLine(graphics, new Pen(Utilities.Lerp(_gradientBeginning, _gradientEnding, 0.0f), 2), point, newPoint);
            Draw(graphics, newPoint, length, (float)(-Math.PI / 2));
        }

        /// <summary>
        /// Calling the children.
        /// </summary>
        private void Draw(Graphics graphics, PointF point, float length, float angle, int recursionLevel = 1)
        {
            if (recursionLevel == _recursionLevelLimit)
            {
                return;
            }

            Draw(graphics, point, length, angle, _angle1, recursionLevel);
            Draw(graphics, point, length, angle, _angle2, recursionLevel);
        }

        /// <summary>
        /// New line processing.
        /// </summary>
        private void Draw(Graphics graphics, PointF point, float length, float angle, float deltaAngle, int recursionLevel)
        {
            float newAngle = angle + deltaAngle;
            float newLength = length * _lengthRatio;
            var newPoint = new PointF(
                point.X + (float)Math.Cos(newAngle) * newLength,
                point.Y + (float)Math.Sin(newAngle) * newLength
            );

            _render.DrawLine(graphics, new Pen(
                Utilities.Lerp(_gradientBeginning, _gradientEnding, (float)recursionLevel / (_recursionLevelLimit - 1)), 2),
                point, newPoint
            );
            Draw(graphics, newPoint, newLength, newAngle, recursionLevel + 1);
        }

        private readonly float _firstLineLength;
        private readonly float _lengthRatio;
        private readonly float _angle1;
        private readonly float _angle2;
    }
}
