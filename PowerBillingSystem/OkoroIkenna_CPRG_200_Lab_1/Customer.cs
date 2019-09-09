using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class Customer
    {
        //public properties of the customer class
        public int AccountNo
        {
            get
            {
                return accountNo;
            }
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }
        }

        public string CustomerType
        {
            get { return customerType; }
        }


        public decimal ChargeAmount
        {
            get { return chargeAmount; }
            set
            {
                if (value <= 0)    //validation using the set accessors
                {
                    throw new ArgumentException("Invalid Charge Amount.");
                }
                chargeAmount = value;
            }
        }


        private  int accountNo;  //instance variable
        private string customerName;
        private string customerType;
        protected decimal chargeAmount;


        //initializing constructors
        public Customer(string fromFile)
        {
            char[] delimiters = { '|', ',', '$'};

            string[] tokens = fromFile.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            accountNo = int.Parse(tokens[0]);
            customerName = tokens[1];
            customerType = tokens[2];
            chargeAmount = decimal.Parse(tokens[3]);

        }

        public Customer(int account, string name, string type )
        {
            if (!validateAccountNo(account))
            {
                throw new ArgumentException("Invalid Account Number. ");
            }

            if (!validateCustomerName(name))
            {
                throw new ArgumentException("Invalid Customer Name. ");
            }

            if (!validateCustomerType(type))
            {
                throw new ArgumentException("Invalid Customer type, should be 'I', 'C' or 'R'.");
            }
            accountNo = account;
            customerName = name;
            customerType = type;
            chargeAmount = 0;
        }

        public string ToFileString()
        {
            string theString = "";

            theString += $"{accountNo}|";
            theString += $"{customerName}|";
            theString += $"{customerType}|";
            theString += $"{ChargeAmount:C2}";

            return theString;
        }
        // To string Method
        public virtual string ToFormattedString()
        {
            string theString = "";

            theString += $"{accountNo,10}";
            theString += $"{customerName,20}";
            theString += $"{customerType,10}";
            theString += $"{ChargeAmount,15:C2}";

            return theString;
        }

        public virtual decimal CalculateCharge(decimal kwhUsed)
        {
            if (kwhUsed < 0)
            {
                throw new ArgumentException("Invalid Kilo Watt Hours for Residential Customer");
            }
            chargeAmount = 0;
            return chargeAmount;
        }
        //create an overload method of calculate charge that takes in two paramters
        //for the industrial customer
        public virtual decimal CalculateCharge(decimal kwhUsed, decimal kwhoffpeakused)
        {
            if (kwhUsed < 0)
            {
                throw new ArgumentException("Invalid Kilo Watt Hours for Residential Customer");
            }
            chargeAmount = 0;
            return chargeAmount;
        }

        public override string ToString()               //when you write a class always create a tostring method...
        {
            return $" Account Number: {accountNo}' Name:'{customerName}'" +
                   $" Customer Type:{customerType} Charge Amount: {chargeAmount:C2}";
        }
        
        //this methods validate customer name
        private bool validateCustomerName(string name)
        {
            if ( !((name != null) && (name.Length > 0)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //this method validates account Number
        private bool validateAccountNo(int accountNo)
        {
            if( !((accountNo >= 0) && (accountNo <= 999999)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //this method validates customer type
        private bool validateCustomerType(string type)
        {
            if ((type == "I") || (type == "R") || (type == "C"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

        

    }

}
