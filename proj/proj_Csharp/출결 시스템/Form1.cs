using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
     
    public partial class Form1 : Form
    {
        private List<string> Names = new List<string>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Load_Name()
        {
            CBNameList.Items.Clear();
            foreach (string name in Names)
            {
                CBNameList.Items.Add(name);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();

            // ListView 설정
            listViewStatus.View = View.Details;
            listViewStatus.Columns.Add("이름", 100);
            listViewStatus.Columns.Add("입실 시간", 150);
            listViewStatus.Columns.Add("퇴실 시간", 150);

            // 초기 이름들
            Names = new List<string> { "강동현", "강형석", "변진섭", "최민준" };
            Load_Name();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Font = new Font("맑은 고딕", 18, FontStyle.Bold);
            label1.Text = DateTime.Now.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newName = CBNameList.Text.Trim();
            if (!string.IsNullOrEmpty(newName) && !Names.Contains(newName))
            {
                Names.Add(newName);
                Load_Name();
            }
            else
            {
                MessageBox.Show("이름이 비어있거나 이미 존재합니다.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CBNameList.SelectedIndex >= 0)
            {
                string selectedName = CBNameList.SelectedItem.ToString();
                Names.Remove(selectedName);
                Load_Name();

                // ListView에서도 제거
                foreach (ListViewItem item in listViewStatus.Items)
                {
                    if (item.Text == selectedName)
                    {
                        listViewStatus.Items.Remove(item);
                        break;
                    }
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string selectedName = CBNameList.Text.Trim();
            string timestamp = DateTime.Now.ToString("MM-dd HH:mm");

            if (!string.IsNullOrEmpty(selectedName))
            {
                if (!Names.Contains(selectedName))
                {
                    Names.Add(selectedName);
                    Load_Name();
                }

                bool found = false;
                foreach (ListViewItem item in listViewStatus.Items)
                {
                    if (item.Text == selectedName)
                    {
                        // 입실 시간 업데이트
                        item.SubItems[1].Text = timestamp;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    // 새 항목 추가 (입실 시간만 채움)
                    ListViewItem newItem = new ListViewItem(selectedName);
                    newItem.SubItems.Add(timestamp);  // 입실 시간
                    newItem.SubItems.Add("");         // 퇴실 시간
                    listViewStatus.Items.Add(newItem);
                }
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            string selectedName = CBNameList.Text.Trim();
            string timestamp = DateTime.Now.ToString("MM-dd HH:mm");

            if (!string.IsNullOrEmpty(selectedName))
            {
                if (!Names.Contains(selectedName))
                {
                    Names.Add(selectedName);
                    Load_Name();
                }

                bool found = false;
                foreach (ListViewItem item in listViewStatus.Items)
                {
                    if (item.Text == selectedName)
                    {
                        // 퇴실 시간 업데이트
                        item.SubItems[2].Text = timestamp;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    // 새 항목 추가 (퇴실 시간만 채움)
                    ListViewItem newItem = new ListViewItem(selectedName);
                    newItem.SubItems.Add("");         // 입실 시간
                    newItem.SubItems.Add(timestamp);  // 퇴실 시간
                    listViewStatus.Items.Add(newItem);
                }
            }
        }
    }
}
