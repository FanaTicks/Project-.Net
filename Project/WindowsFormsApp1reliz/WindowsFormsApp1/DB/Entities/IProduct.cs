using System;
using System.Data.SqlClient;

namespace WindowsFormsApp1.DB.Entities
{
    public interface IProduct : IEntity
    {
        string ID_Product { get; set; }
        string Product_name { get; set; }
        string Product_cost { get; set; }
        string Product_quantity { get; set; }
        string Product_description { get; set; }
    }

    
    public class Product : IProduct
    {
        private string iD_Product;
        private string product_name;
        private string product_cost;
        private string product_quantity;
        private string product_description;

        public string ID_Product { get => iD_Product; set => iD_Product = Validate(value, nameof(ID_Product)); }
        public string Product_name { get => product_name; set => product_name = Validate(value, nameof(product_name)); }
        public string Product_cost { get => product_cost; set => product_cost = Validate(value, nameof(product_cost)); }
        public string Product_description { get => product_description; set => product_description = Validate(value, nameof(product_description)); }
        public string Product_quantity { get => product_quantity; set => product_quantity = Validate(value, nameof(product_quantity)); }
       

        public SqlCommand delete()
        {
            SqlCommand command = new SqlCommand($"DELETE FROM [Product] WHERE ID_Product=@ID_Product2; ");
            command.Parameters.AddWithValue("ID_Product2", ID_Product);
            return command;
        }

        public SqlCommand insert()
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Product] (ID_Product, Product_name, Product_cost, Product_description, Product_quantity) VALUES (@ID_Product, @Product_name, @Product_cost, @Product_description, @Product_quantity)");
            command.Parameters.AddWithValue("ID_Product", ID_Product);
            command.Parameters.AddWithValue("Product_name", Product_name);
            command.Parameters.AddWithValue("Product_cost", Product_cost);
            command.Parameters.AddWithValue("Product_description", Product_description);
            command.Parameters.AddWithValue("Product_quantity", Product_quantity);
            

            return command;
        }
        public SqlCommand price()
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Product] (ID_Product, Product_name, Product_type, Product_description, Material, ID_Manufacturer) VALUES (@ID_Product, @Product_name, @Product_type, @Product_description, @Material, @ID_Manufacturer)");
            /*command.Parameters.AddWithValue("ID_Product", ID_Product);
            command.Parameters.AddWithValue("Product_name", Product_name);
            command.Parameters.AddWithValue("Product_type", Product_type);
            command.Parameters.AddWithValue("Product_description", Product_description);
            command.Parameters.AddWithValue("Material", Material);
            command.Parameters.AddWithValue("ID_Manufacturer", ID_Manufacturer);*/

            return command;
        }
        public SqlCommand update(string IDEntityToUpdate)
        {
            SqlCommand command = new SqlCommand($"UPDATE [Product] SET Product_name=@Product_name1, Product_cost=@Product_cost1, Product_description=@Product_description1, Product_quantity=@Product_quantity1 WHERE ID_Product=@ID_Product1;");
            command.Parameters.AddWithValue("ID_Product1", ID_Product);
            command.Parameters.AddWithValue("Product_name1", Product_name);
            command.Parameters.AddWithValue("Product_cost1", Product_cost);
            command.Parameters.AddWithValue("Product_description1", Product_description);
            command.Parameters.AddWithValue("Product_quantity1", Product_quantity);

            return command;
        }
        private string Validate(string validObj, string objName)
        {
            if (string.IsNullOrEmpty(validObj))
            {
                throw new ArgumentNullException($"{objName} is null or empty");
            }
            return validObj;
        }
    }
}
