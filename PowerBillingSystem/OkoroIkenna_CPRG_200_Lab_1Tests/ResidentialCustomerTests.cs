using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData.Tests
{
    [TestClass()]
    public class ResidentialCustomerTests
    {
        [TestMethod()]
        public void ResidentialCustomerTestCheckForValidArguments()
        {
            //Arrange
            int number = 1234;
            string name = "Kingsley";
            string type = "R";
            ResidentialCustomer c = new ResidentialCustomer(number, name, type);
            decimal khwused = 30M;
            decimal expectedChargeAmount = 6M + (0.052M * khwused);
            //act
            decimal returnedChargeAmount = c.CalculateCharge(khwused);
            //Assert
            Assert.AreEqual(expectedChargeAmount, returnedChargeAmount);
        }

        

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ResidentialCustomerTestCheckForInvalidArguments2()
        {
            //Arrange
            int number = 1234;
            string name = "Kingsley";
            string type = "R";
            ResidentialCustomer c = new ResidentialCustomer(number, name, type);
            decimal khwused = -30M;
            decimal expectedChargeAmount = 6M + (0.052M * khwused);
            //act
            decimal returnedChargeAmount = c.CalculateCharge(khwused);
            //Assert
            Assert.Fail();
        }
    }
}