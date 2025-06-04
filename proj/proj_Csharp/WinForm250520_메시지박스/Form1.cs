using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm250520_메시지박스
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("가장 간단한 메시지 박스");
            MessageBox.Show("타이틀 있는 메시지 박스", "이런 타이틀");
            MessageBox.Show("느낌표 있는 메시지 박스", "!로 알람 표시", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            DialogResult result1 = MessageBox.Show("사용자의 뜻을 묻는 대화상자입니다.", "TitleQuestion", MessageBoxButtons.YesNo);
            DialogResult result2 = MessageBox.Show("사용자의 뜻을 묻는 대화상자입니다. 물음표, 버튼3개", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            DialogResult result3 = MessageBox.Show("사용자의 뜻을 묻는 대화상자입니다. 물음표, 버튼3개", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            string msg = string.Format($"당신의 선택 : " + $"{result1.ToString()}, {result2.ToString()}, {result3.ToString()}");
            MessageBox.Show(msg, "당신의 선택은 이렇습니다.");
        }
    }
}
