using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using System.Data.SqlClient;
using WindowsFormsApp1.DB.Entities;

namespace WindowsFormsApp1.Tests
{
    [TestClass]
    public class WinForTests
    {
        [TestMethod]
        public void insertButton_click_test()
        {
            // arrange
            ICTicket product = new DB.Entities.Product
            {
                ID_Product = "p123",
                Product_name = "tort",
                Product_type = "hlibobulochne",
                Product_description = "tort - ie tort",
                Material = "korzh, krem",
                ID_Manufacturer = "mf3"
            };
            var connectionString = (@"Data Source=DESKTOP-KF4O4GA\SQLEXPRESS;Initial Catalog=Store;Integrated Security=True");
            var sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            DBCust dbHandler = new DBCust(sqlConnection);
            var expected = true;
            // act
            var actual = dbHandler.insert(new[] { product });
            dbHandler.Delete(new[] { product });
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void updateButton_click_test()
        {
            // arrange
            DB.Entities.Product product = new DB.Entities.Product
            {
                ID_Product = "p12",
                Product_name = "tort",
                Product_type = "hlibobulochne",
                Product_description = "tort - ie tort",
                Material = "korzh, krem",
                ID_Manufacturer = "mf3"
            };
            var connectionString = (@"Data Source=DESKTOP-KF4O4GA\SQLEXPRESS;Initial Catalog=Store;Integrated Security=True");
            var sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            DBCust dbHandler = new DBCust(sqlConnection);
            var expected = true;
            // act
            var actual = dbHandler.update(product, product.ID_Product);
            //dbHandler.Delete(new[] { product });
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void delButton_click_test()
        {
            // arrange
            DB.Entities.Product product = new DB.Entities.Product
            {
                ID_Product = "p12",
            };
            var connectionString = (@"Data Source=DESKTOP-KF4O4GA\SQLEXPRESS;Initial Catalog=Store;Integrated Security=True");
            var sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            DBCust dbHandler = new DBCust(sqlConnection);
            var expected = true;
            // act
            var actual = dbHandler.Delete(new[] { product });
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void validate_test()
        {
            // arrange
            var testData = "p12";
            DB.Entities.Product product = new DB.Entities.Product
            {
                ID_Product = testData,
            };
            var expected = "p12";
            // act
            var actual = product.ID_Product;
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}