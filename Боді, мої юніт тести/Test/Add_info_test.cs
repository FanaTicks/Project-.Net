using Project_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Data;

namespace Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void MyTestMethod()
        {
            var ig = "4";
            var date = "23.11.2022";
            var profit = "150";
            var coment = "-";

            bool expected = true;

            Add_del_info gr = new Add_del_info();
            var actual = gr.NewProfit(Date_Profit, Profit_, ComentPr);
            Assert.AreEqual(expected, actual);
        }
    }
}