using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Faker.Mono.UnitTest
{
    [TestClass]
    public class CompanyTests
    {
        [TestMethod]
        public void TestBS()
        {
            string companyname = Company.GetBS();

            Assert.IsTrue(Regex.IsMatch(companyname, @"[ a-z]+"));
            Assert.IsTrue(Regex.IsMatch(companyname, @"\s"));
        }

        [TestMethod]
        public void TestName()
        {
            string comname = Company.GetName();

            Assert.IsTrue(Regex.IsMatch(comname, @"[a-z]+"));
        }

        [TestMethod]
        public void TestList()
        {

            List<string> list = new List<string>();
            string names = "";
            for (int i = 0; i < 10; i++)
            {
                string c = Company.GetName();
                if(c != null)
                {
                    list.Add(c);
                    names += c+" | ";
                }
            }

            Assert.IsNotNull(list);
        }
    }
}
