using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm250522_01_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myListView.GridLines = true; // 리스트뷰에 그리드 라인을 표시
            myListView.FullRowSelect = true; // 리스트 아이템을 선택할 때 한 줄이 다 선택되게 해줌

            myListView.Columns.Add("제품명", 150);
            myListView.Columns.Add("단가", 100, HorizontalAlignment.Right);
            myListView.Columns.Add("수량", 70, HorizontalAlignment.Right);
            myListView.Columns.Add("금액", 100, HorizontalAlignment.Right); // 리스트뷰에 컬럼 코드상으로 생성

            ListViewItem item1 = new ListViewItem("Access", 0);
            ListViewItem item2 = new ListViewItem("Excel", 1);
            ListViewItem item3 = new ListViewItem("PowerPoint", 2);
            ListViewItem item4 = new ListViewItem("Word", 3);

            item1.SubItems.Add("22,000");
            item1.SubItems.Add("30");
            item1.SubItems.Add("660,000");
            item2.SubItems.Add("33,000");
            item2.SubItems.Add("50");
            item2.SubItems.Add("1,650,000");
            item3.SubItems.Add("11,000");
            item3.SubItems.Add("50");
            item3.SubItems.Add("550,000");
            item4.SubItems.Add("22,000");
            item4.SubItems.Add("30");
            item4.SubItems.Add("660,000");
            myListView.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4 }); // 생성한 컬럼에 세부항목 생성

            ImageList sImageList = new ImageList();
            sImageList.ImageSize = new Size(24, 24);
            ImageList lImageList = new ImageList();
            lImageList.ImageSize = new Size(64, 64);

            myListView.SmallImageList = sImageList;
            myListView.LargeImageList = lImageList; // 스몰과 라지 크기 지정

            sImageList.Images.Add(Bitmap.FromFile(@"../../Image/access.png"));
            sImageList.Images.Add(Bitmap.FromFile(@"../../Image/excel.png"));
            sImageList.Images.Add(Bitmap.FromFile(@"../../Image/ppt.png"));
            sImageList.Images.Add(Bitmap.FromFile(@"../../Image/word.png"));

            lImageList.Images.Add(Bitmap.FromFile(@"../../Image/access.png"));
            lImageList.Images.Add(Bitmap.FromFile(@"../../Image/excel.png"));
            lImageList.Images.Add(Bitmap.FromFile(@"../../Image/ppt.png"));
            lImageList.Images.Add(Bitmap.FromFile(@"../../Image/word.png")); // 프로젝트 폴더에 있는 이미지를 불러옴
        }

        private void radioButton_Detail_CheckedChanged(object sender, EventArgs e)
        {
            myListView.View = View.Details; // 리스트뷰에 생성한 컬럼들을 다 보여줌
        }

        private void radioButton_List_CheckedChanged(object sender, EventArgs e)
        {
            myListView.View = View.List; // 스몰로 지정한 크기로 아이콘과 이름이 보임
        }

        private void radioButton_Small_CheckedChanged(object sender, EventArgs e)
        {
            myListView.View = View.SmallIcon; // 리스트와 동일 하지만 열로 나란히 정렬
        }

        private void radioButton_Large_CheckedChanged(object sender, EventArgs e)
        {
            myListView.View = View.LargeIcon; // 라지로 지정한 크기로 아이콘과 이름이 보임
        }

        private void myListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 리스트뷰에서 아이템을 선택하면 selected 택스트 박스에 SubItems 배열의 내용을 텍스트로 표시
            textBox_Selected.Text = "";
            ListView.SelectedListViewItemCollection selected = myListView.SelectedItems;

            foreach (ListViewItem item in selected)
            {
                for (int i = 0; i < 4; i++)
                    textBox_Selected.Text += item.SubItems[i].Text + "\t";
            }
        }
    }
}
