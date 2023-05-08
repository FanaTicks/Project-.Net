using Project_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Data;


namespace Test
{
    [TestClass]
    public class Autorization_Tesr
    {
        [TestMethod]
        public void Autorization_()
        {
            string Name = "User1";
            string Pass = "123";

            bool expected = true;
            Autorization x = new Autorization();
            var actual = x.autoriz(Name, Pass);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_notautorization()
        {
            string Name = "User12342442";
            string Pass = "123";

            bool expected = true;
            Autorization x = new Autorization();
            var actual = x.autoriz(Name, Pass);
            Assert.AreEqual(expected, actual);
        }
    }


}
