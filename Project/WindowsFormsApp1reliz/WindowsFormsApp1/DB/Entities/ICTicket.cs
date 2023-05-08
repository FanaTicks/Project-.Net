using System;
using System.Data.SqlClient;

namespace WindowsFormsApp1.DB.Entities
{
    public interface ICTicket : IEntity
    {
        string ID_Ticket { get; set; }
        
        string Name_Customer { get; set; }
        string SName_Customer { get; set; }
        string Ticket_type { get; set; }
        string Ticket_price { get; set; }
        string Ticket_discription { get; set; }
        string Ticket_start_date { get; set; }
        string Ticket_end_date { get; set; }
        string Ticket_permitions { get; set; }


    }


    public class Ticket1 : ICTicket
    {
        private string id_ticket;
        /*private string id_customer;
        private string id_couch;
        private string id_admin;*/
        private string name_customer;
        private string sname_customer;
        private string ticket_type;
        private string ticket_price;
        private string ticket_discription;
        private string ticket_start_date;
        private string ticket_end_date;
        private string ticket_permitions;

        public string ID_Ticket { get => id_ticket; set => id_ticket = Validate(value, nameof(ID_Ticket)); }
        public object ID_Coach { get; set; }
        public string Name_Customer { get => name_customer; set => name_customer = Validate(value, nameof(name_customer)); }
        public string SName_Customer { get => sname_customer; set => sname_customer = Validate(value, nameof(sname_customer)); }
        public string Ticket_type { get => ticket_type; set => ticket_type = Validate(value, nameof(ticket_type)); }
        public string Ticket_price { get => ticket_price; set => ticket_price = Validate(value, nameof(ticket_price)); }
        public string Ticket_discription { get => ticket_discription; set => ticket_discription = Validate(value, nameof(ticket_discription)); }
        public string Ticket_start_date { get => ticket_start_date; set => ticket_start_date = Validate(value, nameof(ticket_start_date)); }
        public string Ticket_end_date { get => ticket_end_date; set => ticket_end_date = Validate(value, nameof(ticket_end_date)); }
        public string Ticket_permitions { get => ticket_permitions; set => ticket_permitions = Validate(value, nameof(ticket_permitions)); }


        public SqlCommand delete()
        {
            SqlCommand command = new SqlCommand($"DELETE FROM [Ticket] WHERE ID_Ticket = @ID_Ticket2; ");
            command.Parameters.AddWithValue("ID_Ticket2", ID_Ticket);
            return command;
        }

        public SqlCommand insert()
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Ticket] (ID_Ticket, ID_Coach, Name_Customer, SName_Customer, Ticket_type, Ticket_price, Ticket_discription,Ticket_start_date, Ticket_end_date, Ticket_permitions) VALUES (@ID_Ticket, @ID_Coach, @Name_Customer, @SName_Customer ,@Ticket_type, @Ticket_price, @Ticket_discription, @Ticket_start_date, @Ticket_end_date, @Ticket_permitions)");
            command.Parameters.AddWithValue("ID_Ticket", ID_Ticket);
            command.Parameters.AddWithValue("ID_Coach", ID_Coach);
            command.Parameters.AddWithValue("Name_Customer", Name_Customer);
            command.Parameters.AddWithValue("SName_Customer", SName_Customer);
            command.Parameters.AddWithValue("Ticket_type", Ticket_type);
            command.Parameters.AddWithValue("Ticket_price", Ticket_price);
            command.Parameters.AddWithValue("Ticket_discription", Ticket_discription);
            command.Parameters.AddWithValue("Ticket_start_date", Ticket_start_date);
            command.Parameters.AddWithValue("Ticket_end_date", Ticket_end_date);
            command.Parameters.AddWithValue("Ticket_permitions", Ticket_permitions);

            return command;
        }

        /*public SqlCommand price()
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Ticket1] () VALUES ()");
            return command;
        }*/
        public SqlCommand update(string IDEntityToUpdate)
        {
            SqlCommand command = new SqlCommand($"UPDATE [Ticket1] SET ID_Customer_=@ID_Customer_1, ID_Coach_=@ID_Coach_1, ID_Adm_=@ID_Adm_1, Ticket_type=@Ticket_type1, Ticket_type=@Ticket_type1, Ticket_price=@Ticket_price1, Ticket_discription=@Ticket_discription1, Ticket_start_date=@Ticket_start_date1, Ticket_end_date=@Ticket_end_date1, Ticket_permitions=@Ticket_permitions1 WHERE ID_Ticket=@ID_Ticket1;");
            /*command.Parameters.AddWithValue("ID_Ticket1", ID_Ticket);
            command.Parameters.AddWithValue("ID_Customer_1", ID_Customer_);
            command.Parameters.AddWithValue("ID_Coach_1", ID_Coach_);
            command.Parameters.AddWithValue("ID_Adm_1", ID_Adm_);
            command.Parameters.AddWithValue("Ticket_type1", Ticket_type);
            command.Parameters.AddWithValue("Ticket_price1", Ticket_price);
            command.Parameters.AddWithValue("Ticket_discription1", Ticket_discription);
            command.Parameters.AddWithValue("Ticket_start_date1", Ticket_start_date);
            command.Parameters.AddWithValue("Ticket_end_date1", Ticket_end_date);
            command.Parameters.AddWithValue("Ticket_permitions1", Ticket_permitions);*/


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
