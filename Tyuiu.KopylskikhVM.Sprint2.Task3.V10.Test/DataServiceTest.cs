using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KopylskikhVM.Sprint2.Task3.V10.Lib;

namespace Tyuiu.KopylskikhVM.Sprint2.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double x = 2;

            double res = ds.Calculate(x);

            Assert.AreEqual(-70.250, res);
        }
    }
}