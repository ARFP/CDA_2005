using System;
using System.Collections.Generic;
using System.Text;

namespace IntroEnterprise.Models
{
    abstract public class Person
    {

        protected string lastname;

        protected string firstname;

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
