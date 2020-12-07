namespace Fractals
{
    partial class TextSlider
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._label = new System.Windows.Forms.Label();
            this._trackBar = new System.Windows.Forms.TrackBar();
            this._textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // _label
            // 
            this._label.AutoSize = true;
            this._label.Location = new System.Drawing.Point(2, 18);
            this._label.Name = "_label";
            this._label.Size = new System.Drawing.Size(42, 20);
            this._label.TabIndex = 0;
            this._label.Text = "label";
            // 
            // _trackBar
            // 
            this._trackBar.LargeChange = 1;
            this._trackBar.Location = new System.Drawing.Point(112, 0);
            this._trackBar.Maximum = 1000;
            this._trackBar.Name = "_trackBar";
            this._trackBar.Size = new System.Drawing.Size(150, 56);
            this._trackBar.TabIndex = 1;
            this._trackBar.Scroll += new System.EventHandler(this.TrackbarScroll);
            // 
            // _textBox
            // 
            this._textBox.Location = new System.Drawing.Point(272, 15);
            this._textBox.Name = "_textBox";
            this._textBox.Size = new System.Drawing.Size(83, 27);
            this._textBox.TabIndex = 2;
            this._textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextboxKeypress);
            this._textBox.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // TextSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this._textBox);
            this.Controls.Add(this._trackBar);
            this.Controls.Add(this._label);
            this.Name = "TextSlider";
            this.Size = new System.Drawing.Size(361, 56);
            ((System.ComponentModel.ISupportInitialize)(this._trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _label;
        private System.Windows.Forms.TrackBar _trackBar;
        private System.Windows.Forms.TextBox _textBox;
    }
}
