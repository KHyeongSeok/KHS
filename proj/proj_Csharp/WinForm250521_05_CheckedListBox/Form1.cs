using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm250521_05_CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 폼 로드 시 체크리스트박스에 코드상으로 아이템 추가
            checkedListBox1.Items.Add("서울");
            checkedListBox1.Items.Add("인천");
            checkedListBox1.Items.Add("대전");
            checkedListBox1.Items.Add("광주");
            checkedListBox1.Items.Add("대구");
            checkedListBox1.Items.Add("부산");
        }

        private void CheckedListBoxChanged(object sender, EventArgs e)
        {
            //string cities = "";
            //foreach ( var city in checkedListBox1.CheckedItems)
            //{
            //    cities += city.ToString() + ", ";
            //}
            //label1.Text = cities;
        }

        private void button_ToRight_Click(object sender, EventArgs e)
        {
            // 선택한 항목을 리스트박스에 추가
            foreach (var city in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(city);
            }
        }

        private void button_ToRightAll_Click(object sender, EventArgs e)
        {
            // 체크리스트박스에 모든 아이템을 리스트박스에 추가
            foreach (var city in checkedListBox1.Items)
            {
                listBox1.Items.Add(city);
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            List<string> list_remove = new List<string>(); // 데이터 상의 list_remove리스트를 만듬
            foreach (string city in listBox1.SelectedItems) // listBox1의 선택된 아이템들을 list_remove에 추가
            {
                list_remove.Add(city);
            }
            foreach (string city in list_remove) // listBox1 의 선택된 아이템들을 제거
            {
                listBox1.Items.Remove(city);
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // 리스트박스에 모든 아이템 제거
        }
    }
}
