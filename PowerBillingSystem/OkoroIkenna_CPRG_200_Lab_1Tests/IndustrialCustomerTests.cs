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
    public class IndustrialCustomerTests
    {
        [TestMethod()]
        public void IndustrialCustomerTestCheckForValidArgument()
        {
            //Arrange
            int number = 1234;
            string name = "Kingsley";
            string type = "R";
            IndustrialCustomer c = new IndustrialCustomer(number, name, type);
            decimal peakKhwused = 30M;
            decimal offPeakKwhused = 40;
            //since input kwh hours for both peak and offpeak hours used is less than 1000. expected charge amount 
            //should be equal to the Flat rate
            decimal flatRateforPeak = 76M;
            decimal flatRateforOffPeak = 40M;
            decimal totalFlatRate = flatRateforOffPeak + flatRateforPeak;
            //act
            decimal returnedChargeAmount = c.CalculateCharge(peakKhwused,offPeakKwhused);
            //Assert
            Assert.AreEqual(totalFlatRate, returnedChargeAmount);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void IndustrialCustomerTestCheckForInvalidArgument()
        {
            //Arrange
            int number = 1234;
            string name = "Kingsley";
            string type = "R";
            IndustrialCustomer c = new IndustrialCustomer(number, name, type);
            decimal peakKhwused = -30M;
            decimal offPeakKwhused = 40;

            //act
            decimal billAmount = c.CalculateCharge(peakKhwused, offPeakKwhused);
            //Assert
            Assert.Fail();
        }

      
    }
}