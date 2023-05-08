using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DB.Entities;

namespace WindowsFormsApp1.DB
{
    internal class DBCust
    {
        private SqlConnection sqlConnection;

        public DBCust(SqlConnection sqlConnection)
        {
            this.sqlConnection = sqlConnection;
        }
        public bool deleteCust(IEnumerable<IEntityCust> entities)
        {
            try
            {
                IEnumerable<SqlCommand> commands = entities.Select(entity => entity.deleteCust());
                foreach (var command in commands)
                {
                    command.Connection = sqlConnection;
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool insertCust(IEnumerable<IEntityCust> entities)
        {
            try
            {
                IEnumerable<SqlCommand> commands = entities.Select(entity => entity.insertCust());
                foreach (var command in commands)
                {
                    command.Connection = sqlConnection;
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateCust(IEntityCust entity, string entityToUpdateId)
        {
            try
            {
                SqlCommand command = entity.updateCust(entityToUpdateId);
                command.Connection = sqlConnection;
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

