using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinForm250520_성적계산기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            //    TextBox[] subjects = { textBox_kor, textBox_math, textBox_Eng };
            //    int sum = 0;
            //    foreach (TextBox subject in subjects)
            //    {
            //        int point = Convert.ToInt32(subject.Text);
            //        sum += point;
            //    }
            //    textBox_sum.Text = sum.ToString();
            //    int avg = 0;
            //    foreach (TextBox subject in subjects)
            //    {
            //        int point = Convert.ToInt32(subject.Text);
            //        avg += point / 3;
            //    }
            //    textBox_avg.Text = avg.ToString("0.0");

            double sum = Convert.ToDouble(textBox_kor.Text) + Convert.ToDouble(textBox_math.Text) + Convert.ToDouble(textBox_Eng.Text);
            double avg = sum / 3;
            textBox_sum.Text = sum.ToString();
            textBox_avg.Text = avg.ToString("0.0");
        }
    }
}
