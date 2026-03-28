using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KopylskikhVM.Sprint2.Task1.V10.Lib;

namespace Tyuiu.KopylskikhVM.Sprint2.Task1.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();

            int a = 455;
            int b = 335;
            int c = 14;
            int d = 17;

            bool[] res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = { true, false, false, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}