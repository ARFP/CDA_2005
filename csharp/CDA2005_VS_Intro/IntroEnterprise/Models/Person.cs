using System;
using System.Collections.Generic;
using System.Text;

namespace IntroEnterprise.Models
{
    abstract class Person
    {

        private string lastname;

        private string firstname;

        abstract public string GetInfo();


        public Person(string _lastname, string _firstname)
        {
            lastname = _lastname;
            firstname = _firstname;
        }


        public override string ToString()
        {
            return lastname + " " + firstname;
        }

    }
}
