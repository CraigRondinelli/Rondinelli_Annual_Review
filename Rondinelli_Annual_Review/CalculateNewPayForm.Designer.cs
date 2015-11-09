namespace Rondinelli_Annual_Review
{
    partial class CalculateNewPayForm
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
            this.newSalaryAndBonusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newSalaryGrid = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OldSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.newSalaryAndBonusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSalaryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(16, 267);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(191, 58);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate New Salaries";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(253, 267);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(191, 58);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save New Salary";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(487, 267);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(191, 58);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // newSalaryAndBonusBindingSource
            // 
            this.newSalaryAndBonusBindingSource.DataMember = "NewSalaryAndBonus";
            // 
            // newSalaryGrid
            // 
            this.newSalaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newSalaryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.OldSalary,
            this.NewSalary});
            this.newSalaryGrid.Location = new System.Drawing.Point(108, 57);
            this.newSalaryGrid.Name = "newSalaryGrid";
            this.newSalaryGrid.Size = new System.Drawing.Size(439, 150);
            this.newSalaryGrid.TabIndex = 3;
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
            // OldSalary
            // 
            this.OldSalary.HeaderText = "Old Salary";
            this.OldSalary.Name = "OldSalary";
            // 
            // NewSalary
            // 
            this.NewSalary.HeaderText = "New Salary";
            this.NewSalary.Name = "NewSalary";
            // 
            // CalculateNewPayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 337);
            this.Controls.Add(this.newSalaryGrid);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCalc);
            this.Name = "CalculateNewPayForm";
            this.Text = "CalculateNewPayForm";
            this.Load += new System.EventHandler(this.CalculateNewPayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newSalaryAndBonusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSalaryGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
       // private Insurance_CompanyDataSet3 insurance_CompanyDataSet3;
        private System.Windows.Forms.BindingSource newSalaryAndBonusBindingSource;
        //private Insurance_CompanyDataSet3TableAdapters.NewSalaryAndBonusTableAdapter newSalaryAndBonusTableAdapter;
        //private Insurance_CompanyDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView newSalaryGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OldSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewSalary;
    }
}