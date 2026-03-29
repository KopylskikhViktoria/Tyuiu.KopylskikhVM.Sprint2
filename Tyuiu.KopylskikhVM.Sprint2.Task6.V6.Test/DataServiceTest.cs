using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KopylskikhVM.Sprint2.Task6.V6.Lib;

namespace Tyuiu.KopylskikhVM.Sprint2.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Дама пик", ds.FindCardNameAndValue(1, 12));
            Assert.AreEqual("Шестерка бубен", ds.FindCardNameAndValue(3, 6));
            Assert.AreEqual("Туз черв", ds.FindCardNameAndValue(4, 14));
            Assert.AreEqual("Валет треф", ds.FindCardNameAndValue(2, 11));

            try
            {
                ds.FindCardNameAndValue(0, 12);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
            }

            try
            {
                ds.FindCardNameAndValue(1, 5);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
            }
        }
    }
}