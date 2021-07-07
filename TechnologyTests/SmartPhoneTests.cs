using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class SmartPhoneTests
    {
        [TestMethod]
        public void SetsDeviceCarrier()
        {
            SmartPhone newSmartPhone = new SmartPhone("Verizon", "Apple", "iPhone X");
            Assert.AreEqual(newSmartPhone.Carrier, "Verizon");
        }
    }
}
