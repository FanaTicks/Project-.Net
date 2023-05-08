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
    public partial class Coach : System.Windows.Forms.Form
    {
        public SqlConnection sqlConnection = null;
        public DBHandler dBHandler { get; set; }
        public Coach()
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
            this.coachTableAdapter.Fill(this.ZalDataSet.Coach);
            this.specialityTableAdapter.Fill(this.ZalDataSet.Speciality);
        }
       
        public bool delNew(IEnumerable<IEntity> entities, DBHandler dB)
        {
            return dB.Delete(entities);
        }
        
        //введення даних---------------------------------
        public bool addNew(IEnumerable<IEntity> entities, DBHandler dB)
        {
            return dB.insert(entities);
        }
        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                IEntity coach = new DB.Entities.Coach
                {
                    ID_Coach = textBoxIDCouch.Text,
                    ID_Speciality = comboBoxIDSpec.SelectedValue,
                    Coach_Login = textBoxLogCouch.Text,
                    Coach_Password = textBoxPassCouch.Text,
                    Coach_Name = textBoxNameCouch.Text,
                    Coach_Surname = textBoxSNameCouch.Text,
                    Coach_Phone = textBoxPhoneCouch.Text,
                    Coach_Post_adress = textBoxEMailCouch.Text,
                };
                addNew(new[] {coach}, dBHandler);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshInsertData_Click(object sender, EventArgs e)
        {
        this.coachTableAdapter.Fill(this.ZalDataSet.Coach);
        }
        //зміна даних-------------------------------
        public bool updateNew(IEntity entity, DBHandler dB, string entityToUpdateId)
        {
            return dB.update(entity, entityToUpdateId);
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                DB.Entities.Coach coach = new DB.Entities.Coach
                {
                    ID_Coach = comboBoxCUp.SelectedValue.ToString(),
                    ID_Speciality = comboBoxIDSPUp.SelectedValue,
                    Coach_Login = textBoxLogUP.Text,
                    Coach_Password = textBoxPassUP.Text,
                    Coach_Name = textBoxNameUP.Text,
                    Coach_Surname = textBoxSNameUP.Text,
                    Coach_Phone = textBoxPhoneUP.Text,
                    Coach_Post_adress = textBoxEMailUP.Text,

                };
                updateNew(coach, dBHandler, coach.ID_Coach);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshUpdateData_Click(object sender, EventArgs e)
        {
           this.coachTableAdapter.Fill(this.ZalDataSet.Coach);
        }
        //видалення даних---------------------------------------
        private void delButton_Click(object sender, EventArgs e)
        {
           try
            {
                IEntity coach = new DB.Entities.Coach
                {
                    ID_Coach = comboBoxCDell.SelectedValue.ToString(),
                };
                delNew(new[] { coach }, dBHandler);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshDelData_Click(object sender, EventArgs e)
        {
            this.coachTableAdapter.Fill(this.ZalDataSet.Coach);
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
        //cміття-----------------------------------------
        private void comboBoxIDSpec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void productDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
    }
}
