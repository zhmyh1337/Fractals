using System.Drawing;

namespace Fractals
{
    /// <summary>
    /// This is a helper class for drawing.
    /// It works with floating point coordinates.
    /// By default (w/o scaling and moving) topLeft coordinates are: (-1, -1), bottomRight: (1, 1).
    /// It also supports scaling and moving the camera.
    /// </summary>
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

        public void DrawTriangle(Graphics graphics, Pen pen, PointF a, PointF b, PointF c)
        {
            DrawLine(graphics, pen, a, b);
            DrawLine(graphics, pen, b, c);
            DrawLine(graphics, pen, c, a);
        }

        public void DrawFilledRectangle(Graphics graphics, Brush brush, RectangleF rectangle)
        {
            var topLeft = rectangle.Location;
            var bottomRight = new PointF(topLeft.X + rectangle.Width, topLeft.Y + rectangle.Height);

            var screenTopLeft = PointToScreen(topLeft);
            var screenBottomRight = PointToScreen(bottomRight);

            var screenRectangle = new Rectangle(screenTopLeft,
                new Size(screenBottomRight.X - screenTopLeft.X, screenBottomRight.Y - screenTopLeft.Y));
            graphics.FillRectangle(brush, screenRectangle);
        }

        /// <summary>
        /// Gets the current camera view. By default ((-1, -1), (1, 1)).
        /// </summary>
        /// <returns>Tuple (topLeft, bottomRight).</returns>
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
