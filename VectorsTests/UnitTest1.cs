using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VectorsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Return_True_Magnitude_Vector12() 
        {
            VectorsAndAngles.Vector vector = new VectorsAndAngles.Vector(1, 2);
            double magn = vector.magnitude();
            Assert.AreEqual(magn, 2.2360679774997896964091736687313);
        }

        [TestMethod]
        public void Return_False_Magnitude_Vector12()
        {
            VectorsAndAngles.Vector vector = new VectorsAndAngles.Vector(1, 2);
            double magn = vector.magnitude();
            Assert.AreNotEqual(magn, 2.25);
        }
    }
}
