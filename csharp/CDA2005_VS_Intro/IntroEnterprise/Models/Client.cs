using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Transactions;

namespace IntroEnterprise.Models
{
    class Client : Person
    {
        private int idClient;

        public Client(string _lastname, string _firstname, int _idClient) : base(_lastname, _firstname)
        {
            idClient = _idClient;
        }

        public override string GetInfo()
        {
            return "";
        }

        public bool IsValid()
        {
            return true;
        }
    }
}
