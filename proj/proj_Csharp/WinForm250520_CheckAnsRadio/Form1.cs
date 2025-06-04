using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm250520_CheckAnsRadio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            string carOptionDisplay = "선택된 옵션: ";
            CheckBox[] carOptions = { checkBox_seatHeater, checkBox_rearseatFolding, checkBox_smartKey };
            foreach (var carOption in carOptions)
            {
                if (carOption.Checked == true)
                {
                    carOptionDisplay += carOption.Text + ", ";
                }
            }
            label_options.Text = carOptionDisplay;
            //label_options.Text += "ㅋ";
        }

        private void radioButtonWheel_CheckedChanged(object sender, EventArgs e)
        {
            string wheelOptionDisplay = "";
            RadioButton[] wheelOptions = { radioButton15inch, radioButton16inch, radioButton17inch };
            foreach (var wheelOption in wheelOptions)
            {
                if (wheelOption.Checked == true)
                {
                    wheelOptionDisplay += wheelOption.Text;
                    break;
                }
            }
            label_wheel.Text = "선택된 휠: " + wheelOptionDisplay;
        }

        private void radioButton_color_CheckedChanged(object sender, EventArgs e)
        {
            string colorOptionDisplay = "";
            RadioButton[] colorOptions = { radioButton_red, radioButton_white, radioButton_balck };
            foreach (var colorOption in colorOptions)
            {
                if (colorOption.Checked == true)
                {
                    colorOptionDisplay += colorOption.Text;
                    break;
                }
            }
            label_color.Text = "선택된 색생: " + colorOptionDisplay;
        }
    }
}
