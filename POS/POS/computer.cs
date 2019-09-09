using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory
{
    class Computer : Product
    {
        // public properties

        public int RamSize
        {
            get { return ramSize; }
        }
        public float CpuSpeed
        {
            get { return cpuSpeed; }
        }

        // private properties

        private int ramSize;
        private float cpuSpeed;

        // constructors

        public Computer(string name,
                        long id,
                        decimal cost,
                        int quantity,
                        int ram,
                        float speed) : base(name, id, cost, quantity)
        {
            // validate the ram and speeed

            if (ram < 0)
                throw new ArgumentException("negative ram size");
            if (speed < 0)
                throw new ArgumentException("negative cpu speed");

            // initialize properties

            ramSize = ram;
            cpuSpeed = speed;
        }

        public Computer(string name,
                       long id,
                       decimal cost,
                       int ram,
                       float speed) : base(name, id, cost)
        {
            // validate the ram and speeed

            if (ram < 0)
                throw new ArgumentException("negative ram size");
            if (speed < 0)
                throw new ArgumentException("negative cpu speed");

            // initialize properties

            ramSize = ram;
            cpuSpeed = speed;
        }

        public Computer(string fromFile) : base(fromFile)
        {
            char[] delimiters = { '|', ',' };

            string[] tokens = fromFile.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);


            ramSize = int.Parse(tokens[4]);
            cpuSpeed = float.Parse(tokens[5]);


        }

        public override string ToFileString()
        {
            return base.ToFileString() + $"|{ramSize}|{cpuSpeed}";
        }

        public override string ToFormattedString()
        {
            return base.ToFormattedString() + $"  {ramSize,3}GB   {cpuSpeed,7:N2} MHz";
        }

        public override string ToString()
        {
            return base.ToString() + $" RAM:{ramSize}GB CPU:{cpuSpeed}Mhz";
        }
    }
}
