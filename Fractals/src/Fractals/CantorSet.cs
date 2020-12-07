using System.Drawing;

namespace Fractals
{
    class CantorSet : Fractal
    {
        public CantorSet(int recursionLevel, Color gradientBeginning, Color gradientEnding, Render render,
            float verticalDistance, float horizontalDistance, float width)
            : base(recursionLevel, gradientBeginning, gradientEnding, render)
        {
            _verticalDistance = verticalDistance;
            _horizontalDistance = horizontalDistance;
            _width = width;
        }

        public override void Draw(Graphics graphics)
        {
            Draw(graphics, -1f, -1f, 1f);
        }

        private void Draw(Graphics graphics, float y, float xFrom, float xTo, int recursionLevel = 0)
        {
            var gradientColor = Utilities.Lerp(_gradientBeginning, _gradientEnding, (float)recursionLevel / _recursionLevelLimit);
//             _render.DrawLine(graphics,
//                 new Pen(gradientColor, 5),
//                 new PointF(xFrom, y), new PointF(xTo, y)
//             );
            _render.DrawFilledRectangle(graphics, new SolidBrush(gradientColor), new RectangleF(xFrom, y, xTo - xFrom, _width));

            if (recursionLevel == _recursionLevelLimit)
            {
                return;
            }

            float a = Utilities.Lerp(xFrom, xTo, 0.5f - _horizontalDistance);
            float b = Utilities.Lerp(xFrom, xTo, 0.5f + _horizontalDistance);
            Draw(graphics, y + _verticalDistance, xFrom, a, recursionLevel + 1);
            Draw(graphics, y + _verticalDistance, b, xTo, recursionLevel + 1);
        }
        
        private readonly float _verticalDistance;
        private readonly float _horizontalDistance;
        private readonly float _width;
    }
}
