using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm250520_덱스트박스
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameInput();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nameInput();
        }
        private void nameInput()
        {
            string name = textBox1.Text;
            // name으로 할일 하는 곳
            label2.Text = name;
            label3.Text = name;
        }
    }
}
