using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm250522_02_TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // 이미지가 좌우 비율을 유지한채로 픽처박스에 가득차게 그려주는 모드

            TreeNode root = new TreeNode("반도체 라인"); // 트리노드 가상 상위 노드 생성

            TreeNode proc1_dieBonding = new TreeNode("Die 본딩");
            TreeNode proc2_wireBonding = new TreeNode("Wire 본딩");
            TreeNode proc3_packaging = new TreeNode("패키징"); // 트리노드 생성

            root.Nodes.Add(proc1_dieBonding); // 가장 상위 노드의 서브 노드로 설정
            proc1_dieBonding.Nodes.Add("die bonder1"); // 추가 서브 노드로 설정
            proc1_dieBonding.Nodes.Add("die bonder2");
            root.Nodes.Add(proc2_wireBonding);
            proc2_wireBonding.Nodes.Add("wire bonder1");
            proc2_wireBonding.Nodes.Add("wire bonder2");
            root.Nodes.Add(proc3_packaging);
            proc3_packaging.Nodes.Add("packaging machine1");
            proc3_packaging.Nodes.Add("packaging machine2");

            treeView1.Nodes.Add(root); // 트리노드에 생성된 노드를 추가
            treeView1.ExpandAll(); // 모든 서브 노드가 보이도록 확장 시킴
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // 노드를 클릭 할때마다 픽처박스에 이미지를 표시하고 텍스트박스에 설명을 표시
            if ( e.Node.Text == "die bonder1")
            {
                pictureBox1.Image = Bitmap.FromFile("../../Images/다이본더.jpg");
                textBox_Memo.Text = "잘 동작 합니다.";
            }
            else if ( e.Node.Text == "die bonder2")
            {
                pictureBox1.Image = Bitmap.FromFile("../../Images/다이본더.jpg");
                textBox_Memo.Text = "소모성 부품 교체 필요 합니다. 아직 잘 동작 합니다.";
            }
            else if (e.Node.Text == "wire bonder1")
            {
                pictureBox1.Image = Bitmap.FromFile("../../Images/와이어본더.jpg");
                textBox_Memo.Text = "오차가 늘고 있습니다.";
            }
            else if (e.Node.Text == "wire bonder2")
            {
                pictureBox1.Image = Bitmap.FromFile("../../Images/와이어본더.jpg");
                textBox_Memo.Text = "와이어 카트리지 교체가 필요합니다.";
            }
            else if (e.Node.Text == "packaging machine1")
            {
                pictureBox1.Image = Bitmap.FromFile("../../Images/패키징머신.jpg");
                textBox_Memo.Text = "잘 동작 합니다.";
            }
            else if (e.Node.Text == "packaging machine2")
            {
                pictureBox1.Image = Bitmap.FromFile("../../Images/패키징머신.jpg");
                textBox_Memo.Text = "온도가 너무 높습니다.";
            }
        }
    }
}
