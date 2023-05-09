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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Castomer : System.Windows.Forms.Form
    {
        public SqlConnection sqlConnection = null;
        public DBHandler dBHandler { get; set; }
        public Castomer()
        {
            StartPosition = FormStartPosition.CenterScreen;
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.DaniilZotin"].ConnectionString);
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
            this.customerTableAdapter.Fill(this.ZalDataSet.Customer);     
        }
        
        //додати нового користувача-----
        public bool addNew(IEnumerable<IEntity> entities, DBHandler dB)
        {
            return dB.insert(entities);
        }
        private void insertButton_Click(object sender, EventArgs e)
        {
           try
            {
                IEntity customer = new Customer
                {
                    ID_Customer = textBoxIDCastIN.Text,
                    Customer_name = textBoxNameCustIN.Text,
                    Customer_surname = textBoxSNameCustIN.Text,
                    Customer_Phone = textBoxPhoneCustIN.Text,
                    Customer_Post_Adres = textBoxEMailCustIN.Text,
                };
                addNew(new[] { customer }, dBHandler);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshInsertData_Click(object sender, EventArgs e)
        {
            this.customerTableAdapter.Fill(this.ZalDataSet.Customer);
        }

        //змінити дані користувача-----------------------------
        public bool updateNew(IEntity entity, DBHandler dB, string entityToUpdateId)
        {
            return dB.update(entity, entityToUpdateId);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            try
            {
                Customer customer = new Customer
                {
                    ID_Customer = comboBoxCustUP.SelectedValue.ToString(),
                    Customer_name = textBoxNameCustUP.Text,
                    Customer_surname = textBoxSNameCustUP.Text,
                    Customer_Phone = textBoxPhoneCustUP.Text,
                    Customer_Post_Adres = textBoxEMailCustUP.Text,

                };
                updateNew(customer, dBHandler, customer.ID_Customer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshUpdateData_Click(object sender, EventArgs e)
        {
            this.customerTableAdapter.Fill(this.ZalDataSet.Customer);
        }
        //видалити дані користувача----------------------------------------

        public bool delNew(IEnumerable<IEntity> entities, DBHandler dB)
        {
            return dB.Delete(entities);
        }
        private void delButton_Click(object sender, EventArgs e)
        {
           try
            {
                IEntity customer = new Customer
                {
                    ID_Customer = comboBox4.SelectedValue.ToString(),
                };
                delNew(new[] { customer }, dBHandler);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshDelData_Click(object sender, EventArgs e)
        {
            this.customerTableAdapter.Fill(this.ZalDataSet.Customer);
        }
       

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.specialityTableAdapter.FillBy(this.ZalDataSet.Speciality);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.specialityTableAdapter.FillBy1(this.ZalDataSet.Speciality);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        //сміття-----------------------------
        private void comboBoxIDSpec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
