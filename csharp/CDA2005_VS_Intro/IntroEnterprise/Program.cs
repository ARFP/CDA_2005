using IntroEnterprise.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace IntroEnterprise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Enterprise ets = new Enterprise("CRM");

            ets.PropertyChanged += MyEvent;

            ets.PropertyChanged += MyEvent2;

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

            ets.Name = "Joe";
            ets.Name = "Ho";
            ets.Name = "a";

            ets.PropertyChanged -= MyEvent2;

            ets.Name = "b";
            ets.Name = "s";
            ets.Name = "q";

            

        }

        static void MyEvent(object sender, PropertyChangedEventArgs e)
        {
            Enterprise ets = sender as Enterprise;

            if (ets == null)
            {
                return;
            }

            // Database.save(new values);

            Console.WriteLine("Le nom de l'entreprise a changé : " + ets.Name);

        }

        static void MyEvent2(object sender, EventArgs e)
        {
            Enterprise ets = sender as Enterprise;

            if (ets == null)
            {
                return;
            }

            // Database.save(new values);

            Console.WriteLine("SUPER !");
        }
    }
}
