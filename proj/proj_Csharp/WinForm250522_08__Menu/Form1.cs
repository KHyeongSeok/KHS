using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm250522_08__Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // 메뉴에서 "끝내기" 클릭 시 프로그램 종료
        }

        private void 폰트ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 폰트 메뉴를 선택 했을 시 FontDialog(글꼴)설정창을 나타내어 폰트를 설정
            FontDialog fDlg = new FontDialog();
            fDlg.ShowColor = true;
            fDlg.ShowEffects = true;
            fDlg.Font = label1.Font;
            fDlg.Color = label1.ForeColor;
            if(fDlg.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fDlg.Font;
                label1.ForeColor = fDlg.Color;
            }
        }

        private void 배경색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 배경 메뉴를 선택 했을 시 ColorDialog(색)설정창을 나타내어 배경색 설정
            ColorDialog cDlg = new ColorDialog();
            if(cDlg.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = cDlg.Color;
            }
        }
    }
}
