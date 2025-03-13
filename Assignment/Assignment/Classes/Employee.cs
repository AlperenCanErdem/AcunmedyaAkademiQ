using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Classes
{
    class Employee
    {
        public string Name;
        public string Surname;
        public string Job;
        public double Salary;
        public string Department;

        public void Features(string Name, string Surname, string Job, string Deparment, double Salary )
        {
            Console.WriteLine(Name + " " + Surname + " " + Job + " " + Department + " " + Salary + "£" );
        }   

    }
}
