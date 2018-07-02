using System;

namespace Calculator.View
{
    partial class ResultForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResultBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ResultBox2
            // 
            this.ResultBox2.Location = new System.Drawing.Point(97, 103);
            this.ResultBox2.Name = "ResultBox2";
            this.ResultBox2.ReadOnly = true;
            this.ResultBox2.Size = new System.Drawing.Size(100, 20);
            this.ResultBox2.TabIndex = 0;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ResultBox2);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.HandleCreated+= new EventHandler(this.ResultForm_HandleCreated);
            this.HandleDestroyed+= new EventHandler(this.ResultForm_HandleDestroyed);

        }

        #endregion

        private System.Windows.Forms.TextBox ResultBox2;
    }
}