using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IntroEnterprise.Models
{
    public class Enterprise
    {
        private string name;

        private List<Person> employees;

        public event PropertyChangedEventHandler PropertyChanged;


        public List<Person> Employees 
        { 
            get => employees; 
            protected set => employees = value; 
        }

        public string Name
        {
            get { return name; }
            set 
            { 
                name = value;
                OnPropertyChanged("Name");
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
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

        public int CalculerPrime(ISalary emp)
        {
            //Employee p = (Employee)emp;

            return 0;

        }
    }
}
