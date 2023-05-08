using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DB.Entities
{
    public interface IEntity2
    {
        SqlCommand insert2();
        SqlCommand update2(string IDEntityToUpdate);
        SqlCommand delete2();
    }
}
