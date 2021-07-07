using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Computer
    {
        //Attributes
        public string Brand;
        public double ScreenSize;
        

        public void BrandName(string brand)
        {
            Brand = brand;
            Console.WriteLine(brand);
        }

               
        public Computer(double screenSize)
        {
            ScreenSize = screenSize;
        }

        public void TurnOn()
        {
            Console.WriteLine("Loading...");
        }
    }
}
