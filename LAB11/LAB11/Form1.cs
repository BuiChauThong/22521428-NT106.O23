using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

       

        private void button1_Click_2(object sender, EventArgs e)
        {
            int num = 0;
            if (Int32.TryParse(textBox1.Text, out num) && Int32.TryParse(textBox2.Text, out num))
            {
                textBox3.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
            }
            else
            {
                textBox1.Text = textBox2.Text = textBox3.Text = "";
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
