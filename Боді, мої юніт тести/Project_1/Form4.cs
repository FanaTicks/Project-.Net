using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted 
    }

   
    public partial class Form4 : Form
    {

        Data_Base dataBase = new Data_Base();
        int selectedRow;

        public Form4()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColums()
        {
            dataGridView1.Columns.Add("ID_Profit", "Код прибутку");
            dataGridView1.Columns.Add("Date_Profit", "Дата");
            dataGridView1.Columns.Add("Profit_", "Прибуток");
            dataGridView1.Columns.Add("ComentPr", "Коментарі");
            dataGridView1.Columns.Add("IsNew", String.Empty);

        }

        private void CreateColums1()
        {
            dataGridView2.Columns.Add("ID_Spending", "Код витрати");
            dataGridView2.Columns.Add("Date_Spending", "Дата");
            dataGridView2.Columns.Add("Spending_", "Витрати");
            dataGridView2.Columns.Add("ComentSp", "Коментарі");
            dataGridView2.Columns.Add("IsNew", String.Empty);

        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), RowState.ModifiedNew);
        }

        private void ReadSingleRow1(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Profit_User1";

            SqlCommand comand = new SqlCommand(queryString, dataBase.getSqlConnection());

            dataBase.openConnection();

            SqlDataReader reader = comand.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

        }

        private void RefreshDataGrid1(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Spending_User1";

            SqlCommand comand = new SqlCommand(queryString, dataBase.getSqlConnection());

            dataBase.openConnection();

            SqlDataReader reader = comand.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow1(dgw, reader);
            }
            reader.Close();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tCPP_ProjecrDataSet.Profit_User". При необходимости она может быть перемещена или удалена.
            //this.profit_UserTableAdapter.Fill(this.tCPP_ProjecrDataSet.Profit_User);
            CreateColums();
            RefreshDataGrid(dataGridView1);
            CreateColums1();
            RefreshDataGrid1(dataGridView2);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox7.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RefreshDataGrid1(dataGridView2);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];

                textBox8.Text = row.Cells[0].Value.ToString();
                textBox4.Text = row.Cells[1].Value.ToString();
                textBox5.Text = row.Cells[2].Value.ToString();
                textBox6.Text = row.Cells[3].Value.ToString();

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.ShowDialog();
        }


        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Profit_User1 where concat (ID_Profit, Date_Profit, Profit_, ComentPr) like '%" + textBox9.Text + "%' ";

            SqlCommand com = new SqlCommand(searchString, dataBase.getSqlConnection());

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        }


        private void Search1(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Spending_User1 where concat (ID_Spending, Date_Spending, Spending_, ComentSp) like '%" + textBox10.Text + "%' ";

            SqlCommand com = new SqlCommand(searchString, dataBase.getSqlConnection());

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow1(dgw, read);
            }

            read.Close();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            Search1(dataGridView2);
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == String.Empty)
            {
                dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;

        }

        private void deleteRow1()
        {
            int index = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows[index].Visible = false;

            if (dataGridView2.Rows[index].Cells[0].Value.ToString() == String.Empty)
            {
                dataGridView2.Rows[index].Cells[4].Value = RowState.Deleted;
                return;
            }

            dataGridView2.Rows[index].Cells[4].Value = RowState.Deleted;

        }

        private void Update()
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[4].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToString(dataGridView1.Rows[index].Cells[0].Value);

                    var deletQuery = $"delete from Profit_User1 where ID_Profit = '{id}'";

                    var command = new SqlCommand(deletQuery, dataBase.getSqlConnection());

                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var date = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var profit = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var coment = dataGridView1.Rows[index].Cells[3].Value.ToString();
                   

                    var changeQuery = $"update Profit_User1 set  Date_Profit = '{date}',Profit_ = '{profit}',ComentPr = '{coment}' where ID_Profit = '{id}'";

                    var command = new SqlCommand(changeQuery, dataBase.getSqlConnection());
                    command.ExecuteNonQuery();

                }

            }

            dataBase.closeConnection();
        }

        private void Update1()
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView2.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView2.Rows[index].Cells[4].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToString(dataGridView2.Rows[index].Cells[0].Value);

                    var deletQuery = $"delete from Spending_User1 where ID_Spending = '{id}'";

                    var command = new SqlCommand(deletQuery, dataBase.getSqlConnection());

                    command.ExecuteNonQuery();
                }


                if (rowState == RowState.Modified)
                {
                    var id = dataGridView2.Rows[index].Cells[0].Value.ToString();
                    var date = dataGridView2.Rows[index].Cells[1].Value.ToString();
                    var profit = dataGridView2.Rows[index].Cells[2].Value.ToString();
                    var coment = dataGridView2.Rows[index].Cells[3].Value.ToString();


                    var changeQuery = $"update Spending_User1 set  Date_Spending = '{date}',Spending_ = '{profit}',ComentSp = '{coment}' where ID_Spending = '{id}'";

                    var command = new SqlCommand(changeQuery, dataBase.getSqlConnection());
                    command.ExecuteNonQuery();

                }

            }

            dataBase.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            deleteRow1();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Update1();
        }


        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

           /* var id = textBox7.Text;
            var Date = textBox1.Text;
            var profit = textBox2.Text;
            var coment = textBox3.Text;*/
           

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(textBox7.Text, textBox1.Text, textBox2.Text, textBox3.Text);
                dataGridView1.Rows[selectedRowIndex].Cells[4].Value = RowState.Modified;
            }

        }


        private void Change1()
        {
            var selectedRowIndex = dataGridView2.CurrentCell.RowIndex;

            /*var id = textBox8.Text;
            var Date = textBox4.Text;
            var profit = textBox5.Text;
            var coment = textBox6.Text;*/


            if (dataGridView2.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView2.Rows[selectedRowIndex].SetValues(textBox8.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                dataGridView2.Rows[selectedRowIndex].Cells[4].Value = RowState.Modified;
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Change1();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void read_math(object sender, EventArgs e)
        { 
            
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(0);
            int First = Convert.ToInt32(textBox12.Text);
            int Second = Convert.ToInt32(textBox11.Text);
            int Sum1 = First + Second;
            textBox12.Text = Convert.ToString(Sum1);
            textBox11.Text = Convert.ToString(x);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(0);
            int First = Convert.ToInt32(textBox12.Text);
            int Second = Convert.ToInt32(textBox11.Text);
            int Sum1 = First + Second;
            textBox11.Text = Convert.ToString(Sum1);
            textBox12.Text = Convert.ToString(x);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(0);
            int First = Convert.ToInt32(textBox12.Text);
            int Second = Convert.ToInt32(textBox11.Text);
            int Sum1 = First - Second;
            textBox12.Text = Convert.ToString(Sum1);
            textBox11.Text = Convert.ToString(x);
        }
    }
}
