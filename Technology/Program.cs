using System;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartPhone phone1 = new SmartPhone("Verizon", "Apple", "iPhone X");

            Console.WriteLine(phone1.Brand);
            phone1.DeviceInfo("Apple", "iPhone X");
            phone1.MakePhoneCall();
            
        }
    }
}
