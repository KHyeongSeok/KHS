using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm250520_ToggleButton
{
    public partial class Form1 : Form
    {
        bool label1_state = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1_state == false)
            {
                label1.Text = "On";
                label1_state = true;
            }
            else
            {
                label1.Text = "Off";
                label1_state = false;
            }
        }
    }
}
