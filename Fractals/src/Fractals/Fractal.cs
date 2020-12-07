using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fractals
{
    abstract class Fractal
    {
        protected Fractal(int recursionLevel, Color gradientBeginning, Color gradientEnding, Render render)
        {
            _recursionLevelLimit = recursionLevel;
            _gradientBeginning = gradientBeginning;
            _gradientEnding = gradientEnding;
            _render = render;
        }

        public abstract void Draw(Graphics graphics);

        protected readonly int _recursionLevelLimit;
        protected readonly Color _gradientBeginning;
        protected readonly Color _gradientEnding;
        protected readonly Render _render;
    }
}
