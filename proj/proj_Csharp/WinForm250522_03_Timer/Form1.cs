using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinfForm250522_03_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = ""; // 라벨 텍스트 초기화
            timer1.Interval = 1000; // 타이머가 동작하는 인터벌을 1000ms = 1초로 설정
            timer1.Tick += Timer1_Tick; // 1초에 한번씩 Timer1_Tick 메소드를 호출
            timer1.Start(); // = timer1.Enabled = true; 타이머 시작
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Location = new Point(ClientSize.Width / 2 - label1.Width / 2,
                ClientSize.Height / 2 - label1.Height / 2); // 라벨의 위치를 폼의 정중앙으로 설정
            label1.Font = new Font("맑은 고딕", 30, FontStyle.Bold); // 라벨 폰트 설정
            label1.Text = DateTime.Now.ToString(); // 현재 시간 표시
        }
    }
}
