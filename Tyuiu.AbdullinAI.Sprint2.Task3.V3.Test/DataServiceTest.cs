﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint2.Task3.V3.Lib;

namespace Tyuiu.AbdullinAI.Sprint2.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 18;
            Assert.AreEqual(wait, res);


        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.167;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();
            double x = -3;
            double res = ds.Calculate(x);
            double wait = 1;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculate4()
        {
            DataService ds = new DataService();
            double x = -10;
            double res = ds.Calculate(x);
            double wait = 0.1;
            Assert.AreEqual(wait, res);
        }
    }
}
