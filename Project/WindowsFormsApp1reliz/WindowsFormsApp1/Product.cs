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
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Product : System.Windows.Forms.Form
    {
        Data_Base dataBase = new Data_Base();
        //int selectedRow;

        public SqlConnection sqlConnection = null;
        public DBHandler dBHandler { get; set; }
        public Product()
        {
            StartPosition = FormStartPosition.CenterScreen;
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.DaniilZotin"].ConnectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
               MessageBox.Show("Підключення до БД встановлено!");
            }
            dBHandler = new DBHandler(sqlConnection);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "groop_Project_DataSet1.Basket". При необходимости она может быть перемещена или удалена.
            //this.basketTableAdapter2.Fill(this.groop_Project_DataSet1.Basket);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "basketDataSet1.Basket". При необходимости она может быть перемещена или удалена.
            this.basketTableAdapter1.Fill(this.basketDataSet1.Basket);
            label20.Text = DateTime.Now.ToString("yyyy.MM.dd,HH.mm");
            // TODO: данная строка кода позволяет загрузить данные в таблицу "basketDataSet.Basket". При необходимости она может быть перемещена или удалена.
            //this.basketTableAdapter.Fill(this.basketDataSet.Basket);

            this.productTableAdapter2.Fill(this.zalDataSet.Product);
            /*CreateColums();
            RefreshDataGrid(dataGridViewBasket);*/

        }
        public bool addNew(IEnumerable<IEntity> entities, DBHandler dB) {
           return dB.insert(entities);
        }
        public bool delNew(IEnumerable<IEntity> entities, DBHandler dB)
        {
            return dB.Delete(entities);
        }
        public bool updateNew(IEntity entity, DBHandler dB, string entityToUpdateId)
        {
            return dB.update(entity, entityToUpdateId);
        }
        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                IEntity product = new DB.Entities.Product
                {
                    ID_Product = textBox1.Text,
                    Product_name = textBox2.Text,
                    Product_cost = textBox3.Text,
                    Product_description = textBox4.Text,
                    Product_quantity = textBox5.Text,
                    
                };
                addNew(new[] {product}, dBHandler);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshInsertData_Click(object sender, EventArgs e)
        {
            this.productTableAdapter2.Fill(this.zalDataSet.Product);
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                DB.Entities.Product product = new DB.Entities.Product
                {
                    ID_Product = comboBox2.SelectedValue.ToString(),
                    Product_name = textBox9.Text,
                    Product_cost = textBox8.Text,
                    Product_description = textBox7.Text,
                    Product_quantity = textBox6.Text,
                    
                };
                updateNew(product, dBHandler, product.ID_Product);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshUpdateData_Click(object sender, EventArgs e)
        {
            this.productTableAdapter2.Fill(this.zalDataSet.Product);
        }

        private void delButton_Click(object sender, EventArgs e)
        {
           try
            {
                IEntity product = new DB.Entities.Product
                {
                    ID_Product = comboBox4.SelectedValue.ToString(),
                };
                delNew(new[] { product }, dBHandler);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshDelData_Click(object sender, EventArgs e)
        {
            this.productTableAdapter2.Fill(this.zalDataSet.Product);
        }
        //продаж------------------------------
        /*private void CreateColums()
        {
            dataGridViewBasket.Columns.Add("ID_Product_", "Код продукту");
            dataGridViewBasket.Columns.Add("Product_name_", "Назва продукту");
            dataGridViewBasket.Columns.Add("Product_description_", "Опис продукту (Т)");
            dataGridViewBasket.Columns.Add("Product_cost_", "Загальна ціна (Грн)");
            dataGridViewBasket.Columns.Add("Product_quantity_", "Кількість (Шт)");
            dataGridViewBasket.Columns.Add("IsNew", String.Empty);

        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetFloat(3), record.GetFloat(4), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Basket ";

            SqlCommand comand = new SqlCommand(queryString, dataBase.getSqlConnection());

            dataBase.openConnection();

            SqlDataReader reader = comand.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

        }*/

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBasketIN_Click(object sender, EventArgs e)
        {
            //розраховує кількість---------------------
            int x = Convert.ToInt32(0);
            int First = Convert.ToInt32(comboBoxQPr.Text);
            int Second = Convert.ToInt32(textBoxQPrIN.Text);
            int Sum1 = First - Second;
            textBoxQPrINProd.Text = Convert.ToString(Sum1);
            //textBox11.Text = Convert.ToString(x);
            //розраховує ціну-----------------------------
            int x1 = Convert.ToInt32(0);
            int First1 = Convert.ToInt32(textBoxQPrIN.Text);
            int Second1 = Convert.ToInt32(comboBoxCostPr.Text);
            int Sum2 = First1 * Second1;
            textBoxPriceBask.Text = Convert.ToString(Sum2);
            //textBox11.Text = Convert.ToString(x);
            try
            {
                IEntity basket = new DB.Entities.Basket
                {
                    ID_Product_ = comboBoxIDPr.Text,
                    Product_name_ = comboBoxNamePr.Text,
                    Product_cost_ = textBoxPriceBask.Text,
                    Product_description_ = comboBoxDescPr.Text,
                    Product_quantity_ = textBoxQPrIN.Text,
                    Basket_time = label20.Text,


                };
                addNew(new[] { basket }, dBHandler);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                DB.Entities.Product product = new DB.Entities.Product
                {
                    ID_Product = comboBoxIDPr.SelectedValue.ToString(),
                    Product_name = comboBoxNamePr.Text,
                    Product_cost = comboBoxCostPr.Text,
                    Product_description = comboBoxDescPr.Text,
                    Product_quantity = textBoxQPrINProd.Text,

                };
                updateNew(product, dBHandler, product.ID_Product);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void buttonBuketUP_Click(object sender, EventArgs e)
        {
            //RefreshDataGrid(dataGridViewBasket);
            this.basketTableAdapter1.Fill(this.basketDataSet1.Basket);
            this.productTableAdapter2.Fill(this.zalDataSet.Product);
            
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
                connect.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDellBask_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(0);
            int First = Convert.ToInt32(comboBoxQPr.Text);
            int Second = Convert.ToInt32(comboBox1.Text);
            int Sum1 = First + Second;
            textBoxQPrINProd.Text = Convert.ToString(Sum1);
            //textBox11.Text = Convert.ToString(x);
            try
            {
                IEntity basket = new DB.Entities.Basket
                {
                    ID_Product_ = comboBoxIDPr.SelectedValue.ToString(),
                };
                delNew(new[] { basket }, dBHandler);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                DB.Entities.Product product = new DB.Entities.Product
                {
                    ID_Product = comboBoxIDPr.SelectedValue.ToString(),
                    Product_name = comboBoxNamePr.Text,
                    Product_cost = comboBoxCostPr.Text,
                    Product_description = comboBoxDescPr.Text,
                    Product_quantity = textBoxQPrINProd.Text,

                };
                updateNew(product, dBHandler, product.ID_Product);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUPBasket_Click(object sender, EventArgs e)
        {

            int x = Convert.ToInt32(0);
            int First = Convert.ToInt32(comboBoxQPr.Text);
            int Second = Convert.ToInt32(textBoxQPrIN.Text);
            int Thert = Convert.ToInt32(comboBox1.Text);
            int Sum1 = (First + Thert) - Second;
            textBoxQPrINProd.Text = Convert.ToString(Sum1);
            //textBox11.Text = Convert.ToString(x);

            int x1 = Convert.ToInt32(0);
            int First1 = Convert.ToInt32(textBoxQPrIN.Text);
            int Second1 = Convert.ToInt32(comboBoxCostPr.Text);
            int Sum2 = First1 * Second1;
            textBoxPriceBask.Text = Convert.ToString(Sum2);
            try
            {
                DB.Entities.Basket basket = new DB.Entities.Basket
                {
                    ID_Product_ = comboBoxIDPr.Text,
                    Product_name_ = comboBoxNamePr.Text,
                    Product_cost_ = textBoxPriceBask.Text,
                    Product_description_ = comboBoxDescPr.Text,
                    Product_quantity_ = textBoxQPrIN.Text,
                    Basket_time = label20.Text,

                };
                updateNew(basket, dBHandler, basket.ID_Product_);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                DB.Entities.Product product = new DB.Entities.Product
                {
                    ID_Product = comboBoxIDPr.SelectedValue.ToString(),
                    Product_name = comboBoxNamePr.Text,
                    Product_cost = comboBoxCostPr.Text,
                    Product_description = comboBoxDescPr.Text,
                    Product_quantity = textBoxQPrINProd.Text,

                };
                updateNew(product, dBHandler, product.ID_Product);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Splata1 frm5 = new Splata1();
            frm5.ShowDialog();
            Close();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-G082NTP\MSSQLSERVER02; Initial Catalog=Groop_Project_; integrated Security=True");
        string stNameDB = "SumProduct";
        DataSet set = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommandBuilder command = new SqlCommandBuilder();
        BindingSource source;

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonExitIN_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BankCart frm2 = new BankCart();
            frm2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cash frm1 = new Cash();
            frm1.ShowDialog();
        }
    }
}
