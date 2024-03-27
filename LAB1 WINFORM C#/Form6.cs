using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB11
{
    public partial class Form6 : Form
    {
        public Form6()
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            if (!Int32.TryParse(textBox2.Text, out num) && textBox2.Text != "")
            {
                MessageBox.Show("Vui long nhap lai!");
                textBox2.Text = "";
            }
        }
        
        double Tinhtoan1(int numberA, int numberB)
        {
            if (numberA <= numberB)
            { 
                return 0;
            }
            else
            { 
                int Giaithua = 1;
                int Hieu = numberA - numberB;
                for (int i = 1 ; i<=Hieu ; i++)
                {
                    Giaithua *= i;
                }
                return Giaithua;
            }
        }
        double Tinhtoan2(int numberA, int numberB)
        {
            double S = 0;
            for (int i = 1; i <= numberB; i++)
            {
                S += Math.Pow(numberA, i);
            }
            return S;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Bảng cửu chương")
            {
                richTextBox1.Text = "";
                int valueA = Convert.ToInt32(textBox1.Text);
                int valueB = Convert.ToInt32(textBox2.Text);
                int Hieu = valueB-valueA;
                for ( int i = 1 ;i<=10 ; i++)
                {
                    richTextBox1.Text += Hieu + "*"+i + "=" + Hieu * i + "\n";
                }
            }
            if(comboBox1.Text == "Tính toán giá trị")
            {
                int valueA = Convert.ToInt32(textBox1.Text);
                int valueB = Convert.ToInt32(textBox2.Text);
                double HieuGT = 0;
                HieuGT = Tinhtoan1(valueA, valueB);
                double HamMU = 0;
                HamMU = Tinhtoan2(valueA,valueB);
                if (valueA <= valueB)
                {
                    MessageBox.Show("Không thể tính giá trị giai thừa (A-B)!");
                    richTextBox1.Text = "Tổng S = A^1+...+A^B=" + HamMU;
                }
                else
                {
                    richTextBox1.Text = "(A-B)!=" + HieuGT + "\n"
                        + "Tổng S = A^1+...+A^B=" + HamMU;
                }
                
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text =  "" ;
            richTextBox1.Text = " KẾT QUẢ ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
