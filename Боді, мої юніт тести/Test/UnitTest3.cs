using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_1;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void Chenge_Profit()
        {
            var ID_Profit = "5";
            var Date_Profit = "25.12.2022";
            var Profit_ = "130";
            var ComentPr = "-";
            bool expected = true;

            Add_del_info gr = new Add_del_info();
            var actual = gr.ChengeProfitData( ID_Profit, Date_Profit, Profit_, ComentPr);
            Assert.AreEqual(expected, actual);
        }
    }
}
