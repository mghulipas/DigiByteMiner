﻿namespace DigibyteMiner.View.v1.Controls
{
    partial class SliderEx
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
            this.lblValue = new System.Windows.Forms.Label();
            this.pbcaret = new System.Windows.Forms.PictureBox();
            this.pbLine = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbcaret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLine)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(6, 17);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(22, 13);
            this.lblValue.TabIndex = 3;
            this.lblValue.Text = "NA";
            // 
            // pbcaret
            // 
            this.pbcaret.BackColor = System.Drawing.Color.Transparent;
            this.pbcaret.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbcaret.Image = global::DigibyteMiner.Properties.Resources.slider1;
            this.pbcaret.Location = new System.Drawing.Point(150, 142);
            this.pbcaret.Name = "pbcaret";
            this.pbcaret.Size = new System.Drawing.Size(52, 50);
            this.pbcaret.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbcaret.TabIndex = 2;
            this.pbcaret.TabStop = false;
            // 
            // pbLine
            // 
            this.pbLine.BackColor = System.Drawing.Color.Black;
            this.pbLine.Location = new System.Drawing.Point(34, 23);
            this.pbLine.Name = "pbLine";
            this.pbLine.Size = new System.Drawing.Size(100, 4);
            this.pbLine.TabIndex = 1;
            this.pbLine.TabStop = false;
            this.pbLine.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SliderEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.pbcaret);
            this.Controls.Add(this.pbLine);
            this.Name = "SliderEx";
            this.Size = new System.Drawing.Size(442, 172);
            this.Load += new System.EventHandler(this.SliderEx_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbcaret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLine;
        private System.Windows.Forms.PictureBox pbcaret;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Button button1;
    }
}
