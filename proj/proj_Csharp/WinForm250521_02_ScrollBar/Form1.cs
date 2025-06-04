using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm250521_02_ScrollBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar1.Value.ToString();
        } // 스크롤바가 움직이면 택스트박스에 숫자 표시

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0) // 텍스트박스에 숫자를 썻다 지웠을 때 오류 방지
            {
                hScrollBar1.Value = Convert.ToInt32(textBox1.Text);
            }
        } // 택스트박스에 숫자를 기입하면 스크롤바에 적용
    }
}
