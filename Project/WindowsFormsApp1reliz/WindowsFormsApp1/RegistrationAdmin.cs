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

namespace Groop_Project_Proto
{
    public partial class RegistrationAdmin : System.Windows.Forms.Form
    {
        Data_Base dataBase = new Data_Base();
        public RegistrationAdmin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void RegistrationAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AuthorizationAdmin frm__ = new AuthorizationAdmin();
            this.Hide();
            frm__.ShowDialog();
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data_Base dataBase = new Data_Base();
            //Зчитування значення з textBox
            var id = textBox1.Text;
            var name = textBoxName.Text;
            var surname = textBoxSurName.Text;
            var phone = textBoxPhone.Text;
            var email = textBoxEMail.Text;
            var login = textBoxLogin.Text;
            var pass = textBoxPas.Text;
            //Запрос на додаванння нового користувача
            string querystring = $"insert into Administrator(ID_Adm,Adm_Name,Adm_SName,Adm_Phone,Adm_Post_Adres,Adm_Login,Adm_Pass) values('{id}','{name}','{surname}','{phone}','{email}','{login}','{pass}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getSqlConnection());
            dataBase.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Акаунт стврено!", "Успіх!");
                AuthorizationAdmin frm_login = new AuthorizationAdmin();
                this.Hide();
                frm_login.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Акаунт не стврено!", "Помилка!");
            }
            dataBase.closeConnection();
        }
    }
}
