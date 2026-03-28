using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KopylskikhVM.Sprint2.Task0.V8.Lib;

namespace Tyuiu.KopylskikhVM.Sprint2.Task0.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();

            int x = 185;
            int y = 251;

            bool[] res = ds.GetCompareOperations(x, y);
            bool[] wait = { true, false, true, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}