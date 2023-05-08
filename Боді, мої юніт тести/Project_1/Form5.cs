using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Project_1
{
    public partial class Form5 : Form
    {
        Data_Base dataBase = new Data_Base();

        public Form5()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            /*var date = textBox1.Text;
            var profit = textBox2.Text;
            var coment = textBox3.Text;*/

            var addQuery = $"insert into Profit_User1(Date_Profit,Profit_,ComentPr) values('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}')";

            var command = new SqlCommand(addQuery, dataBase.getSqlConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Прибуток додано!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataBase.closeConnection();
        }
    }
}
