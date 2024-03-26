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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 bai01 = new Form1();
            bai01.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 bai2 = new Form2();
            bai2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 bai3 = new Form3();
            bai3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 bai5 = new Form6();
            bai5.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 bai6 = new Form7();
            bai6.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form8 bai8 = new Form8();
            bai8.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
