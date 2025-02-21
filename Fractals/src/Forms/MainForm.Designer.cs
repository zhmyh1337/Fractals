﻿namespace Fractals
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
            this._ptOptionsPanel = new System.Windows.Forms.Panel();
            this._ptAngle2Textslider = new Fractals.TextSlider();
            this._ptAngle1Textslider = new Fractals.TextSlider();
            this._ptLengthRatioTextslider = new Fractals.TextSlider();
            this._ptFirstLineLengthTextslider = new Fractals.TextSlider();
            this._csOptionsPanel = new System.Windows.Forms.Panel();
            this._csVerticalDistanceTextslider = new Fractals.TextSlider();
            this._csHorizontalDistanceTextslider = new Fractals.TextSlider();
            this._csWidthTextslider = new Fractals.TextSlider();
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
            this._ptOptionsPanel.SuspendLayout();
            this._csOptionsPanel.SuspendLayout();
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
            this._splitContainer.Panel2.Controls.Add(this._ptOptionsPanel);
            this._splitContainer.Panel2.Controls.Add(this._csOptionsPanel);
            this._splitContainer.Panel2.Controls.Add(this._commonOptionsPanel);
            this._splitContainer.Size = new System.Drawing.Size(959, 578);
            this._splitContainer.SplitterDistance = 578;
            this._splitContainer.SplitterWidth = 1;
            this._splitContainer.TabIndex = 0;
            this._splitContainer.Text = "splitContainer";
            // 
            // _ptOptionsPanel
            // 
            this._ptOptionsPanel.Controls.Add(this._ptAngle2Textslider);
            this._ptOptionsPanel.Controls.Add(this._ptAngle1Textslider);
            this._ptOptionsPanel.Controls.Add(this._ptLengthRatioTextslider);
            this._ptOptionsPanel.Controls.Add(this._ptFirstLineLengthTextslider);
            this._ptOptionsPanel.Location = new System.Drawing.Point(4, 341);
            this._ptOptionsPanel.Name = "_ptOptionsPanel";
            this._ptOptionsPanel.Size = new System.Drawing.Size(368, 230);
            this._ptOptionsPanel.TabIndex = 1;
            this._ptOptionsPanel.Visible = false;
            // 
            // _ptAngle2Textslider
            // 
            this._ptAngle2Textslider.AutoSize = true;
            this._ptAngle2Textslider.Label = "angle2:";
            this._ptAngle2Textslider.Location = new System.Drawing.Point(0, 168);
            this._ptAngle2Textslider.Name = "_ptAngle2Textslider";
            this._ptAngle2Textslider.RoundValue = false;
            this._ptAngle2Textslider.Size = new System.Drawing.Size(358, 59);
            this._ptAngle2Textslider.SliderLowerBound = -180F;
            this._ptAngle2Textslider.SliderUpperBound = 180F;
            this._ptAngle2Textslider.TabIndex = 0;
            this._ptAngle2Textslider.Value = 45F;
            this._ptAngle2Textslider.ValueLowerBound = -10000F;
            this._ptAngle2Textslider.ValueLowerBoundIncluded = true;
            this._ptAngle2Textslider.ValueUpperBound = 10000F;
            this._ptAngle2Textslider.ValueUpperBoundIncluded = true;
            this._ptAngle2Textslider.OnChange += new System.EventHandler(this.ValuesUpdate);
            // 
            // _ptAngle1Textslider
            // 
            this._ptAngle1Textslider.AutoSize = true;
            this._ptAngle1Textslider.Label = "angle1:";
            this._ptAngle1Textslider.Location = new System.Drawing.Point(0, 112);
            this._ptAngle1Textslider.Name = "_ptAngle1Textslider";
            this._ptAngle1Textslider.RoundValue = false;
            this._ptAngle1Textslider.Size = new System.Drawing.Size(358, 59);
            this._ptAngle1Textslider.SliderLowerBound = -180F;
            this._ptAngle1Textslider.SliderUpperBound = 180F;
            this._ptAngle1Textslider.TabIndex = 0;
            this._ptAngle1Textslider.Value = -30F;
            this._ptAngle1Textslider.ValueLowerBound = -10000F;
            this._ptAngle1Textslider.ValueLowerBoundIncluded = true;
            this._ptAngle1Textslider.ValueUpperBound = 10000F;
            this._ptAngle1Textslider.ValueUpperBoundIncluded = true;
            this._ptAngle1Textslider.OnChange += new System.EventHandler(this.ValuesUpdate);
            // 
            // _ptLengthRatioTextslider
            // 
            this._ptLengthRatioTextslider.AutoSize = true;
            this._ptLengthRatioTextslider.Label = "length ratio:";
            this._ptLengthRatioTextslider.Location = new System.Drawing.Point(0, 56);
            this._ptLengthRatioTextslider.Name = "_ptLengthRatioTextslider";
            this._ptLengthRatioTextslider.RoundValue = false;
            this._ptLengthRatioTextslider.Size = new System.Drawing.Size(358, 59);
            this._ptLengthRatioTextslider.SliderLowerBound = 0F;
            this._ptLengthRatioTextslider.SliderUpperBound = 1F;
            this._ptLengthRatioTextslider.TabIndex = 0;
            this._ptLengthRatioTextslider.Value = 0.66666F;
            this._ptLengthRatioTextslider.ValueLowerBound = 0F;
            this._ptLengthRatioTextslider.ValueLowerBoundIncluded = true;
            this._ptLengthRatioTextslider.ValueUpperBound = 1F;
            this._ptLengthRatioTextslider.ValueUpperBoundIncluded = true;
            this._ptLengthRatioTextslider.OnChange += new System.EventHandler(this.ValuesUpdate);
            // 
            // _ptFirstLineLengthTextslider
            // 
            this._ptFirstLineLengthTextslider.AutoSize = true;
            this._ptFirstLineLengthTextslider.Label = "first line length:";
            this._ptFirstLineLengthTextslider.Location = new System.Drawing.Point(0, 0);
            this._ptFirstLineLengthTextslider.Name = "_ptFirstLineLengthTextslider";
            this._ptFirstLineLengthTextslider.RoundValue = false;
            this._ptFirstLineLengthTextslider.Size = new System.Drawing.Size(358, 59);
            this._ptFirstLineLengthTextslider.SliderLowerBound = 0F;
            this._ptFirstLineLengthTextslider.SliderUpperBound = 2F;
            this._ptFirstLineLengthTextslider.TabIndex = 0;
            this._ptFirstLineLengthTextslider.Value = 0.6F;
            this._ptFirstLineLengthTextslider.ValueLowerBound = 0F;
            this._ptFirstLineLengthTextslider.ValueLowerBoundIncluded = true;
            this._ptFirstLineLengthTextslider.ValueUpperBound = 10000F;
            this._ptFirstLineLengthTextslider.ValueUpperBoundIncluded = true;
            this._ptFirstLineLengthTextslider.OnChange += new System.EventHandler(this.ValuesUpdate);
            // 
            // _csOptionsPanel
            // 
            this._csOptionsPanel.Controls.Add(this._csVerticalDistanceTextslider);
            this._csOptionsPanel.Controls.Add(this._csHorizontalDistanceTextslider);
            this._csOptionsPanel.Controls.Add(this._csWidthTextslider);
            this._csOptionsPanel.Location = new System.Drawing.Point(4, 341);
            this._csOptionsPanel.Name = "_csOptionsPanel";
            this._csOptionsPanel.Size = new System.Drawing.Size(368, 230);
            this._csOptionsPanel.TabIndex = 1;
            this._csOptionsPanel.Visible = false;
            // 
            // _csVerticalDistanceTextslider
            // 
            this._csVerticalDistanceTextslider.AutoSize = true;
            this._csVerticalDistanceTextslider.Label = "vert. distance:";
            this._csVerticalDistanceTextslider.Location = new System.Drawing.Point(0, 0);
            this._csVerticalDistanceTextslider.Name = "_csVerticalDistanceTextslider";
            this._csVerticalDistanceTextslider.RoundValue = false;
            this._csVerticalDistanceTextslider.Size = new System.Drawing.Size(358, 59);
            this._csVerticalDistanceTextslider.SliderLowerBound = 0F;
            this._csVerticalDistanceTextslider.SliderUpperBound = 1F;
            this._csVerticalDistanceTextslider.TabIndex = 0;
            this._csVerticalDistanceTextslider.Value = 0.05F;
            this._csVerticalDistanceTextslider.ValueLowerBound = 0F;
            this._csVerticalDistanceTextslider.ValueLowerBoundIncluded = true;
            this._csVerticalDistanceTextslider.ValueUpperBound = 10F;
            this._csVerticalDistanceTextslider.ValueUpperBoundIncluded = true;
            this._csVerticalDistanceTextslider.OnChange += new System.EventHandler(this.ValuesUpdate);
            // 
            // _csHorizontalDistanceTextslider
            // 
            this._csHorizontalDistanceTextslider.AutoSize = true;
            this._csHorizontalDistanceTextslider.Label = "hor. distance:";
            this._csHorizontalDistanceTextslider.Location = new System.Drawing.Point(0, 56);
            this._csHorizontalDistanceTextslider.Name = "_csHorizontalDistanceTextslider";
            this._csHorizontalDistanceTextslider.RoundValue = false;
            this._csHorizontalDistanceTextslider.Size = new System.Drawing.Size(358, 59);
            this._csHorizontalDistanceTextslider.SliderLowerBound = 0F;
            this._csHorizontalDistanceTextslider.SliderUpperBound = 0.5F;
            this._csHorizontalDistanceTextslider.TabIndex = 0;
            this._csHorizontalDistanceTextslider.Value = 0.166666666F;
            this._csHorizontalDistanceTextslider.ValueLowerBound = 0F;
            this._csHorizontalDistanceTextslider.ValueLowerBoundIncluded = true;
            this._csHorizontalDistanceTextslider.ValueUpperBound = 0.5F;
            this._csHorizontalDistanceTextslider.ValueUpperBoundIncluded = true;
            this._csHorizontalDistanceTextslider.OnChange += new System.EventHandler(this.ValuesUpdate);
            // 
            // _csWidthTextslider
            // 
            this._csWidthTextslider.AutoSize = true;
            this._csWidthTextslider.Label = "width:";
            this._csWidthTextslider.Location = new System.Drawing.Point(0, 112);
            this._csWidthTextslider.Name = "_csWidthTextslider";
            this._csWidthTextslider.RoundValue = false;
            this._csWidthTextslider.Size = new System.Drawing.Size(358, 59);
            this._csWidthTextslider.SliderLowerBound = 0F;
            this._csWidthTextslider.SliderUpperBound = 0.1F;
            this._csWidthTextslider.TabIndex = 0;
            this._csWidthTextslider.Value = 0.025F;
            this._csWidthTextslider.ValueLowerBound = 0F;
            this._csWidthTextslider.ValueLowerBoundIncluded = true;
            this._csWidthTextslider.ValueUpperBound = 2F;
            this._csWidthTextslider.ValueUpperBoundIncluded = true;
            this._csWidthTextslider.OnChange += new System.EventHandler(this.ValuesUpdate);
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
            this._fractalCombobox.DisplayMember = "0";
            this._fractalCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._fractalCombobox.FormattingEnabled = true;
            this._fractalCombobox.Items.AddRange(new object[] {
            "Pythagoras tree",
            "Koch curve",
            "Sierpiński carpet",
            "Sierpiński triangle",
            "Cantor set"});
            this._fractalCombobox.Location = new System.Drawing.Point(0, 0);
            this._fractalCombobox.Name = "_fractalCombobox";
            this._fractalCombobox.Size = new System.Drawing.Size(243, 28);
            this._fractalCombobox.TabIndex = 0;
            this._fractalCombobox.SelectedIndexChanged += new System.EventHandler(this.FractalTypeChange);
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
            this.Load += new System.EventHandler(this.MainFormLoad);
            this._splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            this._ptOptionsPanel.ResumeLayout(false);
            this._ptOptionsPanel.PerformLayout();
            this._csOptionsPanel.ResumeLayout(false);
            this._csOptionsPanel.PerformLayout();
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
        private TextSlider _ptLengthRatioTextslider;
        private TextSlider _ptFirstLineLengthTextslider;
        private TextSlider _ptAngle2Textslider;
        private TextSlider _ptAngle1Textslider;
        private System.Windows.Forms.Panel _ptOptionsPanel;
        private System.Windows.Forms.Panel _csOptionsPanel;
        private TextSlider _csVerticalDistanceTextslider;
        private TextSlider _csHorizontalDistanceTextslider;
        private TextSlider _csWidthTextslider;
    }
}

