using System;
using System.Data.SqlClient;

namespace WindowsFormsApp1.DB.Entities
{
    public interface ICoach : IEntity
    {
        string ID_Coach { get; set; }
        object ID_Speciality { get; set; }
        string Coach_Login { get; set; }
        string Coach_Password { get; set; }
        string Coach_Name { get; set; }
        string Coach_Surname { get; set; }
        string Coach_Phone { get; set; }
        string Coach_Post_adress { get; set; }
       
    }


    public class Coach : ICoach
    {
        private string id_couch;
        private string couch_name;
        private string couch_sname;
        private string couch_login;
        private string couch_pass;
        private string couch_phone;
        private string couch_post_adres;

        public string ID_Coach { get => id_couch; set => id_couch = Validate(value, nameof(ID_Coach)); }
        public object ID_Speciality { get; set; }
        public string Coach_Login { get => couch_login ; set => couch_login = Validate(value, nameof(couch_login)); }
        public string Coach_Password { get => couch_pass; set => couch_pass = Validate(value, nameof(couch_pass)); }
        public string Coach_Name { get => couch_name; set => couch_name = Validate(value, nameof(couch_name)); }
        public string Coach_Surname { get => couch_sname; set => couch_sname = Validate(value, nameof(couch_sname)); }
        public string Coach_Phone { get => couch_phone; set => couch_phone = Validate(value, nameof(couch_phone)); }
        public string Coach_Post_adress { get => couch_post_adres; set => couch_post_adres = Validate(value, nameof(couch_post_adres)); }


        public SqlCommand delete()
        {
            SqlCommand command = new SqlCommand($"DELETE FROM [Coach] WHERE ID_Coach=@ID_Coach2; ");
            command.Parameters.AddWithValue("ID_Coach2", ID_Coach);
            return command;
        }

        public SqlCommand insert()
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Coach] (ID_Coach, ID_Speciality, Coach_Login, Coach_Password, Coach_Name, Coach_Surname, Coach_Phone,Coach_Post_adress) VALUES (@ID_Coach, @ID_Speciality, @Coach_Login, @Coach_Password, @Coach_Name, @Coach_Surname, @Coach_Phone, @Coach_Post_adress)");
            command.Parameters.AddWithValue("ID_Coach", ID_Coach);
            command.Parameters.AddWithValue("ID_Speciality", ID_Speciality);
            command.Parameters.AddWithValue("Coach_Login", Coach_Login);
            command.Parameters.AddWithValue("Coach_Password", Coach_Password);
            command.Parameters.AddWithValue("Coach_Name", Coach_Name);
            command.Parameters.AddWithValue("Coach_Surname", Coach_Surname);
            command.Parameters.AddWithValue("Coach_Phone", Coach_Phone);
            command.Parameters.AddWithValue("Coach_Post_adress", Coach_Post_adress);


            return command;
        }

        public SqlCommand price()
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Coach] () VALUES ()");
            return command;
        }
        public SqlCommand update(string IDEntityToUpdate)
        {
            SqlCommand command = new SqlCommand($"UPDATE [Coach] SET ID_Speciality=@ID_Speciality1, Coach_Login=@Coach_Login1, Coach_Password=@Coach_Password1, Coach_Name=@Coach_Name1, Coach_Surname=@Coach_Surname1, Coach_Phone=@Coach_Phone1, Coach_Post_adress=@Coach_Post_adress1 WHERE ID_Coach=@ID_Coach1;");
            command.Parameters.AddWithValue("ID_Coach1", IDEntityToUpdate);
            command.Parameters.AddWithValue("ID_Speciality1", ID_Speciality);
            command.Parameters.AddWithValue("Coach_Login1", Coach_Login);
            command.Parameters.AddWithValue("Coach_Password1", Coach_Password);
            command.Parameters.AddWithValue("Coach_Name1", Coach_Name);
            command.Parameters.AddWithValue("Coach_Surname1", Coach_Surname);
            command.Parameters.AddWithValue("Coach_Phone1", Coach_Phone);
            command.Parameters.AddWithValue("Coach_Post_adress1", Coach_Post_adress);

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
