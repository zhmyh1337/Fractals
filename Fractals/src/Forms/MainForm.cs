using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractals
{
    public partial class MainForm : Form
    {
        // Caching for convenience.
        private Panel _canvasPanel;
        private Panel _optionsPanel;

        public MainForm()
        {
            InitializeComponent();

            _canvasPanel = splitContainer.Panel1;
            _optionsPanel = splitContainer.Panel2;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // In order to fix some weird displaying inside splitContainer border.
            ActiveControl = _optionsPanel;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            (sender as Panel).BackColor = Color.Red;
        }

        private void FractalPaint(object sender, PaintEventArgs e)
        {
            var x = new PythagoreanTree(15, Color.Blue, Color.Red);
            x.Draw(e);
        }
    }
}
