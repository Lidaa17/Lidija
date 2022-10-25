using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelConsoleExample.Model
{
    class Vehicle
    {
        public int NumberOfWheels { get; set; }
        public string Name { get; set; }

        public Vehicle(int numberOfWheels, string name)
        {
            NumberOfWheels = numberOfWheels;
            Name = name;
        }

        public Vehicle() { }

        public override string ToString()
        {
            return String.Format("| Name: {0,20} | NumberOfWheels: {1,5} |", Name, NumberOfWheels);
        }

    }
}
