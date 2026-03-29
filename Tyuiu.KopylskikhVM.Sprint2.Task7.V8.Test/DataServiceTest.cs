using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KopylskikhVM.Sprint2.Task7.V8.Lib;

namespace Tyuiu.KopylskikhVM.Sprint2.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition()
        {
            DataService ds = new DataService();

            Assert.AreEqual(true, ds.CheckDotInShadedArea(1, 2));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(3, 1));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(1, 0.5));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(-1, 2));
        }
    }
}