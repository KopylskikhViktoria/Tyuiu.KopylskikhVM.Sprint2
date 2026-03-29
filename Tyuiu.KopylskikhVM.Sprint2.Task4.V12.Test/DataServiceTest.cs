using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KopylskikhVM.Sprint2.Task4.V12.Lib;

namespace Tyuiu.KopylskikhVM.Sprint2.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            double x = 4;
            double y = 0.5;

            double res = ds.Calculate(x, y);

            Assert.AreEqual(50625, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 2;

            double res = ds.Calculate(x, y);

            Assert.AreEqual(0.846, res);
        }
    }
}