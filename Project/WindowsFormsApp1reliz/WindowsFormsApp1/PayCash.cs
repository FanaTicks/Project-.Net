using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DB.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class PayCash : Form
    {
        public SqlConnection sqlConnection = null;
        public DBHandler dBHandler { get; set; }
        public PayCash()
        {
            StartPosition = FormStartPosition.CenterScreen;
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.ZalConnectionString"].ConnectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                //MessageBox.Show("Підключення до БД встановлено!");
            }
            dBHandler = new DBHandler(sqlConnection);
            InitializeComponent();
        }
        public bool updateNew(IEntity entity, DBHandler dB, string entityToUpdateId)
        {
            return dB.update(entity, entityToUpdateId);
        }

        private void PayCash_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ticket._Ticket". При необходимости она может быть перемещена или удалена.
            this.ticketTableAdapter.Fill(this.ticket._Ticket);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DB.Entities.Pay pay = new DB.Entities.Pay
                {
                    ID_Ticket = comboBox1.SelectedValue.ToString(),
                    Ticket_permitions = textBox1.Text,

                };
                updateNew(pay, dBHandler, pay.ID_Ticket);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Form2 frm3 = new Form2();
            frm3.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
             //розраховує кількість---------------------
            int x = Convert.ToInt32(0);
            int First = Convert.ToInt32(comboBox4.Text);
            int Second = Convert.ToInt32(textBox2.Text);
            int Sum1 = First - Second;
            textBox3.Text = Convert.ToString(Sum1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*PayTicket frm3 = new PayTicket();
            frm3.ShowDialog();*/
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CTicket frm3 = new CTicket();
            frm3.ShowDialog();
            Close();
        }
    }
}
