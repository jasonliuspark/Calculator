namespace Calculator.Presentation.View
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
            this.components = new System.ComponentModel.Container();
            this.ResultBox2 = new System.Windows.Forms.TextBox();
            this._Calculator_Model_CalculationContextDataSet = new Calculator._Calculator_Model_CalculationContextDataSet();
            this.calculationResultModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculationResultModelsTableAdapter = new Calculator._Calculator_Model_CalculationContextDataSetTableAdapters.CalculationResultModelsTableAdapter();
            this.ResultPresentationGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._Calculator_Model_CalculationContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculationResultModelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPresentationGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultBox2
            // 
            this.ResultBox2.Location = new System.Drawing.Point(71, 42);
            this.ResultBox2.Name = "ResultBox2";
            this.ResultBox2.ReadOnly = true;
            this.ResultBox2.Size = new System.Drawing.Size(100, 20);
            this.ResultBox2.TabIndex = 0;
            // 
            // _Calculator_Model_CalculationContextDataSet
            // 
            this._Calculator_Model_CalculationContextDataSet.DataSetName = "_Calculator_Model_CalculationContextDataSet";
            this._Calculator_Model_CalculationContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calculationResultModelsBindingSource
            // 
            this.calculationResultModelsBindingSource.DataMember = "CalculationResultModels";
            this.calculationResultModelsBindingSource.DataSource = this._Calculator_Model_CalculationContextDataSet;
            // 
            // calculationResultModelsTableAdapter
            // 
            this.calculationResultModelsTableAdapter.ClearBeforeFill = true;
            // 
            // ResultPresentationGrid
            // 
            this.ResultPresentationGrid.AllowUserToAddRows = false;
            this.ResultPresentationGrid.AllowUserToDeleteRows = false;
            this.ResultPresentationGrid.AllowUserToResizeColumns = false;
            this.ResultPresentationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultPresentationGrid.Location = new System.Drawing.Point(12, 78);
            this.ResultPresentationGrid.Name = "ResultPresentationGrid";
            this.ResultPresentationGrid.ReadOnly = true;
            this.ResultPresentationGrid.Size = new System.Drawing.Size(528, 268);
            this.ResultPresentationGrid.TabIndex = 1;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 438);
            this.Controls.Add(this.ResultPresentationGrid);
            this.Controls.Add(this.ResultBox2);
            this.Name = "ResultForm";
            this.Text = "ResultForm";           
            this.HandleCreated += new System.EventHandler(this.ResultForm_HandleCreated);
            this.HandleDestroyed += new System.EventHandler(this.ResultForm_HandleDestroyed);
            ((System.ComponentModel.ISupportInitialize)(this._Calculator_Model_CalculationContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculationResultModelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPresentationGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultBox2;
        private _Calculator_Model_CalculationContextDataSet _Calculator_Model_CalculationContextDataSet;
        private System.Windows.Forms.BindingSource calculationResultModelsBindingSource;
        private _Calculator_Model_CalculationContextDataSetTableAdapters.CalculationResultModelsTableAdapter calculationResultModelsTableAdapter;
        private System.Windows.Forms.DataGridView ResultPresentationGrid;
    }
}