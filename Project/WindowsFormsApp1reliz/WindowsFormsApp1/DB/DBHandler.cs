using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DB.Entities;

namespace WindowsFormsApp1
{
    public class DBHandler
    {
        private SqlConnection sqlConnection;

        public DBHandler(SqlConnection sqlConnection)
        {
            this.sqlConnection = sqlConnection;
        }
        public bool Delete(IEnumerable<IEntity> entities)
        {
            try
            {
                IEnumerable<SqlCommand> commands = entities.Select(entity => entity.delete());
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


        public bool insert(IEnumerable<IEntity> entities)
        {
            try
            {
                IEnumerable<SqlCommand> commands = entities.Select(entity => entity.insert());
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
        /*public bool price(IEnumerable<IEntity> entities)
        {
            try
            {
                IEnumerable<SqlCommand> commands = entities.Select(entity => entity.price());
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
        }*/
        public bool update(IEntity entity, string entityToUpdateId)
        {
            try
            {
                SqlCommand command = entity.update(entityToUpdateId);
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
