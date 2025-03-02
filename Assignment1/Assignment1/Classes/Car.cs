using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Classes
{
    public class Car
    {
        public string brand;
        public string gear;

        public void gearType(string brand, string gear)
        {
            Console.WriteLine(brand + " -> " + gear + " viteslidir.");
        }
    }
}
