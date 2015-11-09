namespace Rondinelli_Annual_Review
{
    partial class CalculateBonus
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.newSalaryAndBonusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.newSalaryAndBonusBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.newBonusDisplay = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Performance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurance_CompanyDataSet = new Rondinelli_Annual_Review.Insurance_CompanyDataSet();
            this.newSalaryAndBonusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newSalaryAndBonusTableAdapter = new Rondinelli_Annual_Review.Insurance_CompanyDataSetTableAdapters.NewSalaryAndBonusTableAdapter();
            this.tableAdapterManager = new Rondinelli_Annual_Review.Insurance_CompanyDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.newSalaryAndBonusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSalaryAndBonusBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBonusDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurance_CompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSalaryAndBonusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(32, 256);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(173, 57);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate Bonus";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(254, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 57);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save Bonus";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(481, 256);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(173, 57);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // newSalaryAndBonusBindingSource1
            // 
            this.newSalaryAndBonusBindingSource1.DataMember = "NewSalaryAndBonus";
            // 
            // newSalaryAndBonusBindingSource2
            // 
            this.newSalaryAndBonusBindingSource2.DataMember = "NewSalaryAndBonus";
            // 
            // newBonusDisplay
            // 
            this.newBonusDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newBonusDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.Performance,
            this.Bonus});
            this.newBonusDisplay.Location = new System.Drawing.Point(112, 49);
            this.newBonusDisplay.Name = "newBonusDisplay";
            this.newBonusDisplay.Size = new System.Drawing.Size(443, 150);
            this.newBonusDisplay.TabIndex = 3;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // Performance
            // 
            this.Performance.HeaderText = "Performance";
            this.Performance.Name = "Performance";
            // 
            // Bonus
            // 
            this.Bonus.HeaderText = "Bonus";
            this.Bonus.Name = "Bonus";
            // 
            // insurance_CompanyDataSet
            // 
            this.insurance_CompanyDataSet.DataSetName = "Insurance_CompanyDataSet";
            this.insurance_CompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newSalaryAndBonusBindingSource
            // 
            this.newSalaryAndBonusBindingSource.DataMember = "NewSalaryAndBonus";
            this.newSalaryAndBonusBindingSource.DataSource = this.insurance_CompanyDataSet;
            // 
            // newSalaryAndBonusTableAdapter
            // 
            this.newSalaryAndBonusTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.LocationTableAdapter = null;
            this.tableAdapterManager.NewSalaryAndBonusTableAdapter = this.newSalaryAndBonusTableAdapter;
            this.tableAdapterManager.TitlesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Rondinelli_Annual_Review.Insurance_CompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // CalculateBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 336);
            this.Controls.Add(this.newBonusDisplay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCalc);
            this.Name = "CalculateBonus";
            this.Text = "CalculateBonus";
            this.Load += new System.EventHandler(this.CalculateBonus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newSalaryAndBonusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSalaryAndBonusBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBonusDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurance_CompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSalaryAndBonusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private Insurance_CompanyDataSet insurance_CompanyDataSet;
        private System.Windows.Forms.BindingSource newSalaryAndBonusBindingSource;
        private Insurance_CompanyDataSetTableAdapters.NewSalaryAndBonusTableAdapter newSalaryAndBonusTableAdapter;
        private Insurance_CompanyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
       // private Insurance_CompanyDataSet1 insurance_CompanyDataSet1;
        private System.Windows.Forms.BindingSource newSalaryAndBonusBindingSource1;
        //private Insurance_CompanyDataSet1TableAdapters.NewSalaryAndBonusTableAdapter newSalaryAndBonusTableAdapter1;
        //private Insurance_CompanyDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        //private Insurance_CompanyDataSet2 insurance_CompanyDataSet2;
        private System.Windows.Forms.BindingSource newSalaryAndBonusBindingSource2;
        //private Insurance_CompanyDataSet2TableAdapters.NewSalaryAndBonusTableAdapter newSalaryAndBonusTableAdapter2;
        //private Insurance_CompanyDataSet2TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView newBonusDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Performance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonus;
    }
}