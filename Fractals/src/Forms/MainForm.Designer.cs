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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gradientColorBButton = new System.Windows.Forms.Button();
            this.gradientColorAButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.drawButton = new System.Windows.Forms.Button();
            this.cameraYOffsetTextslider = new Fractals.TextSlider();
            this.cameraXOffsetTextslider = new Fractals.TextSlider();
            this.scaleTextslider = new Fractals.TextSlider();
            this.recursionTextslider = new Fractals.TextSlider();
            this.autoRedrawCheckbox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.FractalPaint);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panel1);
            this.splitContainer.Size = new System.Drawing.Size(879, 500);
            this.splitContainer.SplitterDistance = 500;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 0;
            this.splitContainer.Text = "splitContainer";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gradientColorBButton);
            this.panel1.Controls.Add(this.gradientColorAButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.resetButton);
            this.panel1.Controls.Add(this.drawButton);
            this.panel1.Controls.Add(this.cameraYOffsetTextslider);
            this.panel1.Controls.Add(this.cameraXOffsetTextslider);
            this.panel1.Controls.Add(this.scaleTextslider);
            this.panel1.Controls.Add(this.recursionTextslider);
            this.panel1.Controls.Add(this.autoRedrawCheckbox);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 331);
            this.panel1.TabIndex = 0;
            // 
            // gradientColorBButton
            // 
            this.gradientColorBButton.Location = new System.Drawing.Point(190, 260);
            this.gradientColorBButton.Name = "gradientColorBButton";
            this.gradientColorBButton.Size = new System.Drawing.Size(178, 29);
            this.gradientColorBButton.TabIndex = 5;
            this.gradientColorBButton.Text = "Choose gradient color B";
            this.gradientColorBButton.UseVisualStyleBackColor = true;
            this.gradientColorBButton.Click += new System.EventHandler(this.ChooseGradientColorButtonClick);
            // 
            // gradientColorAButton
            // 
            this.gradientColorAButton.Location = new System.Drawing.Point(0, 260);
            this.gradientColorAButton.Name = "gradientColorAButton";
            this.gradientColorAButton.Size = new System.Drawing.Size(178, 29);
            this.gradientColorAButton.TabIndex = 5;
            this.gradientColorAButton.Text = "Choose gradient color A";
            this.gradientColorAButton.UseVisualStyleBackColor = true;
            this.gradientColorAButton.Click += new System.EventHandler(this.ChooseGradientColorButtonClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(260, 294);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 29);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(137, 294);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(94, 29);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButtonClick);
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(13, 294);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(94, 29);
            this.drawButton.TabIndex = 4;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.DrawButtonClick);
            // 
            // cameraYOffsetTextslider
            // 
            this.cameraYOffsetTextslider.AutoSize = true;
            this.cameraYOffsetTextslider.Label = "camera y offset:";
            this.cameraYOffsetTextslider.Location = new System.Drawing.Point(0, 203);
            this.cameraYOffsetTextslider.Name = "cameraYOffsetTextslider";
            this.cameraYOffsetTextslider.RoundValue = false;
            this.cameraYOffsetTextslider.Size = new System.Drawing.Size(358, 59);
            this.cameraYOffsetTextslider.SliderLowerBound = -5F;
            this.cameraYOffsetTextslider.SliderUpperBound = 5F;
            this.cameraYOffsetTextslider.TabIndex = 3;
            this.cameraYOffsetTextslider.Value = 0F;
            this.cameraYOffsetTextslider.ValueLowerBound = -10000F;
            this.cameraYOffsetTextslider.ValueLowerBoundIncluded = true;
            this.cameraYOffsetTextslider.ValueUpperBound = 10000F;
            this.cameraYOffsetTextslider.ValueUpperBoundIncluded = true;
            this.cameraYOffsetTextslider.OnChange += new System.EventHandler(this.ValuesUpdate);
            // 
            // cameraXOffsetTextslider
            // 
            this.cameraXOffsetTextslider.AutoSize = true;
            this.cameraXOffsetTextslider.Label = "camera x offset:";
            this.cameraXOffsetTextslider.Location = new System.Drawing.Point(0, 147);
            this.cameraXOffsetTextslider.Name = "cameraXOffsetTextslider";
            this.cameraXOffsetTextslider.RoundValue = false;
            this.cameraXOffsetTextslider.Size = new System.Drawing.Size(358, 59);
            this.cameraXOffsetTextslider.SliderLowerBound = -5F;
            this.cameraXOffsetTextslider.SliderUpperBound = 5F;
            this.cameraXOffsetTextslider.TabIndex = 3;
            this.cameraXOffsetTextslider.Value = 0F;
            this.cameraXOffsetTextslider.ValueLowerBound = -10000F;
            this.cameraXOffsetTextslider.ValueLowerBoundIncluded = true;
            this.cameraXOffsetTextslider.ValueUpperBound = 10000F;
            this.cameraXOffsetTextslider.ValueUpperBoundIncluded = true;
            this.cameraXOffsetTextslider.OnChange += new System.EventHandler(this.ValuesUpdate);
            // 
            // scaleTextslider
            // 
            this.scaleTextslider.AutoSize = true;
            this.scaleTextslider.Label = "scale:";
            this.scaleTextslider.Location = new System.Drawing.Point(0, 91);
            this.scaleTextslider.Name = "scaleTextslider";
            this.scaleTextslider.RoundValue = false;
            this.scaleTextslider.Size = new System.Drawing.Size(358, 59);
            this.scaleTextslider.SliderLowerBound = 0.5F;
            this.scaleTextslider.SliderUpperBound = 10F;
            this.scaleTextslider.TabIndex = 3;
            this.scaleTextslider.Value = 1F;
            this.scaleTextslider.ValueLowerBound = -10000F;
            this.scaleTextslider.ValueLowerBoundIncluded = true;
            this.scaleTextslider.ValueUpperBound = 10000F;
            this.scaleTextslider.ValueUpperBoundIncluded = true;
            this.scaleTextslider.OnChange += new System.EventHandler(this.ValuesUpdate);
            // 
            // recursionTextslider
            // 
            this.recursionTextslider.AutoSize = true;
            this.recursionTextslider.Label = "recursion level:";
            this.recursionTextslider.Location = new System.Drawing.Point(0, 35);
            this.recursionTextslider.Name = "recursionTextslider";
            this.recursionTextslider.RoundValue = true;
            this.recursionTextslider.Size = new System.Drawing.Size(358, 59);
            this.recursionTextslider.SliderLowerBound = 1F;
            this.recursionTextslider.SliderUpperBound = 20F;
            this.recursionTextslider.TabIndex = 2;
            this.recursionTextslider.Value = 10F;
            this.recursionTextslider.ValueLowerBound = 1F;
            this.recursionTextslider.ValueLowerBoundIncluded = true;
            this.recursionTextslider.ValueUpperBound = 50F;
            this.recursionTextslider.ValueUpperBoundIncluded = true;
            this.recursionTextslider.OnChange += new System.EventHandler(this.ValuesUpdate);
            // 
            // autoRedrawCheckbox
            // 
            this.autoRedrawCheckbox.AutoSize = true;
            this.autoRedrawCheckbox.Location = new System.Drawing.Point(247, 2);
            this.autoRedrawCheckbox.Name = "autoRedrawCheckbox";
            this.autoRedrawCheckbox.Size = new System.Drawing.Size(111, 24);
            this.autoRedrawCheckbox.TabIndex = 1;
            this.autoRedrawCheckbox.Text = "auto redraw";
            this.autoRedrawCheckbox.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 500);
            this.Controls.Add(this.splitContainer);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fractals";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panel1;
        private TextSlider recursionTextslider;
        private System.Windows.Forms.CheckBox autoRedrawCheckbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private TextSlider scaleTextslider;
        private TextSlider cameraXOffsetTextslider;
        private TextSlider cameraYOffsetTextslider;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button gradientColorAButton;
        private System.Windows.Forms.Button gradientColorBButton;
    }
}

