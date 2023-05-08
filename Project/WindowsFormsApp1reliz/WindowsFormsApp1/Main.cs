using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : System.Windows.Forms.Form
    {
        public Main()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product frm3 = new Product();
            frm3.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Coach frm4 = new Coach();
            frm4.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Castomer frm5 = new Castomer();
            frm5.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CTicket frm6 = new CTicket();
            frm6.ShowDialog();
            /*this.Hide();
            Close();*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
