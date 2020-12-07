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
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.drawButton = new System.Windows.Forms.Button();
            this.textSlider4 = new Fractals.TextSlider();
            this.textSlider3 = new Fractals.TextSlider();
            this.textSlider2 = new Fractals.TextSlider();
            this.textSlider1 = new Fractals.TextSlider();
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
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.drawButton);
            this.panel1.Controls.Add(this.textSlider4);
            this.panel1.Controls.Add(this.textSlider3);
            this.panel1.Controls.Add(this.textSlider2);
            this.panel1.Controls.Add(this.textSlider1);
            this.panel1.Controls.Add(this.autoRedrawCheckbox);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 309);
            this.panel1.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(260, 268);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 29);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(137, 268);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 29);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(13, 268);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(94, 29);
            this.drawButton.TabIndex = 4;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            // 
            // textSlider4
            // 
            this.textSlider4.AutoSize = true;
            this.textSlider4.Label = "scale:";
            this.textSlider4.Location = new System.Drawing.Point(0, 203);
            this.textSlider4.Name = "textSlider4";
            this.textSlider4.RoundValue = false;
            this.textSlider4.Size = new System.Drawing.Size(358, 59);
            this.textSlider4.SliderLowerBound = 0.5F;
            this.textSlider4.SliderUpperBound = 10F;
            this.textSlider4.TabIndex = 3;
            this.textSlider4.Value = 1F;
            // 
            // textSlider3
            // 
            this.textSlider3.AutoSize = true;
            this.textSlider3.Label = "scale:";
            this.textSlider3.Location = new System.Drawing.Point(0, 147);
            this.textSlider3.Name = "textSlider3";
            this.textSlider3.RoundValue = false;
            this.textSlider3.Size = new System.Drawing.Size(358, 59);
            this.textSlider3.SliderLowerBound = 0.5F;
            this.textSlider3.SliderUpperBound = 10F;
            this.textSlider3.TabIndex = 3;
            this.textSlider3.Value = 1F;
            // 
            // textSlider2
            // 
            this.textSlider2.AutoSize = true;
            this.textSlider2.Label = "scale:";
            this.textSlider2.Location = new System.Drawing.Point(0, 91);
            this.textSlider2.Name = "textSlider2";
            this.textSlider2.RoundValue = false;
            this.textSlider2.Size = new System.Drawing.Size(358, 59);
            this.textSlider2.SliderLowerBound = 0.5F;
            this.textSlider2.SliderUpperBound = 10F;
            this.textSlider2.TabIndex = 3;
            this.textSlider2.Value = 1F;
            // 
            // textSlider1
            // 
            this.textSlider1.AutoSize = true;
            this.textSlider1.Label = "recursion level:";
            this.textSlider1.Location = new System.Drawing.Point(0, 35);
            this.textSlider1.Name = "textSlider1";
            this.textSlider1.RoundValue = true;
            this.textSlider1.Size = new System.Drawing.Size(358, 59);
            this.textSlider1.SliderLowerBound = 1F;
            this.textSlider1.SliderUpperBound = 20F;
            this.textSlider1.TabIndex = 2;
            this.textSlider1.Value = 10F;
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
        private TextSlider textSlider1;
        private System.Windows.Forms.CheckBox autoRedrawCheckbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private TextSlider textSlider2;
        private TextSlider textSlider3;
        private TextSlider textSlider4;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
    }
}

