namespace Rondinelli_Annual_Review
{
    partial class AnnualReviewApp
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
            this.btnDisplayEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnCalcNewPay = new System.Windows.Forms.Button();
            this.btnCalcBonus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisplayEmployee
            // 
            this.btnDisplayEmployee.Location = new System.Drawing.Point(50, 63);
            this.btnDisplayEmployee.Name = "btnDisplayEmployee";
            this.btnDisplayEmployee.Size = new System.Drawing.Size(167, 63);
            this.btnDisplayEmployee.TabIndex = 0;
            this.btnDisplayEmployee.Text = "Display Employee Info...";
            this.btnDisplayEmployee.UseVisualStyleBackColor = true;
            this.btnDisplayEmployee.Click += new System.EventHandler(this.btnDisplayEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(50, 157);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(167, 63);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Add Employee...";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnCalcNewPay
            // 
            this.btnCalcNewPay.Location = new System.Drawing.Point(50, 250);
            this.btnCalcNewPay.Name = "btnCalcNewPay";
            this.btnCalcNewPay.Size = new System.Drawing.Size(167, 63);
            this.btnCalcNewPay.TabIndex = 2;
            this.btnCalcNewPay.Text = "Calculate New Pay...";
            this.btnCalcNewPay.UseVisualStyleBackColor = true;
            this.btnCalcNewPay.Click += new System.EventHandler(this.btnCalcNewPay_Click);
            // 
            // btnCalcBonus
            // 
            this.btnCalcBonus.Location = new System.Drawing.Point(50, 349);
            this.btnCalcBonus.Name = "btnCalcBonus";
            this.btnCalcBonus.Size = new System.Drawing.Size(167, 63);
            this.btnCalcBonus.TabIndex = 3;
            this.btnCalcBonus.Text = "Calculate Bonus...";
            this.btnCalcBonus.UseVisualStyleBackColor = true;
            this.btnCalcBonus.Click += new System.EventHandler(this.btnCalcBonus_Click);
            // 
            // AnnualReviewApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 510);
            this.Controls.Add(this.btnCalcBonus);
            this.Controls.Add(this.btnCalcNewPay);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnDisplayEmployee);
            this.Name = "AnnualReviewApp";
            this.Text = "Rondinelli Annual Review";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnCalcNewPay;
        private System.Windows.Forms.Button btnCalcBonus;
    }
}

