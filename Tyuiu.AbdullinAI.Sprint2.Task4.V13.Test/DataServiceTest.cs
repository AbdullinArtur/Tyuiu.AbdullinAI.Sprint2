using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint2.Task4.V13.Lib;

namespace Tyuiu.AbdullinAI.Sprint2.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x, y;
            x = 4;
            y = 4;
            double res = ds.Calculate(x, y);
            double wait = 43.75;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x, y;
            x = 1;
            y = 12;
            double res = ds.Calculate(x, y);
            double wait = 0.096;
            Assert.AreEqual(wait, res);
        }
    }
}
