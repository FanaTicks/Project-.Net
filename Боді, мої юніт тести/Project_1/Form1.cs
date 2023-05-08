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
    public partial class Form1 : Form
    {
        Data_Base dataBase = new Data_Base();

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

       

       

        private void button1_Click(object sender, EventArgs e)
        {
            Data_Base dataBase = new Data_Base();

            var loginUser = textBox1.Text;
            var passUser = textBox2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            //запит на вибірку логіну та паролю
            string querystring = $"select LoginUser, PassUser from User_ where LoginUser = '{loginUser}' and PassUser ='{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getSqlConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Авторизація виконана!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form4 frm4 = new Form4();
                this.Hide();
                frm4.ShowDialog();
                this.Show();

            }
            else//якщо такого користувача не існує тоді виведе помилку
            {
                MessageBox.Show("Введеного акаунту не існує!", "Акаунт не існує!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '●';
            textBox1.MaxLength = 20;
            textBox2.MaxLength = 20;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Form2 frm__ = new Form2();
            this.Hide();
            frm__.ShowDialog();
      
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

