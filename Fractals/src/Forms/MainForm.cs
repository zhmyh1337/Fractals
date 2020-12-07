using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

        private void FractalPaint(object sender, PaintEventArgs e)
        {
            var x = new PythagoreanTree(10, Color.Blue, Color.Red);
            x.Draw(e.Graphics);
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "png (*.png)|*.png|jpeg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|tiff (*.tiff)|*.tiff";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var format = Path.GetExtension(saveFileDialog.FileName) switch
                    {
                        ".png" => ImageFormat.Png,
                        ".jpg" => ImageFormat.Jpeg,
                        ".bmp" => ImageFormat.Bmp,
                        ".tiff" => ImageFormat.Tiff,
                        _ => throw new Exception()
                    };
                    var bmp = new Bitmap(_canvasPanel.Width, _canvasPanel.Height);
                    _canvasPanel.DrawToBitmap(bmp, new Rectangle(0, 0, _canvasPanel.Width, _canvasPanel.Height));
                    bmp.Save(saveFileDialog.FileName, format);
                }
                catch
                {
                    MessageBox.Show("An error occurred while writing to the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
