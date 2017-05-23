using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

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
            Assert.IsTrue(Regex.IsMatch(Company.GetBS(), @"\s"));
        }
    }
}
