namespace WinForm250522_09_GDI
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripStatusLaBel1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.선ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사각형ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.원ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.곡선ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.색깔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLaBel1
            // 
            this.toolStripStatusLaBel1.AutoSize = true;
            this.toolStripStatusLaBel1.Location = new System.Drawing.Point(12, 592);
            this.toolStripStatusLaBel1.Name = "toolStripStatusLaBel1";
            this.toolStripStatusLaBel1.Size = new System.Drawing.Size(198, 21);
            this.toolStripStatusLaBel1.TabIndex = 0;
            this.toolStripStatusLaBel1.Text = "ToolStripStatusLaBel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.선ToolStripMenuItem,
            this.사각형ToolStripMenuItem,
            this.원ToolStripMenuItem,
            this.곡선ToolStripMenuItem,
            this.색깔ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 선ToolStripMenuItem
            // 
            this.선ToolStripMenuItem.Name = "선ToolStripMenuItem";
            this.선ToolStripMenuItem.Size = new System.Drawing.Size(52, 38);
            this.선ToolStripMenuItem.Text = "선";
            this.선ToolStripMenuItem.Click += new System.EventHandler(this.선ToolStripMenuItem_Click);
            // 
            // 사각형ToolStripMenuItem
            // 
            this.사각형ToolStripMenuItem.Name = "사각형ToolStripMenuItem";
            this.사각형ToolStripMenuItem.Size = new System.Drawing.Size(94, 38);
            this.사각형ToolStripMenuItem.Text = "사각형";
            this.사각형ToolStripMenuItem.Click += new System.EventHandler(this.사각형ToolStripMenuItem_Click);
            // 
            // 원ToolStripMenuItem
            // 
            this.원ToolStripMenuItem.Name = "원ToolStripMenuItem";
            this.원ToolStripMenuItem.Size = new System.Drawing.Size(52, 38);
            this.원ToolStripMenuItem.Text = "원";
            this.원ToolStripMenuItem.Click += new System.EventHandler(this.원ToolStripMenuItem_Click);
            // 
            // 곡선ToolStripMenuItem
            // 
            this.곡선ToolStripMenuItem.Name = "곡선ToolStripMenuItem";
            this.곡선ToolStripMenuItem.Size = new System.Drawing.Size(73, 38);
            this.곡선ToolStripMenuItem.Text = "곡선";
            this.곡선ToolStripMenuItem.Click += new System.EventHandler(this.곡선ToolStripMenuItem_Click);
            // 
            // 색깔ToolStripMenuItem
            // 
            this.색깔ToolStripMenuItem.Name = "색깔ToolStripMenuItem";
            this.색깔ToolStripMenuItem.Size = new System.Drawing.Size(73, 38);
            this.색깔ToolStripMenuItem.Text = "색깔";
            this.색깔ToolStripMenuItem.Click += new System.EventHandler(this.색깔ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 621);
            this.Controls.Add(this.toolStripStatusLaBel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label toolStripStatusLaBel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 선ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사각형ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 원ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 곡선ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 색깔ToolStripMenuItem;
    }
}

