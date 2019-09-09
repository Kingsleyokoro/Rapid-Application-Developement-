using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class ResidentialCustomer : Customer
    {
        //public properties
        public decimal ResidentialFlatRate
        {
            get { return residentialFlatRate; }
        }

        public decimal KwhDefaultRate
        {
            get { return kwhDefaultRate; }
        }


        private decimal residentialFlatRate;
        private decimal kwhDefaultRate;

        //constructors

        public ResidentialCustomer(int account, string name,
                                    string type) : base(account, name, type)
        {
            residentialFlatRate = 6M;
            kwhDefaultRate = 0.052M;
        }

        public ResidentialCustomer(string fromFile) : base(fromFile)
        {
            char[] delimiters = { '|', ',','$'};

            string[] tokens = fromFile.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        }

        public override decimal CalculateCharge(decimal kwhUsed)
        {
            if (kwhUsed < 0)
            {
                throw new ArgumentException("Invalid Kilo Watt Hours for Residential Customer");
            }
            
            chargeAmount = (residentialFlatRate + (kwhDefaultRate * kwhUsed));
            return chargeAmount;
        }

        
      
    }
}
