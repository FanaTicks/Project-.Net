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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int First = Convert.ToInt32(textBox1.Text);
            int Second = Convert.ToInt32(textBox2.Text);
            int Sum1 = First + Second;
            textBox3.Text = Convert.ToString(Sum1);
            
        }
    }
}
