using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint2.Task2.V21.Lib;

namespace Tyuiu.AbdullinAI.Sprint2.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            bool wait = false;
            int x = 2;
            int y = 10;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
           
        }
    }
}
