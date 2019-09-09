using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory
{
    public class Chocolate : Product
    {
        // Public properties

        public float Mass
        {
            get { return Mass; }
        }

        // private properties

        private float mass;

        public Chocolate(string name,
                        long id,
                        decimal cost,
                        int quantity,
                        float mass) : base(name, id, cost, quantity)
        {
            if (mass <= 0)
                throw new ArgumentException("mass is negative");

            this.mass = mass;
        }

        public Chocolate(string name,
                        long id,
                        decimal cost,
                        float mass) : base(name, id, cost)
        {
            if (mass <= 0)
                throw new ArgumentException("mass is negative");

            this.mass = mass;
        }

        public Chocolate(string fromFile) : base(fromFile)
        {
            char[] delimiters = { '|', ',' };

            string[] tokens = fromFile.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            mass = float.Parse(tokens[4]);
        }

        public override int Sell(int quantitySold)
        {
            if (!(quantitySold % 1 == 0))
                throw new ArgumentException("odd quantity being sold");

            return base.Sell(quantitySold);
        }

        public override string ToString()
        {
            return base.ToString() + $" Mass:{mass}g";
        }

        public override string ToFormattedString()
        {
            return base.ToFormattedString() + $" {mass} grams";
        }    

    }
}
