using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KopylskikhVM.Sprint2.Task5.V4.Lib;

namespace Tyuiu.KopylskikhVM.Sprint2.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition()
        {
            DataService ds = new DataService();

            Assert.AreEqual("пики", ds.FindCardSuit(1));
            Assert.AreEqual("трефы", ds.FindCardSuit(2));
            Assert.AreEqual("бубны", ds.FindCardSuit(3));
            Assert.AreEqual("червы", ds.FindCardSuit(4));

            try
            {
                ds.FindCardSuit(0);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
            }

            try
            {
                ds.FindCardSuit(5);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
            }
        }
    }
}