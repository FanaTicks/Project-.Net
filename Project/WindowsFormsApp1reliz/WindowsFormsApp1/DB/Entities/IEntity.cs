using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DB.Entities
{
    public interface IEntity
    {
        SqlCommand insert();
        //SqlCommand price();
        SqlCommand update(string IDEntityToUpdate);
        SqlCommand delete();
    }
}
