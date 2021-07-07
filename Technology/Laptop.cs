using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Laptop : Computer
    {
        public int Year { get; set; }

        public Laptop(int year, string brand, string model, string typeOfDevice) : base(typeOfDevice)
        {
            Year = year;
        }
        
        public void Reboot()
        {
            Console.WriteLine("Please standby, computer rebooting...");
        }
    
    }
}
