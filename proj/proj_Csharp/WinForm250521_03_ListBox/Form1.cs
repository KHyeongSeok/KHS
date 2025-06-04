using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm250521_03_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox_GoodCity.Items.Add("부산");
            listBox_GoodCity.Items.Add("서울");
            listBox_GoodCity.Items.Add("인천");
            listBox_GoodCity.Items.Add("대전");
            listBox_GoodCity.Items.Add("광주");
            listBox_GoodCity.Items.Add("창원");
            listBox_GoodCity.Items.Add("울산");
            listBox_GoodCity.Items.Add("김해"); // 코드로 아이템박스에 아이템 추가

            List<string> list_HappyCountry = new List<string>
            {
                "미국", "러시아", "중국", "영국", "독일", "프랑스"
            };
            listBox_HappyCountry.DataSource = list_HappyCountry; // List데이터 상에 아이템을 추가하여 리스트박스에 추가
        }

        private void listBox_GDP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listGDP = sender as ListBox;
            textBox_IndexGDP.Text = listGDP.SelectedIndex.ToString(); // 선택한 인덱스를 출력
            textBox_ItemGDP.Text = listGDP.SelectedItem.ToString(); // 선택한 아이템을 출력
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox_GDP.Items.Add(textBox_AddCountry.Text); // 실행 후 추가적으로 리스트박스에 아이템 추가
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox_GDP.Items.Remove(textBox_RemoveCountry.Text); // 추가적으로 추가한 아이템을 제거(단, 추가한 순서대로 제거 됨)
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = Convert.ToInt32(textBox_RemoveAtCountry.Text);
            listBox_GDP.Items.RemoveAt(selectedIndex); // 제거하고 싶은 인덱스를 리스트박스에서 제거
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox_GDP.Items.Clear(); // 리스트박스에 모든 아이템 제거
        }
    }
}
