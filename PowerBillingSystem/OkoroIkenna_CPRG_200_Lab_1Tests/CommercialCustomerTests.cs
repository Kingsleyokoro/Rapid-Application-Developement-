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
    public class CommercialCustomerTests
    {
        [TestMethod()]
        public void CommercialCustomerTestForValidArguements()
        {
            //Arrange
            int number = 1234;
            string name = "Kingsley";
            string type = "R";
            CommercialCustomer c = new CommercialCustomer(number, name, type);
            decimal khwused = 30M;
            //since input kwh hours used is less than 1000. expected charge amount 
            //should be equal to the Flat rate
            decimal flatRate = 60M; 
            //act
            decimal returnedChargeAmount = c.CalculateCharge(khwused);
            //Assert
            Assert.AreEqual(flatRate, returnedChargeAmount);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CommercialCustomerTestForInvalidArguments()
        {
            //Arrange
            int number = 1234;
            string name = "Kingsley";
            string type = "R";
            CommercialCustomer c = new CommercialCustomer(number, name, type);
            decimal khwused = -30M;
           
            //act
            decimal billAmount = c.CalculateCharge(khwused);
            //Assert
            Assert.Fail();
        }
    }
}