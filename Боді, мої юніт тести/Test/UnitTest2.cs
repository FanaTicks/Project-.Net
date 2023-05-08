using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_1;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Delite_profit()
        {
            string ID_Profit = "4";
            bool expected = true;

            Add_del_info gr = new Add_del_info();
            var actual = gr.Deletedgrinh(ID_Profit);
            Assert.AreEqual(expected, actual);
        }
    }
}
