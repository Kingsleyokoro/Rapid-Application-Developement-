using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class IndustrialCustomer : Customer
    {
        //declaring the class properties
        public decimal IndustrialPeakFlatRate
        {
            get { return industrialPeakFlatRate; }
        }

        public decimal IndustrialOffPeakFlatRate
        {
            get { return industrialOffPeakFlatRate; }
        }

        public decimal KwhDefaultPeakRate
        {
            get { return kwhDefaultPeakRate; }
        }

        public decimal KwhDefaultOffPeakRate
        {
            get { return kwhDefaultOffPeakRate; }
        }

        public int BILL_LIMIT
        {
            get { return bill_Limit; }
        }


        //declaring shadow properties
        private decimal industrialPeakFlatRate;//this is the flat rate during peak hours
        private decimal industrialOffPeakFlatRate;//this the flat are during off peak hours
        private decimal kwhDefaultPeakRate;//if customer exceeds 1000 kwh, this is charged for every additonal Kwh for peak hours
        private const int bill_Limit = 1000;//since the limit to incure extra charge is fixed at 1000. hence, declaring the variable as a constant
        private decimal kwhDefaultOffPeakRate;//if customer exceeds 1000 kwh, this is charged for every additonal Kwh for off peakhours

        //declaring constructors
        public IndustrialCustomer(int account, string name,
                                    string type) : base(account, name, type)
        {
            industrialPeakFlatRate = 76M;
            industrialOffPeakFlatRate = 40M;
            kwhDefaultPeakRate = 0.065M;
            kwhDefaultOffPeakRate = 0.028M;
        }

        public IndustrialCustomer(string fromFile) : base(fromFile)
        {
            char[] delimiters = { '|', ',', '$' };

            string[] tokens = fromFile.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            //commercialFlatRate = decimal.Parse(tokens[4]);
            //kwhDefaultRate = decimal.Parse(tokens[5]);
        }

        public override decimal CalculateCharge(decimal kwhPeakUsed, decimal kwhoffpeakused)
        {
            if (kwhPeakUsed < 0  || kwhoffpeakused < 0)
            {
                throw new ArgumentException("Invalid Kilo Watt Hours");
            }
            decimal peakBill;
            decimal offPeakBill;

            if (kwhPeakUsed <= BILL_LIMIT)
            {
                peakBill = industrialPeakFlatRate;
            }
            else
            {
                peakBill = industrialPeakFlatRate + (kwhDefaultPeakRate * (kwhPeakUsed - BILL_LIMIT));
            }
            if(kwhoffpeakused <= BILL_LIMIT)
            {
                offPeakBill = industrialOffPeakFlatRate;
            }
            else
            {
                offPeakBill = industrialOffPeakFlatRate + (kwhDefaultOffPeakRate * (kwhoffpeakused - BILL_LIMIT));
            }
            chargeAmount = peakBill + offPeakBill;
            return chargeAmount;
        }

        

       
    }
}
