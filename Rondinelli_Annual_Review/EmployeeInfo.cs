using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rondinelli_Annual_Review
{
    class EmployeeInfo //Used to store information temporarily in order to populate the datagrids.
    {

        private string employeeID;

        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        private string locationID;

        public string LocationID
        {
            get { return locationID; }
            set { locationID = value; }
        }

        private string performance;

        public string Performance
        {
            get { return performance; }
            set { performance = value; }
        }

        private double newSalary;

        public double NewSalary
        {
            get { return newSalary; }
            set { newSalary = value; }
        }
        //Calculates new salary.
        public void calcNewSalary(double percentIncrease)
        {
            newSalary = salary * percentIncrease + salary;
        }

        private double bonus;

        public double Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }
        //Determines who gets which bonus.
        public void calcBonus(string Performance)
        {
            if (Performance == "Excellent")
            {
                Bonus = 1000;
            }
            else
            {
                Bonus = 300;
            }
        }
    }
}
