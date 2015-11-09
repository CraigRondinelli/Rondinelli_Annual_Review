using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rondinelli_Annual_Review
{
    public partial class AnnualReviewApp : Form
    {
        public AnnualReviewApp()
        {
            InitializeComponent();
        }
        //Displays the Employee Info Form and does not allow user to come back to this form until Employee Info Form is closed.
        private void btnDisplayEmployee_Click(object sender, EventArgs e)
        {
            DisplayEmployeeInfo display = new DisplayEmployeeInfo();
            display.ShowDialog();
        }
        //Displays the Add Employee Form and does not allow user to come back to this form until Add Employee Form is closed.
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm display = new AddEmployeeForm();
            display.ShowDialog();
        }
        //Displays the Calculate New Pay Form and does not allow user to come back to this form until Calculate New Pay Form is closed.
        private void btnCalcNewPay_Click(object sender, EventArgs e)
        {
            CalculateNewPayForm display = new CalculateNewPayForm();
            display.ShowDialog();
        }
        //Displays the Calculate Bonus Form and does not allow user to come back to this form until Calculate Bonus Form is closed.
        private void btnCalcBonus_Click(object sender, EventArgs e)
        {
            CalculateBonus display = new CalculateBonus();
            display.ShowDialog();
        }
    }
}
