using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class CommercialCustomer : Customer
    {
        public decimal CommercialFlatRate
        {
            get { return commercialFlatRate; }
        }

        public decimal KwhDefaultRate
        {
            get { return kwhDefaultRate; }
        }

        public int BILL_LIMIT
            {
                get{return bill_Limit; }
            }
            
      

        private decimal commercialFlatRate;
        private decimal kwhDefaultRate;
        private const int bill_Limit = 1000;

        //initializing constructors
        public CommercialCustomer(int account, string name,
                                    string type) : base(account, name, type)
        {
            commercialFlatRate = 60M;
            kwhDefaultRate = 0.045M;     
        }

        public CommercialCustomer(string fromFile) : base(fromFile)
        {
            char[] delimiters = { '|', ',', '$' };

            string[] tokens = fromFile.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            commercialFlatRate = decimal.Parse(tokens[4]);
            kwhDefaultRate = decimal.Parse(tokens[5]);
        }

        //this method calculate the charge for the commercial customer class
        public override decimal CalculateCharge(decimal kwhUsed)
        {
            
            if (kwhUsed < 0)
            {
                throw new ArgumentException("Invalid Kilo Watt Hour for Commercial Customer");
            }
            if (kwhUsed <= BILL_LIMIT)
            {
                chargeAmount = commercialFlatRate;
            }
            else
            {
                chargeAmount = commercialFlatRate + (kwhDefaultRate * (kwhUsed - BILL_LIMIT));
            }
            return chargeAmount;
        }

        
    }

}
