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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + "\n");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox2.Text="Hãy nhập món ăn";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, listBox1.Items.Count);
                string selectedItem = listBox1.Items[randomIndex].ToString();
                textBox2.Text = selectedItem;
            }
            else
            {
                MessageBox.Show("Hãy nhập món ăn");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = "";
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
