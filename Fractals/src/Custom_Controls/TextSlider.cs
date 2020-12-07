using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Fractals
{
    public partial class TextSlider : UserControl
    {
        public event EventHandler OnChange;

        private float _value = 0f;
        private bool _roundValue = false;
        private float _sliderLowerBound = 0f;
        private float _sliderUpperBound = 1f;

        public TextSlider()
        {
            InitializeComponent();
        }

        public string Label
        {
            get
            {
                return label.Text;
            }
            set
            {
                label.Text = value;
            }
        }

        public float Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                Update();
            }
        }

        public float SliderLowerBound
        {
            get
            {
                return _sliderLowerBound;
            }
            set
            {
                _sliderLowerBound = value;
                Update();
            }
        }

        public float SliderUpperBound
        {
            get
            {
                return _sliderUpperBound;
            }
            set
            {
                _sliderUpperBound = value;
                Update();
            }
        }

        public bool RoundValue
        {
            get
            {
                return _roundValue;
            }
            set
            {
                _roundValue = value;
                Update();
            }
        }

        private new void Update()
        {
            UpdateDelta();
            UpdateValue();
            UpdateSliderValue();
            UpdateTextBoxValue();
        }

        private void UpdateValue()
        {
            if (_roundValue)
            {
                _value = Utilities.Round(_value);
            }
        }

        private void UpdateDelta()
        {
            // Making sure arrow keys increment/decrement our integer by one.
            if (_roundValue && _sliderUpperBound != _sliderLowerBound)
            {
                trackBar.SmallChange = trackBar.LargeChange = (int)Math.Ceiling((double)trackBar.Maximum /
                    (_sliderUpperBound - _sliderLowerBound));
            }
            else
            {
                trackBar.SmallChange = trackBar.LargeChange = 1;
            }
        }

        private void UpdateSliderValue()
        {
            float converted = _value - _sliderLowerBound;
            converted /= _sliderUpperBound - _sliderLowerBound;
            trackBar.Value = Math.Clamp(Utilities.Round(converted * trackBar.Maximum), trackBar.Minimum, trackBar.Maximum);
        }

        private void UpdateTextBoxValue()
        {
            textBox.Text = _value.ToString();
        }

        private void TextboxSubmitValue(object sender)
        {
            var textbox = sender as TextBox;
            if (float.TryParse(textbox.Text, out var newValue))
            {
                Value = newValue;
                OnChange?.Invoke(sender, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Incorrect value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.MainForm.ActiveControl = textbox;
            }
        }

        private void TextboxLeave(object sender, EventArgs e)
        {
            TextboxSubmitValue(sender);
        }

        private void TextboxKeypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TextboxSubmitValue(sender);
            }
        }

        private void TrackbarScroll(object sender, EventArgs e)
        {
            var trackbar = sender as TrackBar;
            Value = _sliderLowerBound + (_sliderUpperBound - _sliderLowerBound) * trackbar.Value / (trackbar.Maximum);
            OnChange?.Invoke(sender, EventArgs.Empty);
        }
    }
}
