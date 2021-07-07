using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class ComputerTests
    {
        [TestMethod]
        public void SetsDeviceBrand()
        {
            Computer newComputer = new Computer("Apple", "iPhone X");
            Assert.AreEqual(newComputer.Brand, "Apple");
        }

        [TestMethod]
        public void SetsDeviceModel()
        {
            Computer newComputer = new Computer("Apple", "iPhone X");
            Assert.AreEqual(newComputer.Model, "iPhone X");
        }
    }
}
