using System;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartPhone phone1 = new SmartPhone("Verizon", "Apple", "iPhone X");

            Console.WriteLine(phone1.Brand);
            phone1.DeviceInfo("Smart Phone", "Apple", "iPhone X");
            phone1.Service("Verizon");
            phone1.MakePhoneCall();

            Laptop laptop1 = new Laptop(2020, "Apple", "Macbook Pro", "laptop");
            laptop1.DeviceInfo("Laptop", "Apple", "Macbook Pro");
            laptop1.Reboot();
            
        }
    }
}
