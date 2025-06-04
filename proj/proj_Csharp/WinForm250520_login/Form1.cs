using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm250520_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string id_registered = "hskang";
            string pw_registered = "1234";
            string id_read = textBox_ID.Text;
            string pw_read = textBox_PW.Text;
            if (id_read == "")
            {
                label_result.Text = "ID를 입력하세요";
                return;
            }
            if (pw_read == "")
            {
                label_result.Text = "PW를 입력하세요";
                return;
            }
            if (id_read == id_registered && pw_read == pw_registered)
            {
                label_result.Text = $"{id_registered}님 반갑습니다";
            }
            else
            {
                label_result.Text = "로그인 실패, 다시 로그인 하세요";
            }
        }
    }
}
