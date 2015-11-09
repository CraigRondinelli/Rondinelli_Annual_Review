using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rondinelli_Annual_Review
{
    public partial class AddEmployeeForm : Form
    {

        //Set up the variables to connect to the database
        private string connectionString; //Connectionstring to the db
        private string insertStatement;  //Query I used to pull info from the db
        private SqlConnection connection; //Connection the to db
        private SqlCommand command; //Tell the database what to do with SQL statements

        EmployeeInfo newEmployee = new EmployeeInfo();

        private void getEmployeeInfo()
        {
            newEmployee.EmployeeID = employeeIDTextBox.Text;
            newEmployee.LastName = lastNameTextBox.Text;
            newEmployee.FirstName = firstNameTextBox.Text;
            newEmployee.Gender = genderTextBox.Text;
            newEmployee.Title = titleIDTextBox.Text;
            newEmployee.Salary = Convert.ToInt32(salaryTextBox.Text);
            newEmployee.LocationID = locationIDTextBox.Text;
            
        }

        public AddEmployeeForm()
        {
            InitializeComponent();
            connectionString = "Data Source=CRAIG-PC\\CIS330;Initial Catalog=Insurance Company;Integrated Security=True";//Connecttion string from App.config to properly link the database to the app
            insertStatement = "INSERT INTO Employees" +
                         "(EmployeeID, LastName, FirstName, Gender, TitleID, Salary, LocationID, Performance, HireDate)" + //What records information are being pulled from
                         "VALUES (@empID,@lName,@fName,@gender,@titleID,@salary,@locationID,@performance,@hireDate)";
            connection = new SqlConnection(connectionString);//Connects the database
            command = new SqlCommand(insertStatement, connection);//Commands to run on the database
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.insurance_CompanyDataSet);

        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {

        }
        //Closes the form so user can access parent form again.
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Opens the connection, adds the given parameters to the database, executes, closes connection, and displays a meessage box if successful.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();

            command.Parameters.AddWithValue("@empID", Convert.ToInt32(employeeIDTextBox.Text));
            command.Parameters.AddWithValue("@lName", lastNameTextBox.Text);
            command.Parameters.AddWithValue("@fName", firstNameTextBox.Text);
            command.Parameters.AddWithValue("@gender", genderTextBox.Text);
            command.Parameters.AddWithValue("@titleID", titleIDTextBox.Text);
            command.Parameters.AddWithValue("@salary", Convert.ToDouble(salaryTextBox.Text));
            command.Parameters.AddWithValue("@locationID", locationIDTextBox.Text);
            command.Parameters.AddWithValue("@performance", performanceTextBox.Text);
            command.Parameters.AddWithValue("@hireDate", Convert.ToDateTime(hireDateDateTimePicker.Text));

            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Employee has been added successfully!");

        }
    }
}
