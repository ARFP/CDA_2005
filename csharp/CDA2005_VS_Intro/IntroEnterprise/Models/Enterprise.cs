using System;
using System.Collections.Generic;
using System.Text;

namespace IntroEnterprise.Models
{
    class Enterprise
    {
        private string name;

        private List<Person> employees;

        public List<Person> Employees 
        { 
            get => employees; 
            // set => employees = value; 
        }


        public Enterprise(string _name)
        {
            name = _name;

            employees = new List<Person>();

        }

        public void CreateEmployee(Employee emp)
        {
            employees.Add(emp);
        }
    }
}
