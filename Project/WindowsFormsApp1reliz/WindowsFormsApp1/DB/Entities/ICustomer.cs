using System;
using System.Data.SqlClient;
using WindowsFormsApp1.DB.Entities;

namespace WindowsFormsApp1.DB.Entities
{
    public interface ICustomer : IEntity
    {
        string ID_Customer { get; set; }
        string Customer_name { get; set; }
        string Customer_surname { get; set; }
        string Customer_Phone { get; set; }
        string Customer_Post_Adres { get; set; }

    } 
}


public class Customer : ICustomer
{
    private string id_cust;
    private string cust_name;
    private string cust_sname;
    private string cust_phone;
    private string cast_post_adres;

    public string ID_Customer { get => id_cust; set => id_cust = Validate(value, nameof(ID_Customer)); }
    public string Customer_name { get => cust_name; set => cust_name = Validate(value, nameof(cust_name)); }
    public string Customer_surname { get => cust_sname; set => cust_sname = Validate(value, nameof(cust_sname)); }
    public string Customer_Phone { get => cust_phone; set => cust_phone = Validate(value, nameof(cust_phone)); }
    public string Customer_Post_Adres { get => cast_post_adres; set => cast_post_adres = Validate(value, nameof(cast_post_adres)); }


       public SqlCommand delete()
        {
            SqlCommand command = new SqlCommand($"DELETE FROM [Customer] WHERE ID_Customer=@ID_Customer2; ");
            command.Parameters.AddWithValue("ID_Customer2", ID_Customer);
            return command;
        }

        public SqlCommand insert()
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Customer] (ID_Customer, Customer_name, Customer_surname, Customer_Phone,Customer_Post_Adres) VALUES (@ID_Customer, @Customer_name, @Customer_surname, @Customer_Phone, @Customer_Post_Adres)");
            command.Parameters.AddWithValue("ID_Customer", ID_Customer);
            command.Parameters.AddWithValue("Customer_name", Customer_name);
            command.Parameters.AddWithValue("Customer_surname", Customer_surname);
            command.Parameters.AddWithValue("Customer_Phone", Customer_Phone);
            command.Parameters.AddWithValue("Customer_Post_Adres", Customer_Post_Adres);


            return command;
        }

    /*public SqlCommand price()
    {
        SqlCommand command = new SqlCommand($"INSERT INTO [Customer] () VALUES ()");
        return command;
    }*/
    public SqlCommand update(string IDEntityToUpdate)
        {
            SqlCommand command = new SqlCommand($"UPDATE [Customer] SET Customer_name=@Customer_name1, Customer_surname=@Customer_surname1, Customer_Phone=@Customer_Phone1, Customer_Post_Adres=@Customer_Post_Adres1 WHERE ID_Customer=@ID_Customer1;");
            command.Parameters.AddWithValue("ID_Customer1", IDEntityToUpdate);
            command.Parameters.AddWithValue("Customer_name1", Customer_name);
            command.Parameters.AddWithValue("Customer_surname1", Customer_surname);
            command.Parameters.AddWithValue("Customer_Phone1", Customer_Phone);
            command.Parameters.AddWithValue("Customer_Post_Adres1", Customer_Post_Adres);

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
