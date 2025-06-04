using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm250521_04_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox_Tools_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 콤보박스에 선택된 아이템을 문자열로 바꾸어 라벨에 표시
            ComboBox cb = sender as ComboBox;
            string selectedTool = cb.SelectedItem.ToString();
            label_SelectedTool.Text = "선택된 공구: " + selectedTool;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            // 콤보박스는 택스트박스처럼 값을 입력 받을 수 있어, 문자열로 바꾸어 콤보박스 아이템 추가
            string toolToAdd = comboBox_Tools.Text;
            if (toolToAdd != "")
            comboBox_Tools.Items.Add(toolToAdd);
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            // 선택된 아이템 제거
            comboBox_Tools.Items.Remove(comboBox_Tools.SelectedItem);
        }
    }
}
