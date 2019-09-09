using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory
{
    public class Product
    {
        // PUBLIC properties of Product Class

        public string ProductName         // short name of the product
        {
            get
            {
                return productName;
            }
        }
        public long ID                  // unique identifying number (SKU)
        {
            get
            {
                return iD;
            }
        }
        public int QuantityOnHand      // the count of the in-stock items of this prdouct
        {
            get
            {
                return quantityOnHand;
            }
        }
        public decimal Cost                // the cost of an individual item, in $
        {
            get
            {
                return cost;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Negative cost");
                }
                cost = value;
            }
        }
        public decimal InventoryValue
        {
            get { return QuantityOnHand * Cost; }
        }

        // PRIVATE SHADOW properties

        private string productName;
        private long iD;
        private int quantityOnHand;
        private decimal cost;



        // constructors
        
        public Product(string fromFile)
        {
            char[] delimiters = { '|', ',' };

            string[] tokens = fromFile.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            productName    = tokens[0];
            iD             = long.Parse(tokens[1]);
            cost           = decimal.Parse(tokens[3]);
            quantityOnHand = int.Parse(tokens[2]);
        }

        public Product(string name, long productID, decimal productCost)
        {
            if (!validateProductName(name))
                throw new ArgumentException("bad name");

            if (!validateProductID(productID))
                throw new ArgumentException("bad product id");

            productName = name;
            iD = productID;
            Cost = productCost;
            quantityOnHand = 0;
        }

        public Product(string name, long productID, decimal cost, int quantity)
        {
            if (!validateProductName(name))
                throw new ArgumentException("bad name");

            if (!validateProductID(productID))
                throw new ArgumentException("bad product id");

            if (!validateQuantityOnHand(quantity))
            {
                throw new ArgumentException("negative quantity");
            }

            productName = name;
            iD = productID;
            Cost = cost;
            quantityOnHand = quantity;
        }

        public virtual int Stock(int newQuantity)
        {
            if (newQuantity <= 0)
            {
                throw new ArgumentException("invalid restock quantity");
            }
            quantityOnHand += newQuantity;

            return QuantityOnHand;
        }

        public virtual int Sell(int quantitySold)
        {
            if (quantitySold <= 0)
            {
                throw new ArgumentException("invalid sell quantity");
            }

            if (quantitySold > quantityOnHand)
            {
                throw new ArgumentException("insufficient quantity");
            }

            quantityOnHand -= quantitySold;

            return QuantityOnHand;
        }

        public virtual string ToFileString()
        {
            string theString = "";

            theString += $"{productName}|";
            theString += $"{iD}|";
            theString += $"{quantityOnHand}|";
            theString += $"{cost}";

            return theString;
        }

        public virtual string ToFormattedString()
        {
            string theString = "";

            theString += $"{productName,-30}";
            theString += $"{iD,12}";
            theString += $"{quantityOnHand,6}";
            theString += $"{cost,10:C2}";

            return theString;

        }

        public override string ToString()
        {
            return $"Product: Name:'{ProductName}' Id:{ID} Quantity:{QuantityOnHand}";
        }


        // Private (Helper) Methods

        private bool validateProductName(string name)
        {
            if (!((name != null) && (name.Length > 0)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validateProductID(long productID)
        {
            if (!((productID >= 100000) && (productID <= 9999999999)))
                return false;
            else
                return true;
        }

        private bool validateQuantityOnHand(int quantity)
        {
            if (!(quantity >= 0))
                return false;
            else
                return true;
        }


    }
}
