﻿using Microsoft.Reporting.Map.WebForms.BingMaps;
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
    
    public partial class Cash : System.Windows.Forms.Form
    {
        public SqlConnection sqlConnection = null;
        public DBHandler dBHandler { get; set; }
        public Cash()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.ZalConnectionString"].ConnectionString);
            sqlConnection.Open();
            /*if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Підключення до БД встановлено!");
            }*/
            dBHandler = new DBHandler(sqlConnection);
            
        }
        public bool delNew(IEnumerable<IEntity> entities, DBHandler dB)
        {
            return dB.Delete(entities);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            
            
        }

        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-G082NTP\MSSQLSERVER02; Initial Catalog=Groop_Project_; integrated Security=True");
        string stNameDB = "EndSumProduct";
        DataSet set = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommandBuilder command = new SqlCommandBuilder();
        BindingSource source;

        private void Cash_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "basketDataSet.Basket". При необходимости она может быть перемещена или удалена.
            this.basketTableAdapter.Fill(this.basketDataSet.Basket);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "basketDataSet.SumProduct". При необходимости она может быть перемещена или удалена.
            //this.sumProductTableAdapter.Fill(this.basketDataSet.SumProduct);
            string connectq = @"Data Source=DESKTOP-G082NTP\MSSQLSERVER02; Initial Catalog=Groop_Project_; integrated Security=True";
            using (SqlConnection connect = new SqlConnection(connectq))
            {
                connect.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(stNameDB, connect);
                adapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);
                DataSet set = new DataSet();
                adapter.Fill(set, "qwe");
                source = new BindingSource(set, "qwe");
                dataGridView3.DataSource = source;
                //source = textBox3.Text;
                connect.Close();
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //розраховує здачу---------------------
            int x = Convert.ToInt32(0);
            int First = Convert.ToInt32(textBox3.Text);
            int Second = Convert.ToInt32(textBox1.Text);
            int Sum1 = First - Second;
            textBox2.Text = Convert.ToString(Sum1);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            try
            {
                IEntity basket1 = new DB.Entities.Basket1
                {
                    ID_Product_ = comboBox4.SelectedValue.ToString(),
                };
                delNew(new[] { basket1 }, dBHandler);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            Form2 frm5 = new Form2();
            frm5.ShowDialog();

            string connectq = @"Data Source=DESKTOP-G082NTP\MSSQLSERVER02; Initial Catalog=Groop_Project_; integrated Security=True";
            using (SqlConnection connect = new SqlConnection(connectq))
            {
                connect.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(stNameDB, connect);
                adapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);
                DataSet set = new DataSet();
                adapter.Fill(set, "qwe");
                source = new BindingSource(set, "qwe");
                dataGridView3.DataSource = source;
                //source = textBox3.Text;
                connect.Close();
            }
        }

        private void buttonDellSel_Click(object sender, EventArgs e)
        {
            /*try
            {
                IEntity basket1 = new DB.Entities.Basket1
                {
                    ID_Product_ = comboBox4.SelectedValue.ToString(),
                };
                delNew(new[] { basket1 }, dBHandler);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();*/
        }
    }
}