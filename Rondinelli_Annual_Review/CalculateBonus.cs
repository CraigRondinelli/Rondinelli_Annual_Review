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
    public partial class CalculateBonus : Form
    {

        //Set up the variables to connect to the database
        private string connectionString; //Connection string for the database
        private string selectStatement;  //Query used to pull information from database
        private SqlConnection connection; //Connects to the database
        private SqlCommand command; //Tells the database how to handle SQL statements
        private List<EmployeeInfo> employees; //List of employees to display in datagrid

        public CalculateBonus()
        {
            InitializeComponent();

            connectionString = "Data Source=CRAIG-PC\\CIS330;Initial Catalog=Insurance Company;Integrated Security=True"; //Connecttion string from App.config to properly link the database to the app
            selectStatement = "SELECT Employees.LastName, Employees.FirstName, Employees.TitleID, Employees.Performance, Employees.BonusAmt " + //What records information are being pulled from
                  "FROM Employees INNER JOIN " +
                  "Titles ON Employees.TitleID = Titles.TitleID";
            connection = new SqlConnection(connectionString); //Connects the database
            command = new SqlCommand(selectStatement, connection); //Commands to run on the database

            employees = new List<EmployeeInfo>(); //Instansiates a new employee list
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes this form
        }

        //Updates the records with the new bonuses.
        private void btnSave_Click(object sender, EventArgs e)
        {
            String insertStatement = "INSERT INTO Employees " +
                                     "(TitleID, Bonus) VALUES (@title, @bonus)";
            insertStatement = "UPDATE EMPLOYEES SET Bonus = @bonus " +
                              "WHERE Title = @title";
            connection.Open();

            foreach (EmployeeInfo tempEmpl in employees)
            {
                SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
                insertCommand.Parameters.AddWithValue("@title",tempEmpl.Title);
                insertCommand.Parameters.AddWithValue("bonus", tempEmpl.Bonus);
            }

            connection.Close();
            MessageBox.Show("Bonuses Updated!");
        }

        private void displayEmployeeData()
        {
            foreach (EmployeeInfo anEmployee in employees)
            {
                newBonusDisplay.Rows.Add(anEmployee.FirstName, anEmployee.LastName, anEmployee.Performance, anEmployee.Bonus);  //Displays employee info in the datagrid. Adds because it is not connected, so it must create them as new employees come in
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
                tempEmpl.FirstName = reader["FirstName"].ToString();  //Pulls last name, first name, salary, percent of salary increase, and performs the calculations.
                tempEmpl.Performance = reader["Performance"].ToString();
                tempEmpl.calcBonus("Performance");
                employees.Add(tempEmpl);
            }

            connection.Close(); //Closes connection to database
            displayEmployeeData(); //Call to method to add the information to the datagrid view.
        }

        private void newSalaryAndBonusBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.newSalaryAndBonusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.insurance_CompanyDataSet);

        }

        private void CalculateBonus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insurance_CompanyDataSet2.NewSalaryAndBonus' table. You can move, or remove it, as needed.
            //this.newSalaryAndBonusTableAdapter2.Fill(this.insurance_CompanyDataSet2.NewSalaryAndBonus);
            // TODO: This line of code loads data into the 'insurance_CompanyDataSet1.NewSalaryAndBonus' table. You can move, or remove it, as needed.
            //this.newSalaryAndBonusTableAdapter1.Fill(this.insurance_CompanyDataSet1.NewSalaryAndBonus);
            // TODO: This line of code loads data into the 'insurance_CompanyDataSet.NewSalaryAndBonus' table. You can move, or remove it, as needed.
            this.newSalaryAndBonusTableAdapter.Fill(this.insurance_CompanyDataSet.NewSalaryAndBonus);

        }
    }
}
