using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm250520_창속창
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("이름이 비어있거나 이미 존재합니다.");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            this.AddOwnedForm(f2);
            f2.Show();
        }
    }
}
