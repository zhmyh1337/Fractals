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

        private Color _gradientColorA = Color.Blue;
        private Color _gradientColorB = Color.Red;

        public MainForm()
        {
            InitializeComponent();

            _canvasPanel = _splitContainer.Panel1;
            _optionsPanel = _splitContainer.Panel2;

            UpdateGradientColorButtons();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // In order to fix some weird displaying inside splitContainer border.
            ActiveControl = _optionsPanel;
        }

        private void FractalPaint(object sender, PaintEventArgs e)
        {
            if (_fractalCombobox.SelectedItem == null)
            {
                return;
            }

            var render = new Render(_scaleTextslider.Value, _cameraXOffsetTextslider.Value, _cameraYOffsetTextslider.Value, _canvasPanel.Size);

            Fractal fractal = _fractalCombobox.SelectedIndex switch
            {
                0 => new PythagoreanTree((int)_recursionTextslider.Value, _gradientColorA, _gradientColorB, render,
                    _ptFirstLineLengthTextslider.Value, _ptLengthRatioTextslider.Value, _ptAngle1Textslider.Value, _ptAngle2Textslider.Value),
                1 => new KochCurve((int)_recursionTextslider.Value, _gradientColorA, _gradientColorB, render),
                2 => new SierpinskiCarpet((int)_recursionTextslider.Value, _gradientColorA, _gradientColorB, render),
                3 => new SierpinskiTriangle((int)_recursionTextslider.Value, _gradientColorA, _gradientColorB, render),
                4 => new CantorSet((int)_recursionTextslider.Value, _gradientColorA, _gradientColorB, render,
                    _csVerticalDistanceTextslider.Value, _csHorizontalDistanceTextslider.Value, _csWidthTextslider.Value),
                _ => throw new NotImplementedException()
            };

            fractal.Draw(e.Graphics);
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

        private void ValuesUpdate(object sender, EventArgs e)
        {
            if (_autoRedrawCheckbox.Checked)
            {
                _canvasPanel.Invalidate();
            }
        }

        private void UpdateGradientColorButtons()
        {
            _gradientColorAButton.ForeColor = _gradientColorA;
            _gradientColorBButton.ForeColor = _gradientColorB;
        }

        private void ChooseGradientColorButtonClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            bool gradientColorA = button.Text.EndsWith('A');
            var colorDialog = new ColorDialog();
            colorDialog.Color = gradientColorA ? _gradientColorA : _gradientColorB;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                (gradientColorA ? ref _gradientColorA : ref _gradientColorB) = colorDialog.Color;
                UpdateGradientColorButtons();
                ValuesUpdate(null, EventArgs.Empty);
            }
        }

        private void DrawButtonClick(object sender, EventArgs e)
        {
            if (_fractalCombobox.SelectedItem == null)
            {
                MessageBox.Show("First select a fractal to draw.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _canvasPanel.Invalidate();
        }

        private void ResetButtonClick(object sender, EventArgs e)
        {
            _recursionTextslider.Value = 10;
            _scaleTextslider.Value = 1;
            _cameraXOffsetTextslider.Value = 0;
            _cameraYOffsetTextslider.Value = 0;
            _canvasPanel.Invalidate();
        }

        private void FractalTypeChange(object sender, EventArgs e)
        {
            _ptOptionsPanel.Visible = false;
            _csOptionsPanel.Visible = false;

            switch (_fractalCombobox.SelectedIndex)
            {
                case 0:
                    _ptOptionsPanel.Visible = true;
                    break;
                case 4:
                    _csOptionsPanel.Visible = true;
                    break;
                default:
                    break;
            }

            ValuesUpdate(sender, e);
        }
    }
}
