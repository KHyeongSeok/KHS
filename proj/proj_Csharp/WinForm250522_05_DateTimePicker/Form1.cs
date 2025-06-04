using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm250522_05_DateTimePicker
{
    public partial class Form1 : Form
    {
        DateTime reservationStart, reservationEnd; // 날짜와 시간을 표시되게 변수 설정
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker_Start_ValueChanged(object sender, EventArgs e)
        {
            reservationStart = dateTimePicker_Start.Value; // 변수의 날짜 값을 저장
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan duration = reservationEnd.Date - reservationStart.Date; // 날짜 간의 차로 일수를 계산
            label_Result.Text = String.Format($"작업이 {reservationStart.ToString()}부터 " +
                                              $"{reservationEnd.ToString()}까지 " + 
                                              $"{duration.Days}일 동안 예약 되었습니다");
                                              // 지정한 날짜들과 날짜들 간의 일수를 출력
        }

        private void dateTimePicker_End_ValueChanged(object sender, EventArgs e)
        {
            reservationEnd = dateTimePicker_End.Value;
        }
    }
}
