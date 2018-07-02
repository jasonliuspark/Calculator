using System;

namespace Calculator
{
    partial class CalculatorFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorFrom));
            this.FirstNum = new System.Windows.Forms.TextBox();
            this.SecNum = new System.Windows.Forms.TextBox();
            this.EQLable = new System.Windows.Forms.Label();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.OperatorSelectionBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // FirstNum
            // 
            resources.ApplyResources(this.FirstNum, "FirstNum");
            this.FirstNum.Name = "FirstNum";
            // 
            // SecNum
            // 
            resources.ApplyResources(this.SecNum, "SecNum");
            this.SecNum.Name = "SecNum";
            // 
            // EQLable
            // 
            resources.ApplyResources(this.EQLable, "EQLable");
            this.EQLable.Name = "EQLable";
            // 
            // ResultText
            // 
            resources.ApplyResources(this.ResultText, "ResultText");
            this.ResultText.Name = "ResultText";
            this.ResultText.ReadOnly = true;
            // 
            // calculateButton
            // 
            resources.ApplyResources(this.calculateButton, "calculateButton");
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // OperatorSelectionBox
            // 
            this.OperatorSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperatorSelectionBox.FormattingEnabled = true;
            resources.ApplyResources(this.OperatorSelectionBox, "OperatorSelectionBox");
            this.OperatorSelectionBox.Name = "OperatorSelectionBox";
            // 
            // CalculatorFrom
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OperatorSelectionBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.EQLable);
            this.Controls.Add(this.SecNum);
            this.Controls.Add(this.FirstNum);
            this.HandleCreated+=new EventHandler(this.CalculatorFrom_HandleCreated);
            this.HandleDestroyed+=new EventHandler(this.CalculatorFrom_HandleDestroyed);
            this.Name = "CalculatorFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNum;
        private System.Windows.Forms.TextBox SecNum;
        private System.Windows.Forms.Label EQLable;
        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ComboBox OperatorSelectionBox;
    }
}

