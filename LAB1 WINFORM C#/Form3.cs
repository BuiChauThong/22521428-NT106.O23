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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            if (!Int32.TryParse(textBox1.Text, out num) && textBox1.Text != "")
            {
                MessageBox.Show("Vui long nhap lai!");
                textBox1.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (Int32.Parse(textBox1.Text))
            {
                case 0:
                    textBox2.Text = "Không"; 
                    break;

                case 1:
                    textBox2.Text = "Một"; 
                    break;
                case 2:
                    textBox2.Text = "Hai"; 
                    break;
                case 3:
                    textBox2.Text = "Ba";
                    break;
                case 4:
                    textBox2.Text = "Bốn";
                    break;
                case 5:
                    textBox2.Text = "Năm"; 
                    break;
                case 6:
                    textBox2.Text = "Sáu"; 
                    break;
                case 7:
                    textBox2.Text = "Bảy";
                    break;
                case 8:
                    textBox2.Text = "Tám"; 
                    break;
                case 9:
                    textBox2.Text = "Chín";
                    break;
                default:
                    MessageBox.Show("Vui lòng nhập lại số nguyên từ 0 đến 9");
                    textBox1.Text = "";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
