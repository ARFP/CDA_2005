using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntroEnterprise.Models;
using System.Collections.Generic;

namespace IntroEnterprise.Tests
{
    [TestClass]
    public class Enterprise_Test
    {

        private Enterprise ets;

        [TestMethod]
        public void Test_Name()
        {
            ets = new Enterprise("CRM");

            Assert.IsNotNull(ets.Employees);
            Assert.AreEqual(0, ets.Employees.Count);

            ets.Employees.Add(new Employee("A", "B"));

            Assert.AreEqual(1, ets.Employees.Count);

            Person emp = ets.Employees[0];

            Assert.IsNotNull(emp);

            Employee realEmp = emp as Employee;

            Assert.IsNotNull(realEmp);
        }
    }
}
