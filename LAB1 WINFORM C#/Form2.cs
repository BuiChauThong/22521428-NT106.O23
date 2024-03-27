using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private double TimMIN(double value1, double value2, double value3) {
            double min = 0;
            min = value1;
            if (min > value2)
            {
                min = value2;
            }
            if (min > value3)
            {
                min = value3;
            }
            return min;
        }
        private double TimMAX(double value1, double value2, double value3) { 
            double max = 0;
            max = value1;
            if(max<value2)
            { 
                max = value2;
            }
            if (max < value3) 
            {  
                max = value3;
            }
            return max;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sothunhat=0, sothuhai=0, sothuba=0, min=0, max=0;
            sothunhat = Convert.ToDouble(textBox1.Text);
            sothuhai = Convert.ToDouble(textBox2.Text);
            sothuba = Convert.ToDouble(textBox3.Text);
            min = TimMIN(sothunhat, sothuhai, sothuba);
            max = TimMAX(sothunhat,sothuhai,sothuba);
            textBox4.Text = Convert.ToString(min);
            textBox5.Text = Convert.ToString(max);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double num;
            if (!double.TryParse(textBox1.Text, out num) && textBox1.Text != "")
            {
                MessageBox.Show("Vui long nhap lai!");
                textBox1.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double num;
            if (!double.TryParse(textBox3.Text, out num) && textBox3.Text != "")
            {
                MessageBox.Show("Vui long nhap lai!");
                textBox3.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double num;
            if (!double.TryParse(textBox2.Text, out num) && textBox2.Text != "")
            {
                MessageBox.Show("Vui long nhap lai!");
                textBox2.Text = "";
            }
        }
    }
}
