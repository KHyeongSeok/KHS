using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm250522_04_TrackBarProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100; // 0.1초
            timer1.Tick += Timer1_Tick; // 타이머의 Tick메소드를 Timer1_Tick으로 설정
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;
            trackBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0; // trackBar1과 progressBar1의 최대,최소,Value를 설정
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (trackBar1.Value < 100)  // Value가 100이 아닐시
            {
                trackBar1.Value++;
                progressBar1.Value++; // 하나씩 증가
                label1.Text = trackBar1.Value.ToString();
                label2.Text = progressBar1.Value.ToString(); // 라벨에 증가된 Value값을 출력
            }
            else
            {
                timer1.Stop(); // 100이 되면 중지
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start(); // 버튼 클릭시 타이머 시작
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString(); // 트랙바를 움직이면 라벨의 택스트가 바뀜
        }
    }
}
