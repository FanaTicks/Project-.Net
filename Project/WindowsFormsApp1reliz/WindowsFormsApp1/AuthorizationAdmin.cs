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
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Groop_Project_Proto
{

    
    public partial class AuthorizationAdmin : System.Windows.Forms.Form
    {
        Data_Base database = new Data_Base();

        public AuthorizationAdmin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AuthorizationAdmin_Load(object sender, EventArgs e)
        {
            textBoxPass.PasswordChar = '●';
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            Data_Base dataBase = new Data_Base();

            var loginUser = textBoxLog.Text;
            var passUser = textBoxPass.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            //запит на вибірку логіну та паролю
            string querystring = $"select Adm_Login, Adm_Pass from Administrator where Adm_Login = '{loginUser}' and Adm_Pass ='{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getSqlConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Авторизація виконана!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main frm4 = new Main();
                this.Hide();
                frm4.ShowDialog();
                this.Show();
                //Close();

            }
            else//якщо такого користувача не існує тоді виведе помилку
            {
                MessageBox.Show("Введеного акаунту не існує!", "Акаунт не існує!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabelReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationAdmin frm__ = new RegistrationAdmin();
            this.Hide();
            frm__.ShowDialog();
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
