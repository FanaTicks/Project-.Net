using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public class Add_del_info
    {
        Data_Base dataBase = new Data_Base();

        public bool NewProfit(string ID_Profit, string Date_Profit, string Profit_, string ComentPr)
        {
            Data_Base dataBase = new Data_Base();
            dataBase.openConnection();
            var id = ID_Profit;
            var date = Date_Profit;
            var profit = Profit_;
            var coment = ComentPr;
            if (String.IsNullOrEmpty(id))
            {
                if (String.IsNullOrEmpty(date))
                {
                    if (String.IsNullOrEmpty(profit))
                    {
                        if (String.IsNullOrEmpty(coment))
                        {
                            return false;
                        }
                        return false;
                    }
                    return false;
                }
                return false;
            
            }
            else
            {
                var addQuery = $"insert into Profit_User2(ID_Profit,Date_Profit,Profit_,ComentPr) values('{id}','{date}','{profit}','{coment}')";
                var command = new SqlCommand(addQuery, dataBase.getSqlConnection());
                command.ExecuteNonQuery();
                dataBase.closeConnection();
                return true;
            }
        }

        public bool Deletedgrinh(string ID_Profit)
        {
            Data_Base dataBase = new Data_Base();
            dataBase.openConnection();
            var id1 = ID_Profit;
            var addQuery = $"delete from Profit_User2 where ID_Profit = '{id1}'";
            var command = new SqlCommand(addQuery, dataBase.getSqlConnection());
            command.ExecuteNonQuery();
            dataBase.closeConnection();
            return true;
        }

        public bool ChengeProfitData(string ID_Profit, string Date_Profit, string Profit_, string ComentPr) 
        {
            Data_Base dataBase = new Data_Base();
            dataBase.openConnection();
            var id = ID_Profit;
            var date = Date_Profit;
            var profit = Profit_;
            var coment = ComentPr;

            if (String.IsNullOrEmpty(id))
            {
                if (String.IsNullOrEmpty(date))
                {
                    if (String.IsNullOrEmpty(profit))
                    {
                        if (String.IsNullOrEmpty(coment))
                        {
                            return false;
                        }
                        return false;
                    }
                    return false;
                }
                return false;
            }
            else
            {
                var changeQuery = $"update Profit_User2 set  Date_Profit = '{date}',Profit_ = '{profit}',ComentPr = '{coment}' where ID_Profit = '{id}'";
                var command = new SqlCommand(changeQuery, dataBase.getSqlConnection());
                command.ExecuteNonQuery();
                dataBase.closeConnection();
                return true;
            }
        }
    }
}
