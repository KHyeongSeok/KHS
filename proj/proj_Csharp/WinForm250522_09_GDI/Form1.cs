using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm250522_09_GDI
{
    enum DrawMode { LINE, RECTANGLE, CIRCLE, CURVED_LINE };
    public partial class Form1 : Form
    {
        private DrawMode drawMode;
        private Graphics g;
        private Pen pen = new Pen(Color.Black, 2);
        private Pen eraser;
        Point startP, endP, currP, prevP; // 시작점, 끝점, 현재 위치, 이전 위치

        private void 사각형ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawMode = DrawMode.RECTANGLE;
            toolStripStatusLaBel1.Text = "Rectangle Mode";
        }

        private void 원ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawMode = DrawMode.CIRCLE;
            toolStripStatusLaBel1.Text = "Circle Mode";
        }

        private void 곡선ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawMode = DrawMode.CURVED_LINE;
            toolStripStatusLaBel1.Text = "Curved Line Mode";
        }

        private void 색깔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialeg = new ColorDialog();
            if (colorDialeg.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialeg.Color;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            startP = new Point(e.X, e.Y);
            prevP = startP;
            currP = startP;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            prevP = currP;
            currP = new Point(e.X, e.Y);

            switch (drawMode)
            {
                case DrawMode.LINE:
                    g.DrawLine(eraser, startP, prevP);
                    g.DrawLine(pen, startP, currP);
                    break;
                case DrawMode.RECTANGLE:
                    g.DrawRectangle(eraser, new Rectangle(startP,
                        new Size(prevP.X - startP.X, prevP.Y - startP.Y)));
                    g.DrawRectangle(pen, new Rectangle(startP,
                        new Size(currP.X - startP.X, currP.Y - startP.Y)));
                    break;
                case DrawMode.CIRCLE:
                    g.DrawEllipse(eraser, new Rectangle(startP,
                        new Size(prevP.X - startP.X, prevP.Y - startP.Y)));
                    g.DrawEllipse(pen, new Rectangle(startP,
                        new Size(currP.X - startP.X, currP.Y - startP.Y)));
                    break;
                case DrawMode.CURVED_LINE:
                    g.DrawLine(pen, prevP, currP);
                    break;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            endP = new Point(e.X, e.Y);
            switch (drawMode)
            {
                case DrawMode.LINE:
                    g.DrawLine(pen, startP, endP);
                    break;
                case DrawMode.RECTANGLE:
                    g.DrawRectangle(pen, new Rectangle(startP,
                       new Size(endP.X - startP.X, endP.Y - startP.Y)));
                    break;
                case DrawMode.CIRCLE:
                    g.DrawEllipse(pen, new Rectangle(startP,
                       new Size(endP.X - startP.X, endP.Y - startP.Y)));
                    break;
                case DrawMode.CURVED_LINE:
                    break;
            }
        }

        private void 선ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawMode = DrawMode.LINE;
            toolStripStatusLaBel1.Text = "Line Mode";
        }

        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            toolStripStatusLaBel1.Text = "Line Mode";
            this.BackColor = Color.White;
            this.eraser = new Pen(this.BackColor, 2);
            // 배경 이미지 불러오기
            string filePath = "../../Images/BackGround.jpg";
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // 폼이 다시 그려질 때마다 호출됨
            Graphics g = e.Graphics;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
