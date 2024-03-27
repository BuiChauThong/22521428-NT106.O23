using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LAB11
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private int CheckYear(uint year)
        {
            if (year % 100 == 0 && year % 400 == 0) return 1;
            if (year % 100 == 0 && year % 400 != 0) return 0;
            if (year % 4 == 0) return 1;
            return 0;

        }
        private int Checktext(String text)
        {
            uint date, month, year;
            String[] A = text.Split('/');
            if (A.Length > 3) return 0;
            if (!uint.TryParse(A[0], out date) || !uint.TryParse(A[1], out month) || !uint.TryParse(A[2], out year))
            {
                return 0;
            }
            else
            {
                date = uint.Parse(A[0]);
                month = uint.Parse(A[1]);
                year = uint.Parse(A[2]);
                if (month > 12) return 0;
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (date > 0 && date <= 31) return 1; 
                        else return 0;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (date > 0 && date <= 30) return 1; 
                        else return 0;
                    case 2:
                        if (CheckYear(year) == 1 && date > 0 && date <= 29) return 1;
                        if (CheckYear(year) == 0 && date > 0 && date <= 28) return 1;
                        else return 0;
                }
            }
            return 1;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint date, month;
            String[] A = textBox1.Text.Split('/');
            date = uint.Parse(A[0]);
            month = uint.Parse(A[1]);
            if (Checktext(textBox1.Text) == 1)
            {
                if ((date >= 21 && month == 3) || (date <= 20 && month == 4)) textBox2.Text = "Cung Bạch Dương";
                if ((date >= 21 && month == 4) || (date <= 21 && month == 5)) textBox2.Text = "Cung Kim Ngưu";
                if ((date >= 22 && month == 5) || (date <= 21 && month == 6)) textBox2.Text = "Cung Song Tử";
                if ((date >= 22 && month == 6) || (date <= 22 && month == 7)) textBox2.Text = "Cung Cự Giải";
                if ((date >= 23 && month == 7) || (date <= 22 && month == 8)) textBox2.Text = "Cung Sư Tử";
                if ((date >= 23 && month == 8) || (date <= 23 && month == 9)) textBox2.Text = "Cung Xử Nữ";
                if ((date >= 24 && month == 9) || (date <= 23 && month == 10)) textBox2.Text = "Cung Thiên Bình";
                if ((date >= 24 && month == 10) || (date <= 22 && month == 11)) textBox2.Text = "Cung Thần Nông";
                if ((date >= 23 && month == 11) || (date <= 21 && month == 12)) textBox2.Text = "Cung Nhân Mã";
                if ((date >= 22 && month == 12) || (date <= 20 && month == 1)) textBox2.Text = "Cung Ma Kết";
                if ((date >= 21 && month == 1) || (date <= 19 && month == 2)) textBox2.Text = "Cung Bảo Bình";
                if ((date >= 20 && month == 2) || (date <= 20 && month == 3)) textBox2.Text = "Cung Song Ngư";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại");
            }
        }
    }
}
