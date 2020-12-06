using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fractals
{
    abstract class Fractal
    {
        protected Fractal(int recursionLevel, Color gradientBeginning, Color gradientEnding)
        {
            _recursionLevelLimit = recursionLevel;
            _gradientBeginning = gradientBeginning;
            _gradientEnding = gradientEnding;
        }

        public abstract void Draw(Graphics graphics);

        protected readonly int _recursionLevelLimit;
        protected readonly Color _gradientBeginning;
        protected readonly Color _gradientEnding;
    }
}
