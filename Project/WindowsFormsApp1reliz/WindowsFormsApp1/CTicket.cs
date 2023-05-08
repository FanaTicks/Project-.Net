using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.DB.Entities;

namespace WindowsFormsApp1
{
    public partial class CTicket : System.Windows.Forms.Form
    {
        public SqlConnection sqlConnection = null;
        public DBHandler dBHandler { get; set; }
        public CTicket()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            labelSDIn.Text = DateTime.Now.ToString("dd.MM.yyyy");
            labelSDUP.Text = DateTime.Now.ToString("dd.MM.yyyy");
            textBoxEndDateUp.Text = DateTime.Now.ToString("dd.MM.yyyy");
            textBoxEDIn.Text = DateTime.Now.ToString("dd.MM.yyyy");
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zalDataSet.Speciality". При необходимости она может быть перемещена или удалена.
            this.specialityTableAdapter.Fill(this.zalDataSet.Speciality);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "abonement._Abonement". При необходимости она может быть перемещена или удалена.
            this.abonementTableAdapter.Fill(this.abonement._Abonement);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ticket1._Ticket". При необходимости она может быть перемещена или удалена.
            this.ticketTableAdapter.Fill(this.ticket1._Ticket);
            this.coachTableAdapter.Fill(this.zalDataSet.Coach);
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ticket._Ticket". При необходимости она может быть перемещена или удалена.
            //this.ticketTableAdapter.Fill(this.ticket._Ticket);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ticket._Ticket". При необходимости она может быть перемещена или удалена.
            //this.ticketTableAdapter.Fill(this.ticket._Ticket);
            //this.ticket1TableAdapter.Fill(this.zalDataSet.Ticket1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zalDataSet.Administrator". При необходимости она может быть перемещена или удалена.
            //this.administratorTableAdapter.Fill(this.zalDataSet.Administrator);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zalDataSet.Coach". При необходимости она может быть перемещена или удалена.
            //this.coachTableAdapter.Fill(this.zalDataSet.Coach);

        }

        
        
        //введення даних---------------------------------
        public bool addNew(IEnumerable<IEntity> entities, DBHandler dB)
        {
            return dB.insert(entities);
        }
        private void insertButton_Click(object sender, EventArgs e)
        {
            //розраховує кількість---------------------
            int x = Convert.ToInt32(0);
            int First = Convert.ToInt32(comboBoxPriceIn.Text);
            int Second = Convert.ToInt32(textBox5.Text);
            int Sum1 = First * Second;
            textBox6.Text = Convert.ToString(Sum1);
            try
            {
                IEntity card = new DB.Entities.Card
                {
                    ID_Ticket = textBoxIDTIN.Text,
                    ID_Coach = comboBoxIDCoachIN.Text,
                    Name_Customer = textBoxNameCustIN.Text,
                    SName_Customer = textBoxSNameCustIN.Text,
                    Ticket_type = comboBoxTypeIN.Text,
                    Ticket_price = textBox6.Text,
                    Ticket_discription = textBoxDescIN.Text,
                    Ticket_start_date = labelSDIn.Text,
                    Ticket_end_date = textBoxEDIn.Text,
                    Ticket_permitions = textBox1.Text,
                };
                addNew(new[] { card }, dBHandler);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void refreshInsertData_Click(object sender, EventArgs e)
        {
            this.ticketTableAdapter.Fill(this.ticket1._Ticket);
        }
        //зміна даних-------------------------------
        public bool updateNew(IEntity entity, DBHandler dB, string entityToUpdateId)
        {
            return dB.update(entity, entityToUpdateId);
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            //розраховує кількість---------------------
            int x = Convert.ToInt32(0);
            int First = Convert.ToInt32(comboBoxPriceUp.Text);
            int Second = Convert.ToInt32(textBox8.Text);
            int Sum1 = First * Second;
            textBox7.Text = Convert.ToString(Sum1);
            try
            {
                DB.Entities.Card card = new DB.Entities.Card
                {
                    ID_Ticket = comboBoxIDUP.SelectedValue.ToString(),
                    ID_Coach = comboBoxIdCouchUP.Text,
                    Name_Customer = textBox3.Text,
                    SName_Customer = textBox2.Text,
                    Ticket_type = comboBoxTypeUp.Text,
                    Ticket_price = textBox7.Text,
                    Ticket_discription = textBoxDescrUP.Text,
                    Ticket_start_date = labelSDUP.Text,
                    Ticket_end_date = textBoxEndDateUp.Text,
                    Ticket_permitions = textBoxUP.Text,

                };
                updateNew(card, dBHandler, card.ID_Ticket);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshUpdateData_Click(object sender, EventArgs e)
        {
            this.ticketTableAdapter.Fill(this.ticket1._Ticket);
        }
        //видалення даних---------------------------------------
        public bool delNew(IEnumerable<IEntity> entities, DBHandler dB)
        {
            return dB.Delete(entities);
        }
        private void delButton_Click(object sender, EventArgs e)
        {
          try
            {
                IEntity card = new DB.Entities.Card
                {
                    ID_Ticket = comboBoxCDell.SelectedValue.ToString(),
                };
                delNew(new[] { card }, dBHandler);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshDelData_Click(object sender, EventArgs e)
        {
            this.ticketTableAdapter.Fill(this.ticket1._Ticket);
            
        }

        //cміття-----------------------------------------

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PayTicket frm5 = new PayTicket();
            frm5.ShowDialog();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Privat24 frm5 = new Privat24();
            frm5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PayCash frm5 = new PayCash();
            frm5.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
