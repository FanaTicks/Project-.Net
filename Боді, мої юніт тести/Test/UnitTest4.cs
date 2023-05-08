using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;
using Project_1;

namespace Test
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void Culculete_PR()
        {
            int pr1 = 69;
            int pr2 = 50;
            int expected = 119;
            Calculate f = new Calculate();
            double actual = f.Sum_Profit(pr1, pr2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Culculete_SP()
        {
            int sp1 = 69;
            int sp2 = 50;
            int expected = 119;

            Calculate f = new Calculate();
            double actual = f.Sum_Sp(sp1, sp2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Culculete_Res()
        {
            int pr = 69;
            int sp = 50;
            int expected = 19;

            Calculate f = new Calculate();
            double actual = f.Res(pr, sp);
            Assert.AreEqual(expected, actual);
        }
    }
}
