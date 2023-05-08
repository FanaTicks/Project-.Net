using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project_1
{
    internal class Data_Base
    {
        SqlConnection sqlConnection =  new SqlConnection(@"Data Source=DESKTOP-G082NTP\MSSQLSERVER02; Initial Catalog=TCPP_Projecr; integrated Security=True");

        public void openConnection() {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) 
            { 
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getSqlConnection() 
        {
            return sqlConnection;        
        }
            

    }
}
