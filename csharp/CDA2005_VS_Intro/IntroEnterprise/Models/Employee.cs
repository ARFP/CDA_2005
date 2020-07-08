using System;
using System.Collections.Generic;
using System.Text;

namespace IntroEnterprise.Models
{
    class Employee : Person 
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
            throw new NotImplementedException();
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
