using System.Drawing;

namespace Fractals
{
    class SierpinskiCarpet : Fractal
    {
        public SierpinskiCarpet(int recursionLevel, Color gradientBeginning, Color gradientEnding, Render render)
            : base(recursionLevel, gradientBeginning, gradientEnding, render)
        {

        }

        public override void Draw(Graphics graphics)
        {
            Draw(graphics, new RectangleF(-1, -1, 2, 2));
        }

        private void Draw(Graphics graphics, RectangleF rectangle, int recursionLevel = 1)
        {
            if (recursionLevel == _recursionLevelLimit)
            {
                _render.DrawFilledRectangle(graphics, new SolidBrush(_gradientEnding), rectangle);
                return;
            }

            float newSize = rectangle.Width / 3;

            var newX = rectangle.X;
            for (int i = 0; i < 3; ++i, newX += newSize)
            {
                var newY = rectangle.Y;
                for (int j = 0; j < 3; ++j, newY += newSize)
                {
                    var newRectangle = new RectangleF(new PointF(newX, newY), new SizeF(newSize, newSize));
                    // Rectangle in the centre.
                    if (i == 1 && j == 1)
                    {
                        var gradientColor = Utilities.Lerp(_gradientBeginning, _gradientEnding, (float)recursionLevel / _recursionLevelLimit);
                        _render.DrawFilledRectangle(graphics, new SolidBrush(gradientColor), newRectangle);
                    }
                    else
                    {
                        Draw(graphics, newRectangle, recursionLevel + 1);
                    }
                }
            }
        }
    }
}
