using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm250522_06_TapControl
{
    public partial class Form1 : Form
    {
        private Timer myTimer = new Timer();
        private DateTime dDay, tTime; // 알람 날짜와 시간을 저장
        private bool setAlarm; // 부울 변수로 알람이 설정 되면 true가 됨

        public Form1()
        {
            InitializeComponent();
            lbAlarm.ForeColor = Color.Gray;
            lbAlarmSet.ForeColor = Color.Gray; // 라벨을 회색으로 표시
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "tt hh:mm"; // 알람 시간을 tt hh:mm 포맷으로 표시하기 위해 Custom으로 포맷을 설정
            myTimer.Interval = 1000;
            myTimer.Tick += Mytimer_Tick;
            myTimer.Start(); // 1초에 한번씩 Mytimer_Tick 메소드를 호출하고 타이머를 시작
            tabControl1.SelectedTab = tabPage_Watch; // 실행시 디지털 시계 탭을 표시
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            // 버튼 클릭시 설정한 알람의 날짜와 시간을 표시하고 라벨의 색을 변경
            dDay = DateTime.Parse(datePicker.Text);
            tTime = DateTime.Parse(timePicker.Text);
            setAlarm = true;
            lbAlarmSet.ForeColor = Color.Red;
            lbAlarm.ForeColor = Color.Blue;
            lbAlarm.Text = $"Alarm: {dDay.ToShortDateString()} {tTime.ToLongTimeString()}";
            tabControl1.SelectedTab = tabPage_Watch;
        }

        private void btnReSet_Click(object sender, EventArgs e)
        {
            // 설정한 알람을 초기상태로 변경
            setAlarm = false;
            lbAlarmSet.ForeColor = Color.Gray;
            lbAlarm.ForeColor = Color.Gray;
            lbAlarm.Text = "Alarm";
            tabControl1.SelectedTab = tabPage_Watch;
        }

        private void Mytimer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now; // 날짜와 시간 가져오기
            lbDate.Text = currentTime.ToShortDateString(); // 날짜 표시
            lbTime.Text = currentTime.ToLongTimeString(); // 시간 표시
        }
    }
}
