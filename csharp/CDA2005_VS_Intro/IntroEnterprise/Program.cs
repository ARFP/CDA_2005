using IntroEnterprise.Models;
using System;
using System.Collections.Generic;

namespace IntroEnterprise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Enterprise ets = new Enterprise("CRM");

            Employee emp = new Employee("Doe", "John");

            ets.CreateEmployee(emp);

            List<Person> l = ets.Employees;

            int i;
            for(i = 0; i < ets.Employees.Count; i++)
            {

            }

            foreach(Employee item in ets.Employees) 
            {
                Console.WriteLine(item);
            }

            //ets.Employees = new List<Person>();
            
        }
    }
}
