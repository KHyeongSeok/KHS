using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // Process. 메소드를 사용할려고 추가함

namespace WinForm250522_07_OpenFileDialog
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog1, openFileDialog2; // 객체 선언
        public Form1()
        {
            InitializeComponent();
            // 각각 openFileDialog1을 생성하고 속성을 설정
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.FileName = "txt 파일을 선택하세요"; // 파일 이름 설정
            openFileDialog1.Filter = "txt 파일 (*.txt)|*.txt"; // 해당 확장자를 가진 파일만 보이게 필터 설정
            openFileDialog1.Title = "txt 파일 열기"; // 다이얼로그의 타이틀바에 쓰일 문자열 설정

            openFileDialog2 = new OpenFileDialog();
            openFileDialog2.FileName = "pdf 파일을 선택하세요";
            openFileDialog2.Filter = "pdf 파일 (*.pdf)|*.pdf";
            openFileDialog2.Title = "pdf 파일 열기";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) // 파일 선택 창을 띄우로 "열기" 클릭 시 DialogResult.OK가 리턴
            {
                try
                {
                    var filePath = openFileDialog1.FileName; // 선택된 파일의 경로가 filePath에 할당
                    using (FileStream fs = File.Open(filePath, FileMode.Open))
                    {
                        Process.Start("notepad.exe", filePath); // 이 줄을 사용하기 위해선 using System.Diagnostics; 을 상단에 써야함
                    }
                }
                catch (SecurityException ex)
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog2.FileName;
                    using (FileStream fs = File.Open(filePath, FileMode.Open))
                    {
                        // 윈도우 기본 앱으로 열기
                        Process.Start(new ProcessStartInfo{ FileName = filePath, UseShellExecute = true });
                    }
                }
                catch (SecurityException ex)
                {

                } // 번외) pdf파일 열기
            }
        }
    }
}
