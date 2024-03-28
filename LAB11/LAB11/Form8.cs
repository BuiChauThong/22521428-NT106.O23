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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private int CHECKTEXT(string Text)
        {
            double value;
            string[] A = Text.Split(',');
            if (double.TryParse(A[0], out value)) return 0;
            else
            {
                for (int i = 1; i < A.Length; i++)
                {
                    if (!double.TryParse(A[i], out value) || double.Parse(A[i]) < 0 || double.Parse(A[i]) > 10) return 0;
                }
            }
            return 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(CHECKTEXT(textBox1.Text)==0)
            {
                MessageBox.Show ("Vui lòng nhập lại đúng định dạng");
                richTextBox1.Text = richTextBox2.Text = "";
            }
            else
            {
                double min = 10, max = 0, Tong = 0, DTB = 0;
                int imin = 0, imax = 0, somonrot = 0;
                String[] A = textBox1.Text.Split(',');
                int somondau = A.Length-1;
                for (int i = 1; i < A.Length; i++)
                    if (min > double.Parse(A[i]))
                    {
                        min = double.Parse(A[i]);
                        imin = i;
                    };
                for (int i = 1; i < A.Length; i++)
                    if (max < double.Parse(A[i]))
                    {
                        max = double.Parse(A[i]);
                        imax = i;
                    };
               
                for (int i = 1;i < A.Length; i++)
                    if (double.Parse(A[i]) < 5)
                    {
                        somondau -= 1;
                        somonrot += 1;
                    };
                for (int i = 1;i < A.Length ; i++)
                {
                    Tong += double.Parse(A[i]);
                };
                DTB = Tong / (A.Length - 1);
                if (DTB >= 8 && min >= 6.5) 
                    richTextBox2.Text = "Điểm trung bình: " + DTB + "\r\n" + "Xếp loại giỏi"+"\r\n"+ "Điểm cao nhất: Môn " + imax + " :" + max + "\r\n" + "Điểm thấp nhất: Môn " + imin + " :" + min;
                else if (DTB >= 6.5 && min >= 5) 
                    richTextBox2.Text = "Điểm trung bình: " + DTB + "\r\n" + "Xếp loại: Khá." + "\r\n" + "Điểm cao nhất: Môn " + imax + " :" + max + "\r\n" + "Điểm thấp nhất: Môn " + imin + " :" + min; 
                else if (DTB >= 5 && min >= 3.5) 
                    richTextBox2.Text = "Điểm trung bình: " + DTB + "\r\n" + "Xếp loại: Trung Bình." + "\r\n" + "Điểm cao nhất: Môn " + imax + " :" + max + "\r\n" + "Điểm thấp nhất: Môn " + imin + " :" + min; 
                else if (DTB >= 3.5 && min >= 2) 
                    richTextBox2.Text = "Điểm trung bình: " + DTB + "\r\n" + "Xếp loại: Yếu." + "\r\n" + "Điểm cao nhất: Môn " + imax + " :" + max + "\r\n" + "Điểm thấp nhất: Môn " + imin + " :" + min; 
                else 
                    richTextBox2.Text = "Điểm trung bình: " + DTB + "\r\n" + "Xếp loại: Kém." + "\r\n" + "Điểm cao nhất: Môn " + imax + " :" + max + "\r\n" + "Điểm thấp nhất: Môn " + imin + " :" + min;


                richTextBox1.Text = "";
                for (int i = 1; i < A.Length; i++) richTextBox1.Text +=  "Môn " + i + " :" + A[i] + "\n";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = richTextBox1.Text = richTextBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
