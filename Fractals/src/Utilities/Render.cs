using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Fractals
{
    class Render
    {
        public Render(float scale, float offsetX, float offsetY, SizeF canvasSize)
        {
            _scale = scale;
            _cameraOffsetX = offsetX;
            _cameraOffsetY = offsetY;
            _canvasSize = canvasSize;
        }

        public void DrawLine(Graphics graphics, Pen pen, PointF a, PointF b)
        {
            var screenA = PointToScreen(a);
            var screenB = PointToScreen(b);
            graphics.DrawLine(pen, screenA, screenB);
        }

        private (PointF, PointF) GetCameraBounds()
        {
            var topLeft = new PointF(
                _cameraOffsetX - 1f / _scale,
                _cameraOffsetY - 1f / _scale
            );
            var bottomRight = new PointF(
                _cameraOffsetX + 1f / _scale,
                _cameraOffsetY + 1f / _scale
            );
            return (topLeft, bottomRight);
        }

        private Point PointToScreen(PointF point)
        {
            var cameraBounds = GetCameraBounds();
            var xBounds = (cameraBounds.Item1.X, cameraBounds.Item2.X);
            var yBounds = (cameraBounds.Item1.Y, cameraBounds.Item2.Y);

            int x = Utilities.Round(Utilities.Lerp(0, _canvasSize.Width,
                (point.X - xBounds.Item1) / (xBounds.Item2 - xBounds.Item1)));
            int y = Utilities.Round(Utilities.Lerp(0, _canvasSize.Height,
                (point.Y - yBounds.Item1) / (yBounds.Item2 - yBounds.Item1)));

            return new Point(x, y);
        }

        private readonly float _scale;
        private readonly float _cameraOffsetX;
        private readonly float _cameraOffsetY;
        private readonly SizeF _canvasSize;
    }
}
