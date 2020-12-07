using System;
using System.Windows.Forms;

namespace Fractals
{
    /// <summary>
    /// This custom control combines <see cref="TrackBar"/> and <see cref="TextBox"/> which share the same value.
    /// Also it has <see cref="System.Windows.Forms.Label"/> to display a name.
    /// </summary>
    public partial class TextSlider : UserControl
    {
        /// <summary>
        /// Invokes when used changed <see cref="TrackBar"/> or <see cref="TextBox"/>.
        /// </summary>
        public event EventHandler OnChange;

        public float ValueLowerBound { get; set; } = float.NegativeInfinity;
        public float ValueUpperBound { get; set; } = float.PositiveInfinity;
        public bool ValueLowerBoundIncluded { get; set; } = false;
        public bool ValueUpperBoundIncluded { get; set; } = false;

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
                return _label.Text;
            }
            set
            {
                _label.Text = value;
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
                if ((ValueLowerBoundIncluded ? value < ValueLowerBound : value <= ValueLowerBound) ||
                    (ValueUpperBoundIncluded ? value > ValueUpperBound : value >= ValueUpperBound)
                )
                {
                    throw new ArgumentOutOfRangeException("value", value,
                        $"Value must be >{(ValueLowerBoundIncluded ? "=" : "")}{ValueLowerBound} and <{(ValueUpperBoundIncluded ? "=" : "")}{ValueUpperBound}.");
                }
                _value = value;
                Update();
            }
        }

        /// <summary>
        /// <see cref="TrackBar"/>'s lower bound.
        /// </summary>
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
        
        /// <summary>
        /// <see cref="TrackBar"/>'s upper bound.
        /// </summary>
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

        /// <summary>
        /// Is integer.
        /// </summary>
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
                _trackBar.SmallChange = _trackBar.LargeChange = (int)Math.Ceiling((double)_trackBar.Maximum /
                    (_sliderUpperBound - _sliderLowerBound));
            }
            else
            {
                _trackBar.SmallChange = _trackBar.LargeChange = 1;
            }
        }

        private void UpdateSliderValue()
        {
            float converted = _value - _sliderLowerBound;
            converted /= _sliderUpperBound - _sliderLowerBound;
            _trackBar.Value = Math.Clamp(Utilities.Round(converted * _trackBar.Maximum), _trackBar.Minimum, _trackBar.Maximum);
        }

        private void UpdateTextBoxValue()
        {
            _textBox.Text = _value.ToString();
        }
        
        /// <summary>
        /// When the user is done changing the textbox (either by leaving it or by pressing Enter).
        /// </summary>
        private void TextboxSubmitValue(object sender)
        {
            var textbox = sender as TextBox;
            try
            {
                Value = float.Parse(_textBox.Text);
            }
            catch (Exception e)
            {
                string message = e is ArgumentOutOfRangeException ? e.Message : "Incorrect value.";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.MainForm.ActiveControl = textbox;
                return;
            }
            OnChange?.Invoke(sender, EventArgs.Empty);
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
