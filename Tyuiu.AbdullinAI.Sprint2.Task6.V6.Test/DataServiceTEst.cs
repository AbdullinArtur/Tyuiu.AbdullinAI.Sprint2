using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint2.Task6.V6.Lib;

namespace Tyuiu.AbdullinAI.Sprint2.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();
           
            Assert.AreEqual("Шестёрка пики", ds.FindCardNameAndValue(1, 6));


        }
    }
}
