using System;
using System.Data.SqlClient;

namespace WindowsFormsApp1.DB.Entities
{
    public interface IBusket1 : IEntity
    {
        string ID_Product_ { get; set; }
        string Product_name_ { get; set; }
        string Product_cost_ { get; set; }
        string Product_quantity_ { get; set; }
        string Product_description_ { get; set; }
        string Basket_time { get; set; }
    }

    
    public class Basket1 : IBusket1
    {
        private string iD_Product_;
        private string product_name_;
        private string product_cost_;
        private string product_quantity_;
        private string product_description_;
        private string basket_time;

        public string ID_Product_ { get => iD_Product_; set => iD_Product_ = Validate(value, nameof(ID_Product_)); }
        public string Product_name_ { get => product_name_; set => product_name_ = Validate(value, nameof(product_name_)); }
        public string Product_cost_ { get => product_cost_; set => product_cost_ = Validate(value, nameof(product_cost_)); }
        public string Product_quantity_ { get => product_quantity_; set => product_quantity_ = Validate(value, nameof(product_quantity_)); }
        public string Product_description_ { get => product_description_; set => product_description_ = Validate(value, nameof(product_description_)); }

        public string Basket_time { get => basket_time; set => basket_time = Validate(value, nameof(basket_time)); }


        public SqlCommand delete()
        {
            SqlCommand command = new SqlCommand($"DELETE FROM [Basket]  ");
            command.Parameters.AddWithValue("ID_Product_", ID_Product_);
            return command;
        }

        public SqlCommand insert()
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Basket] (ID_Product_, Product_name_, Product_cost_, Product_description_, Product_quantity_, Basket_time) VALUES (@ID_Product_, @Product_name_, @Product_cost_, @Product_description_, @Product_quantity_,@Basket_time)");
            command.Parameters.AddWithValue("ID_Product_", ID_Product_);
            command.Parameters.AddWithValue("Product_name_", Product_name_);
            command.Parameters.AddWithValue("Product_cost_", Product_cost_);
            command.Parameters.AddWithValue("Product_description_", Product_description_);
            command.Parameters.AddWithValue("Product_quantity_", Product_quantity_);
            command.Parameters.AddWithValue("Basket_time", Basket_time);


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
            /*command.Parameters.AddWithValue("ID_Product1", ID_Product);
            command.Parameters.AddWithValue("Product_name1", Product_name);
            command.Parameters.AddWithValue("Product_cost1", Product_cost);
            command.Parameters.AddWithValue("Product_description1", Product_description);
            command.Parameters.AddWithValue("Product_quantity1", Product_quantity);*/

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
