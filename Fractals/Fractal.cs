using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fractals
{
    abstract class Fractal
    {
        protected Fractal(int recursionLevel)
        {
            _recursionLevelLimit = recursionLevel;
        }

        public abstract void Draw(PaintEventArgs paintEventArgs);

        protected readonly int _recursionLevelLimit;
    }
}
