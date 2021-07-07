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
        public string Brand { get; set; }
        public string Model { get; set; }
        public string TypeOfDevice { get; set; }
        
        public Computer(string brand, string model)
        {
            this.Brand = brand;
            this.Model = model;            
        }

        public Computer(string typeOfDevice)
        {
            TypeOfDevice = typeOfDevice;
        }

       public void DeviceInfo(string typeOfDevice, string brand, string model)
        {
            Console.WriteLine($"This is a: {typeOfDevice}. It is a(n) {brand} {model}");
        }
    }
}
