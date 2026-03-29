using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KopylskikhVM.Sprint2.Task3.V10.Lib;

namespace Tyuiu.KopylskikhVM.Sprint2.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            double x = 2;
            double res = ds.Calculate(x);

            Assert.AreEqual(-70.250, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();

            double x = 0;
            double res = ds.Calculate(x);

            Assert.AreEqual(-1.000, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();

            double x = -2;
            double res = ds.Calculate(x);

            Assert.AreEqual(0.036, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();

            double x = -15;
            double res = ds.Calculate(x);

            Assert.AreEqual(-164.933, res);
        }
    }
}