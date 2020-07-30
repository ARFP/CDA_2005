using System;
using System.Collections.Generic;
using System.Text;

namespace IntroEnterprise.Models
{
    public class Employee : Person, ISalary, IStockage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_lastname"></param>
        /// <param name="_firstname"></param>
        public Employee(string _lastname, string _firstname) : base(_lastname, _firstname)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            return lastname + " " + firstname;
        }

        public int GetMonthlySalary()
        {
            return 0;
        }

        public bool Save()
        {
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "idclient " + base.ToString();
        }



    }
}
