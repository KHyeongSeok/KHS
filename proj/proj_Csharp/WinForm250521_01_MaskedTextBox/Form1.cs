using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm250521_01_MaskedTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 입사일 maskedTextBox1
            // 우편번호 maskedTextBox2
            // 주소 textBox1
            // 휴대폰 번호 maskedTextBox3
            // 주민번호 maskedTextBox4
            // 이메일 textBox2
            string man_info = "";
            man_info += "입사일: " + maskedTextBox1.Text + "\n" +
                        "우편번호: " + maskedTextBox2.Text + "\n" +
                        "주소: " + textBox1.Text + "\n" +
                        "휴대폰 번호: " + maskedTextBox3.Text + "\n" +
                        "주민번호 " + maskedTextBox4.Text + "\n" +
                        "이메일: " + textBox2.Text;
            MessageBox.Show(man_info, "직원 개인정보");
        }
    }
}
