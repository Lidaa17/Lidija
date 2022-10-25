using ModelConsoleExample.Model;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = InputVehicle();
            Console.WriteLine(vehicle);

            Console.ReadKey();
        }

        static Vehicle InputVehicle()
        {
            Vehicle vehicle = new Vehicle();

            Console.WriteLine("Enter vehicle name: ");
            String name = Console.ReadLine();
            vehicle.Name = name;

            Console.WriteLine("Enter No. of wheels: ");
            int wheels = Convert.ToInt32(Console.ReadLine());
            vehicle.NumberOfWheels = wheels;

            return vehicle;
        }
    }
}
