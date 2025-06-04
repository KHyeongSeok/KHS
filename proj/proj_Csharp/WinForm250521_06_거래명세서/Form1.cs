using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm250521_06_거래명세서
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_Num.Text = "0";
            textBox_Num2.Text = "0";
            textBox_Num3.Text = "0";
            textBox_AR.Text = "0";
            List<string> list = new List<string> { "1번 제품", "2번 제품", "3번 제품", "4번 제품", "5번 제품" };
            List<string> list2 = new List<string> { "1번 제품", "2번 제품", "3번 제품", "4번 제품", "5번 제품" };
            List<string> list3 = new List<string> { "1번 제품", "2번 제품", "3번 제품", "4번 제품", "5번 제품" };
            comboBox_List.DataSource = list;
            comboBox_List2.DataSource = list2;
            comboBox_List3.DataSource = list3;
        }

        private void comboBox_List_SelectedIndexChanged(object sender, EventArgs e) // 1~3콤보박스 내용 동일
        {
            ComboBox list = sender as ComboBox;
            textBox_Cost.Text = list.SelectedIndex.ToString();
            if (Convert.ToInt32(textBox_Cost.Text) == 0)
            {
                textBox_Cost.Text = "10000";
            }
            else if (Convert.ToInt32(textBox_Cost.Text) == 1)
            {
                textBox_Cost.Text = "15000";
            }
            else if (Convert.ToInt32(textBox_Cost.Text) == 2)
            {
                textBox_Cost.Text = "20000";
            }
            else if (Convert.ToInt32(textBox_Cost.Text) == 3)
            {
                textBox_Cost.Text = "25000";
            }
            else if (Convert.ToInt32(textBox_Cost.Text) == 4)
            {
                textBox_Cost.Text = "30000";
            }

            double added = Convert.ToDouble(textBox_Num.Text) * Convert.ToDouble(textBox_Cost.Text);
            textBox_AddedCost.Text = added.ToString();

            double tex = added / 10;
            textBox_Tex.Text = tex.ToString();
        }

        private void comboBox_List2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox list = sender as ComboBox;
            textBox_Cost2.Text = list.SelectedIndex.ToString();
            if (Convert.ToInt32(textBox_Cost2.Text) == 0)
            {
                textBox_Cost2.Text = "10000";
            }
            else if (Convert.ToInt32(textBox_Cost2.Text) == 1)
            {
                textBox_Cost2.Text = "15000";
            }
            else if (Convert.ToInt32(textBox_Cost2.Text) == 2)
            {
                textBox_Cost2.Text = "20000";
            }
            else if (Convert.ToInt32(textBox_Cost2.Text) == 3)
            {
                textBox_Cost2.Text = "25000";
            }
            else if (Convert.ToInt32(textBox_Cost2.Text) == 4)
            {
                textBox_Cost2.Text = "30000";
            }

            double added = Convert.ToDouble(textBox_Num2.Text) * Convert.ToDouble(textBox_Cost2.Text);
            textBox_AddedCost2.Text = added.ToString();

            double tex = added / 10;
            textBox_Tex2.Text = tex.ToString();
        }

        private void comboBox_List3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox list = sender as ComboBox;
            textBox_Cost3.Text = list.SelectedIndex.ToString();
            if (Convert.ToInt32(textBox_Cost3.Text) == 0)
            {
                textBox_Cost3.Text = "10000";
            }
            else if (Convert.ToInt32(textBox_Cost3.Text) == 1)
            {
                textBox_Cost3.Text = "15000";
            }
            else if (Convert.ToInt32(textBox_Cost3.Text) == 2)
            {
                textBox_Cost3.Text = "20000";
            }
            else if (Convert.ToInt32(textBox_Cost3.Text) == 3)
            {
                textBox_Cost3.Text = "25000";
            }
            else if (Convert.ToInt32(textBox_Cost3.Text) == 4)
            {
                textBox_Cost3.Text = "30000";
            }

            double added = Convert.ToDouble(textBox_Num3.Text) * Convert.ToDouble(textBox_Cost3.Text);
            textBox_AddedCost3.Text = added.ToString();

            double tex = added / 10;
            textBox_Tex3.Text = tex.ToString();
        }

        private void button_Sum_Click(object sender, EventArgs e)
        {
            double assde_sum = Convert.ToDouble(textBox_AddedCost.Text) +
                               Convert.ToDouble(textBox_AddedCost2.Text) +
                               Convert.ToDouble(textBox_AddedCost3.Text);
            textBox_AddedSum.Text = assde_sum.ToString();
            double tex_sum = Convert.ToDouble(textBox_Tex.Text) +
                             Convert.ToDouble(textBox_Tex2.Text) +
                             Convert.ToDouble(textBox_Tex3.Text);
            textBox_TexSum.Text = tex_sum.ToString();
            double sum = Convert.ToDouble(textBox_AddedSum.Text) +
                         Convert.ToDouble(textBox_TexSum.Text) +
                         Convert.ToDouble(textBox_AR.Text);
            textBox_Sum.Text = sum.ToString();
        }
    }
}
