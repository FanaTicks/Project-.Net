using Project_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Data;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ADD_Profit()
        {

            var ID_Profit = "4";
            var Date_Profit = "23.11.2022";
            var Profit_ = "150";
            var ComentPr = "-";
            bool expected = true;

            Add_del_info gr = new Add_del_info();
            var actual = gr.NewProfit(ID_Profit, Date_Profit, Profit_, ComentPr);
            Assert.AreEqual(expected, actual);
        }
    }
}
