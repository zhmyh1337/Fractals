namespace Fractals
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._splitContainer = new System.Windows.Forms.SplitContainer();
            this._specialOptionsPanel = new System.Windows.Forms.Panel();
            this.textSlider4 = new Fractals.TextSlider();
            this.textSlider3 = new Fractals.TextSlider();
            this.textSlider2 = new Fractals.TextSlider();
            this.textSlider1 = new Fractals.TextSlider();
            this._commonOptionsPanel = new System.Windows.Forms.Panel();
            this._gradientColorBButton = new System.Windows.Forms.Button();
            this._gradientColorAButton = new System.Windows.Forms.Button();
            this._saveButton = new System.Windows.Forms.Button();
            this._resetButton = new System.Windows.Forms.Button();
            this._drawButton = new System.Windows.Forms.Button();
            this._cameraYOffsetTextslider = new Fractals.TextSlider();
            this._cameraXOffsetTextslider = new Fractals.TextSlider();
            this._scaleTextslider = new Fractals.TextSlider();
            this._recursionTextslider = new Fractals.TextSlider();
            this._autoRedrawCheckbox = new System.Windows.Forms.CheckBox();
            this._fractalCombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            this._specialOptionsPanel.SuspendLayout();
            this._commonOptionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _splitContainer
            // 
            this._splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainer.IsSplitterFixed = true;
            this._splitContainer.Location = new System.Drawing.Point(0, 0);
            this._splitContainer.Name = "_splitContainer";
            // 
            // _splitContainer.Panel1
            // 
            this._splitContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.FractalPaint);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.Controls.Add(this._specialOptionsPanel);
            this._splitContainer.Panel2.Controls.Add(this._commonOptionsPanel);
            this._splitContainer.Size = new System.Drawing.Size(959, 578);
            this._splitContainer.SplitterDistance = 578;
            this._splitContainer.SplitterWidth = 1;
            this._splitContainer.TabIndex = 0;
            this._splitContainer.Text = "splitContainer";
            // 
            // _specialOptionsPanel
            // 
            this._specialOptionsPanel.Controls.Add(this.textSlider4);
            this._specialOptionsPanel.Controls.Add(this.textSlider3);
            this._specialOptionsPanel.Controls.Add(this.textSlider2);
            this._specialOptionsPanel.Controls.Add(this.textSlider1);
            this._specialOptionsPanel.Location = new System.Drawing.Point(4, 341);
            this._specialOptionsPanel.Name = "_specialOptionsPanel";
            this._specialOptionsPanel.Size = new System.Drawing.Size(368, 230);
            this._specialOptionsPanel.TabIndex = 1;
            // 
            // textSlider4
            // 
            this.textSlider4.AutoSize = true;
            this.textSlider4.Label = "label";
            this.textSlider4.Location = new System.Drawing.Point(0, 168);
            this.textSlider4.Name = "textSlider4";
            this.textSlider4.RoundValue = false;
            this.textSlider4.Size = new System.Drawing.Size(358, 59);
            this.textSlider4.SliderLowerBound = 0F;
            this.textSlider4.SliderUpperBound = 1F;
            this.textSlider4.TabIndex = 0;
            this.textSlider4.Value = 0F;
            this.textSlider4.ValueLowerBound = float.NegativeInfinity;
            this.textSlider4.ValueLowerBoundIncluded = false;
            this.textSlider4.ValueUpperBound = float.PositiveInfinity;
            this.textSlider4.ValueUpperBoundIncluded = false;
            // 
            // textSlider3
            // 
            this.textSlider3.AutoSize = true;
            this.textSlider3.Label = "label";
            this.textSlider3.Location = new System.Drawing.Point(0, 112);
            this.textSlider3.Name = "textSlider3";
            this.textSlider3.RoundValue = false;
            this.textSlider3.Size = new System.Drawing.Size(358, 59);
            this.textSlider3.SliderLowerBound = 0F;
            this.textSlider3.SliderUpperBound = 1F;
            this.textSlider3.TabIndex = 0;
            this.textSlider3.Value = 0F;
            this.textSlider3.ValueLowerBound = float.NegativeInfinity;
            this.textSlider3.ValueLowerBoundIncluded = false;
            this.textSlider3.ValueUpperBound = float.PositiveInfinity;
            this.textSlider3.ValueUpperBoundIncluded = false;
            // 
            // textSlider2
            // 
            this.textSlider2.AutoSize = true;
            this.textSlider2.Label = "label";
            this.textSlider2.Location = new System.Drawing.Point(0, 56);
            this.textSlider2.Name = "textSlider2";
            this.textSlider2.RoundValue = false;
            this.textSlider2.Size = new System.Drawing.Size(358, 59);
            this.textSlider2.SliderLowerBound = 0F;
            this.textSlider2.SliderUpperBound = 1F;
            this.textSlider2.TabIndex = 0;
            this.textSlider2.Value = 0F;
            this.textSlider2.ValueLowerBound = float.NegativeInfinity;
            this.textSlider2.ValueLowerBoundIncluded = false;
            this.textSlider2.ValueUpperBound = float.PositiveInfinity;
            this.textSlider2.ValueUpperBoundIncluded = false;
            // 
            // textSlider1
            // 
            this.textSlider1.AutoSize = true;
            this.textSlider1.Label = "label";
            this.textSlider1.Location = new System.Drawing.Point(0, 0);
            this.textSlider1.Name = "textSlider1";
            this.textSlider1.RoundValue = false;
            this.textSlider1.Size = new System.Drawing.Size(358, 59);
            this.textSlider1.SliderLowerBound = 0F;
            this.textSlider1.SliderUpperBound = 1F;
            this.textSlider1.TabIndex = 0;
            this.textSlider1.Value = 0F;
            this.textSlider1.ValueLowerBound = float.NegativeInfinity;
            this.textSlider1.ValueLowerBoundIncluded = false;
            this.textSlider1.ValueUpperBound = float.PositiveInfinity;
            this.textSlider1.ValueUpperBoundIncluded = false;
            // 
            // _commonOptionsPanel
            // 
            this._commonOptionsPanel.Controls.Add(this._gradientColorBButton);
            this._commonOptionsPanel.Controls.Add(this._gradientColorAButton);
            this._commonOptionsPanel.Controls.Add(this._saveButton);
            this._commonOptionsPanel.Controls.Add(this._resetButton);
            this._commonOptionsPanel.Controls.Add(this._drawButton);
            this._commonOptionsPanel.Controls.Add(this._cameraYOffsetTextslider);
            this._commonOptionsPanel.Controls.Add(this._cameraXOffsetTextslider);
            this._commonOptionsPanel.Controls.Add(this._scaleTextslider);
            this._commonOptionsPanel.Controls.Add(this._recursionTextslider);
            this._commonOptionsPanel.Controls.Add(this._autoRedrawCheckbox);
            this._commonOptionsPanel.Controls.Add(this._fractalCombobox);
            this._commonOptionsPanel.Location = new System.Drawing.Point(4, 4);
            this._commonOptionsPanel.Name = "_commonOptionsPanel";
            this._commonOptionsPanel.Size = new System.Drawing.Size(368, 331);
            this._commonOptionsPanel.TabIndex = 0;
            // 
            // _gradientColorBButton
            // 
            this._gradientColorBButton.Location = new System.Drawing.Point(190, 260);
            this._gradientColorBButton.Name = "_gradientColorBButton";
            this._gradientColorBButton.Size = new System.Drawing.Size(178, 29);
            this._gradientColorBButton.TabIndex = 5;
            this._gradientColorBButton.Text = "Choose gradient color B";
            this._gradientColorBButton.UseVisualStyleBackColor = true;
            this._gradientColorBButton.Click += new System.EventHandler(this.ChooseGradientColorButtonClick);
            // 
            // _gradientColorAButton
            // 
            this._gradientColorAButton.Location = new System.Drawing.Point(0, 260);
            this._gradientColorAButton.Name = "_gradientColorAButton";
            this._gradientColorAButton.Size = new System.Drawing.Size(178, 29);
            this._gradientColorAButton.TabIndex = 5;
            this._gradientColorAButton.Text = "Choose gradient color A";
            this._gradientColorAButton.UseVisualStyleBackColor = true;
            this._gradientColorAButton.Click += new System.EventHandler(this.ChooseGradientColorButtonClick);
            // 
            // _saveButton
            // 
            this._saveButton.Location = new System.Drawing.Point(260, 294);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(94, 29);
            this._saveButton.TabIndex = 4;
            this._saveButton.Text = "Save";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // _resetButton
            // 
            this._resetButton.Location = new System.Drawing.Point(137, 294);
            this._resetButton.Name = "_resetButton";
            this._resetButton.Size = new System.Drawing.Size(94, 29);
            this._resetButton.TabIndex = 4;
            this._resetButton.Text = "Reset";
            this._resetButton.UseVisualStyleBackColor = true;
            this._resetButton.Click += new System.EventHandler(this.ResetButtonClick);
            // 
            // _drawButton
            // 
            this._drawButton.Location = new System.Drawing.Point(13, 294);
            this._drawButton.Name = "_drawButton";
            this._drawButton.Size = new System.Drawing.Size(94, 29);
            this._drawButton.TabIndex = 4;
            this._drawButton.Text = "Draw";
            this._drawButton.UseVisualStyleBackColor = true;
            this._drawButton.Click += new System.EventHandler(this.DrawButtonClick);
            // 
            // _cameraYOffsetTextslider
            // 
            this._cameraYOffsetTextslider.AutoSize = true;
            this._cameraYOffsetTextslider.Label = "camera y offset:";
            this._cameraYOffsetTextslider.Location = new System.Drawing.Point(0, 203);
            this._cameraYOffsetTextslider.Name = "_cameraYOffsetTextslider";
            this._cameraYOffsetTextslider.RoundValue = false;
            this._cameraYOffsetTextslider.Size = new System.Drawing.Size(358, 59);
            this._cameraYOffsetTextslider.SliderLowerBound = -5F;
            this._cameraYOffsetTextslider.SliderUpperBound = 5F;
            this._cameraYOffsetTextslider.TabIndex = 3;
            this._cameraYOffsetTextslider.Value = 0F;
            this._cameraYOffsetTextslider.ValueLowerBound = -10000F;
            this._cameraYOffsetTextslider.ValueLowerBoundIncluded = true;
            this._cameraYOffsetTextslider.ValueUpperBound = 10000F;
            this._cameraYOffsetTextslider.ValueUpperBoundIncluded = true;
            this._cameraYOffsetTextslider.OnChange += new System.EventHandler(this.ValuesUpdate);
            // 
            // _cameraXOffsetTextslider
            // 
            this._cameraXOffsetTextslider.AutoSize = true;
            this._cameraXOffsetTextslider.Label = "camera x offset:";
            this._cameraXOffsetTextslider.Location = new System.Drawing.Point(0, 147);
            this._cameraXOffsetTextslider.Name = "_cameraXOffsetTextslider";
            this._cameraXOffsetTextslider.RoundValue = false;
            this._cameraXOffsetTextslider.Size = new System.Drawing.Size(358, 59);
            this._cameraXOffsetTextslider.SliderLowerBound = -5F;
            this._cameraXOffsetTextslider.SliderUpperBound = 5F;
            this._cameraXOffsetTextslider.TabIndex = 3;
            this._cameraXOffsetTextslider.Value = 0F;
            this._cameraXOffsetTextslider.ValueLowerBound = -10000F;
            this._cameraXOffsetTextslider.ValueLowerBoundIncluded = true;
            this._cameraXOffsetTextslider.ValueUpperBound = 10000F;
            this._cameraXOffsetTextslider.ValueUpperBoundIncluded = true;
            this._cameraXOffsetTextslider.OnChange += new System.EventHandler(this.ValuesUpdate);
            // 
            // _scaleTextslider
            // 
            this._scaleTextslider.AutoSize = true;
            this._scaleTextslider.Label = "scale:";
            this._scaleTextslider.Location = new System.Drawing.Point(0, 91);
            this._scaleTextslider.Name = "_scaleTextslider";
            this._scaleTextslider.RoundValue = false;
            this._scaleTextslider.Size = new System.Drawing.Size(358, 59);
            this._scaleTextslider.SliderLowerBound = 0.5F;
            this._scaleTextslider.SliderUpperBound = 10F;
            this._scaleTextslider.TabIndex = 3;
            this._scaleTextslider.Value = 1F;
            this._scaleTextslider.ValueLowerBound = -10000F;
            this._scaleTextslider.ValueLowerBoundIncluded = true;
            this._scaleTextslider.ValueUpperBound = 10000F;
            this._scaleTextslider.ValueUpperBoundIncluded = true;
            this._scaleTextslider.OnChange += new System.EventHandler(this.ValuesUpdate);
            // 
            // _recursionTextslider
            // 
            this._recursionTextslider.AutoSize = true;
            this._recursionTextslider.Label = "recursion level:";
            this._recursionTextslider.Location = new System.Drawing.Point(0, 35);
            this._recursionTextslider.Name = "_recursionTextslider";
            this._recursionTextslider.RoundValue = true;
            this._recursionTextslider.Size = new System.Drawing.Size(358, 59);
            this._recursionTextslider.SliderLowerBound = 1F;
            this._recursionTextslider.SliderUpperBound = 20F;
            this._recursionTextslider.TabIndex = 2;
            this._recursionTextslider.Value = 10F;
            this._recursionTextslider.ValueLowerBound = 1F;
            this._recursionTextslider.ValueLowerBoundIncluded = true;
            this._recursionTextslider.ValueUpperBound = 50F;
            this._recursionTextslider.ValueUpperBoundIncluded = true;
            this._recursionTextslider.OnChange += new System.EventHandler(this.ValuesUpdate);
            // 
            // _autoRedrawCheckbox
            // 
            this._autoRedrawCheckbox.AutoSize = true;
            this._autoRedrawCheckbox.Location = new System.Drawing.Point(247, 2);
            this._autoRedrawCheckbox.Name = "_autoRedrawCheckbox";
            this._autoRedrawCheckbox.Size = new System.Drawing.Size(111, 24);
            this._autoRedrawCheckbox.TabIndex = 1;
            this._autoRedrawCheckbox.Text = "auto redraw";
            this._autoRedrawCheckbox.UseVisualStyleBackColor = true;
            // 
            // _fractalCombobox
            // 
            this._fractalCombobox.FormattingEnabled = true;
            this._fractalCombobox.Location = new System.Drawing.Point(0, 0);
            this._fractalCombobox.Name = "_fractalCombobox";
            this._fractalCombobox.Size = new System.Drawing.Size(243, 28);
            this._fractalCombobox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 578);
            this.Controls.Add(this._splitContainer);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fractals";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this._splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            this._specialOptionsPanel.ResumeLayout(false);
            this._specialOptionsPanel.PerformLayout();
            this._commonOptionsPanel.ResumeLayout(false);
            this._commonOptionsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer _splitContainer;
        private System.Windows.Forms.Panel _commonOptionsPanel;
        private TextSlider _recursionTextslider;
        private System.Windows.Forms.CheckBox _autoRedrawCheckbox;
        private System.Windows.Forms.ComboBox _fractalCombobox;
        private TextSlider _scaleTextslider;
        private TextSlider _cameraXOffsetTextslider;
        private TextSlider _cameraYOffsetTextslider;
        private System.Windows.Forms.Button _drawButton;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Button _resetButton;
        private System.Windows.Forms.Button _gradientColorAButton;
        private System.Windows.Forms.Button _gradientColorBButton;
        private System.Windows.Forms.Panel _specialOptionsPanel;
        private TextSlider textSlider2;
        private TextSlider textSlider1;
        private TextSlider textSlider4;
        private TextSlider textSlider3;
    }
}

