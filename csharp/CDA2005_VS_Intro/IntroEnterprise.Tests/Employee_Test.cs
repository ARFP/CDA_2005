using IntroEnterprise.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntroEnterprise.Tests
{
    [TestClass]
    public class Employee_Test
    {
        [TestMethod]
        public void Test_1()
        {
            Employee emp = new Employee("A", "B");

            Assert.AreEqual("A B", emp.GetInfo());

            Employee emp2 = new Employee("AA", "BB");

            Assert.AreEqual("AA BB", emp2.GetInfo(), "getinfo BUG !!!");
        }

        [TestMethod]
        public void Test_2()
        {

        }



    }
}
