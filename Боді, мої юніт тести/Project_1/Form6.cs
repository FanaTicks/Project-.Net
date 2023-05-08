using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Form6 : Form
    {

        Data_Base dataBase = new Data_Base();

        public Form6()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();


            var addQuery = $"insert into Spending_User1(Date_Spending,Spending_,ComentSp) values('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}')";

            var command = new SqlCommand(addQuery, dataBase.getSqlConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Витрату додано!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataBase.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
