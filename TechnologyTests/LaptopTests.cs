using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class LaptopTests
    {
        [TestMethod]
        public void SetsDeviceYear()
        {
            Laptop newLaptop = new Laptop(2020, "Apple", "iPhone X", "laptop");
            Assert.AreEqual(newLaptop.Year, 2020);
        }
    }
}
