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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsValidNumber(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập một số có 12 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string number = textBox1.Text;
            string result = ConvertNumberToWords(number);
            textBox2.Text = result;
        }
        private bool IsValidNumber(string number)
        {
            // Kiểm tra chuỗi có đúng 12 chữ số và không chứa ký tự không phải số
            return number.Length == 12 && long.TryParse(number, out _);
        }



        private string ConvertNumberToWords(string number)
        {
            string[] one = { "", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
            string[] ones = { "", "Một", "Hai", "Ba", "Bốn", "Lăm", "Sáu", "Bảy", "Tám", "Chín" };
            string[] tens = { "", "Mười", "Hai Mươi", "Ba Mươi", "Bốn Mươi", "Năm Mươi", "Sáu Mươi", "Bảy Mươi", "Tám Mươi", "Chín Mươi" };
            string[] thousands = { "", "Nghìn", "Triệu", "Tỷ" };

            int numDigits = number.Length;
            int groupCount = (numDigits + 2) / 3;
            string result = "";
            number = number.PadLeft(groupCount * 3, '0');

            if (number == "000000000000")
                return "Không";

            for (int i = 0; i < groupCount * 3; i += 3)
            {
                int group = int.Parse(number.Substring(i, 3));
                if (group == 0) continue;

                int hundreds = group / 100;
                int tensUnit = group % 100;
                int tenss = tensUnit / 10;
                int onesDigit = tensUnit % 10;

                // Kiểm tra nếu số đầu tiên trong nhóm là 0
                bool isFirstNumberZero = (i == 0 && number.Length % 3 != 0 && number.Length % 3 < 3);

                if (!isFirstNumberZero)
                {
                    if (hundreds > 0)
                        result += one[hundreds] + " Trăm ";

                    if (tensUnit > 10 && tensUnit < 20)
                    {
                        result += tens[tensUnit % 10] + " ";
                    }
                    else
                    {
                        if (tenss > 0)
                            result += tens[tenss] + " ";
                        if (onesDigit > 0)
                            result += ones[onesDigit] + " ";
                    }
                }

                result += thousands[(groupCount - 1) - (i / 3)] + " ";
            }

            return result.Trim();
        }
    }
}