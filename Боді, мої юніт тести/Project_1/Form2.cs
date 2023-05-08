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
    public partial class Form2 : Form
    {
        Data_Base dataBase = new Data_Base();
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data_Base dataBase = new Data_Base();
            //Зчитування значення з textBox
            var name = textBox1.Text;
            var surname = textBox2.Text;
            var login = textBox3.Text;
            var pass = textBox4.Text;
            //Запрос на додаванння нового користувача
            string querystring = $"insert into User_(NameUser,SurNameUser,LoginUser,PassUser) values('{name}','{surname}','{login}','{pass}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getSqlConnection());
            dataBase.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Акаунт стврено!", "Успіх!");
                Form1 frm_login = new Form1();
                this.Hide();
                frm_login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Акаунт не стврено!", "Помилка!");
            }
            dataBase.closeConnection();
        }

        //Перевірка та не чи існує вже такий користувач
        private Boolean checkuser()
        {
            var loginUser = textBox3.Text;
            var passUser = textBox4.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select Login_KL, Pass_KL from User_KL where Login_KL = '{loginUser}' and Pass_KL ='{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getSqlConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Користувач вже існує");
                return true;
            }
            else
            {
                return false;
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
           
            Form1 frm_login = new Form1();
            this.Hide();
            frm_login.ShowDialog();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
