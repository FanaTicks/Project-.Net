using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tCPP_ProjecrDataSet.Spending". При необходимости она может быть перемещена или удалена.
            this.spendingTableAdapter.Fill(this.tCPP_ProjecrDataSet.Spending);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tCPP_ProjecrDataSet.Profit_User". При необходимости она может быть перемещена или удалена.
            //this.profit_UserTableAdapter.Fill(this.tCPP_ProjecrDataSet.Profit_User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tCPP_ProjecrDataSet.Spending". При необходимости она может быть перемещена или удалена.
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm__ = new Form4();
            this.Hide();
            frm__.ShowDialog();
        }
    }
}
