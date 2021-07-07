using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public string Carrier;

        public SmartPhone(string carrier, string brand, string model) : base(brand)
        {
            this.Carrier = carrier;
        }
        
        public void Service(string carrier)
        {
            this.Carrier = carrier;
            Console.WriteLine("Hello");
        }

        public void MakePhoneCall()
        {
            Console.WriteLine("Connecting call...");
        }
    }
}
