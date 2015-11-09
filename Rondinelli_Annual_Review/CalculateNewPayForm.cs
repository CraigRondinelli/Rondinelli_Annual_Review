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
    public partial class CalculateNewPayForm : Form
    {
        //Set up the variables to connect to the database
        private string connectionString; //Connection string for the database
        private string selectStatement;  //Query used to pull information from database
        private SqlConnection connection; //Connects to the database
        private SqlCommand command; //Tells the database how to handle SQL statements
        private List<EmployeeInfo> employees; //List of employees to display in datagrid

        public CalculateNewPayForm()
        {
            InitializeComponent();
            employees = new List<EmployeeInfo>(); //Instansiates a new employee list
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes this form
        }

        private void CalculateNewPayForm_Load(object sender, EventArgs e)
        {
            connectionString = "Data Source=CRAIG-PC\\CIS330;Initial Catalog=Insurance Company;Integrated Security=True"; //Connecttion string from App.config to properly link the database to the app
            selectStatement = "SELECT Employees.LastName, Employees.FirstName, Employees.TitleID, Employees.Salary, Titles.[2016Increase] " +
                  "FROM Employees INNER JOIN " +                                                                                             //What records information are being pulled from
                  "Titles ON Employees.TitleID = Titles.TitleID";
            connection = new SqlConnection(connectionString); //Connects the database
            command = new SqlCommand(selectStatement, connection); //Commands to run on the database
        }

        private void displayEmployeeData()
        {
            foreach(EmployeeInfo anEmployee in employees)
            {
                newSalaryGrid.Rows.Add(anEmployee.FirstName, anEmployee.LastName, anEmployee.Salary, anEmployee.NewSalary); //Displays employee info in the datagrid. Adds because it is not connected, so it must create them as new employees come in
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            connection.Open(); //Opens connection to database when button is clicked
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

            while (reader.Read()) //While employees are available to be added, the reader continues
            {
                EmployeeInfo tempEmpl = new EmployeeInfo(); //Instansiates a new employee to add information to from the created class

                tempEmpl.LastName = reader["LastName"].ToString();
                tempEmpl.FirstName = reader["FirstName"].ToString();
                tempEmpl.Salary = Convert.ToDouble(reader["Salary"].ToString());                   //Pulls last name, first name, salary, percent of salary increase, and performs the calculations.
                double percentInc = Convert.ToDouble(reader["2016Increase"].ToString());
                tempEmpl.calcNewSalary(percentInc);

                employees.Add(tempEmpl);
            }

            connection.Close(); //Closes connection to database
            displayEmployeeData(); //Call to method to add the information to the datagrid view.
        }
        //Updates the new calculated salaries.
        private void btnSave_Click(object sender, EventArgs e)
        {
            String insertStatement = "INSERT INTO Employees " +
                                     "(NewSalary, Title) VALUES (@newSalary, @title)";
            insertStatement = "UPDATE EMPLOYEES SET NewSalary=@newSalary " +
                              "WHERE Title=@title";
            connection.Open();

            foreach (EmployeeInfo tempEmpl in employees)
            {
                SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
                insertCommand.Parameters.AddWithValue("@newSalary", tempEmpl.NewSalary);
                insertCommand.Parameters.AddWithValue("@title", tempEmpl.Title);
            }

            connection.Close();
            MessageBox.Show("Salaries Updated!");

        }
    }
}
