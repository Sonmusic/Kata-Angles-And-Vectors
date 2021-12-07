using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VectorsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Return_True_Magnitude_Vector12() 
        {
            VectorsAndAngles.Vector vector = VectorsAndAngles.Vector();
            double magn = vector.Magnitude();
            Assert.AreEqual(magn, x);
        }
    }
}
