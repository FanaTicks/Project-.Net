using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Project_1
{
    public class Autorization
    {
        Data_Base dataBase = new Data_Base();
        public string Name { get; set; }
        public string Pass { get; set; }

        public bool autoriz(string Name, string Pass)
        {
            Data_Base dataBase = new Data_Base();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select LoginUser, PassUser from User_ where LoginUser = '{Name}' and PassUser ='{Pass}'";
            SqlCommand command = new SqlCommand(querystring, dataBase.getSqlConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                return true;
            }
            else return false;
        }

    }
}
