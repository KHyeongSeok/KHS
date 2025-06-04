namespace OneDayProject2
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSearchType = new System.Windows.Forms.ComboBox();
            this.textBoxSearchKeyword = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listViewBooks = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonbdel = new System.Windows.Forms.Button();
            this.buttonbadd = new System.Windows.Forms.Button();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.btnMy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "검색 기준:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSearchType
            // 
            this.comboBoxSearchType.FormattingEnabled = true;
            this.comboBoxSearchType.Items.AddRange(new object[] {
            "제목",
            "저자",
            "출판사"});
            this.comboBoxSearchType.Location = new System.Drawing.Point(167, 65);
            this.comboBoxSearchType.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBoxSearchType.Name = "comboBoxSearchType";
            this.comboBoxSearchType.Size = new System.Drawing.Size(136, 29);
            this.comboBoxSearchType.TabIndex = 1;
            // 
            // textBoxSearchKeyword
            // 
            this.textBoxSearchKeyword.Location = new System.Drawing.Point(336, 65);
            this.textBoxSearchKeyword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxSearchKeyword.Name = "textBoxSearchKeyword";
            this.textBoxSearchKeyword.Size = new System.Drawing.Size(411, 32);
            this.textBoxSearchKeyword.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(773, 61);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(123, 38);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "검색";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listViewBooks
            // 
            this.listViewBooks.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewBooks.FullRowSelect = true;
            this.listViewBooks.GridLines = true;
            this.listViewBooks.HideSelection = false;
            this.listViewBooks.Location = new System.Drawing.Point(44, 130);
            this.listViewBooks.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listViewBooks.Name = "listViewBooks";
            this.listViewBooks.Size = new System.Drawing.Size(900, 489);
            this.listViewBooks.TabIndex = 4;
            this.listViewBooks.UseCompatibleStateImageBehavior = false;
            this.listViewBooks.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 642);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "로그아웃";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonbdel
            // 
            this.buttonbdel.Location = new System.Drawing.Point(297, 642);
            this.buttonbdel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonbdel.Name = "buttonbdel";
            this.buttonbdel.Size = new System.Drawing.Size(220, 38);
            this.buttonbdel.TabIndex = 6;
            this.buttonbdel.Text = "도서삭제";
            this.buttonbdel.UseVisualStyleBackColor = true;
            this.buttonbdel.Click += new System.EventHandler(this.buttonbdel_Click);
            // 
            // buttonbadd
            // 
            this.buttonbadd.Location = new System.Drawing.Point(50, 642);
            this.buttonbadd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonbadd.Name = "buttonbadd";
            this.buttonbadd.Size = new System.Drawing.Size(220, 38);
            this.buttonbadd.TabIndex = 7;
            this.buttonbadd.Text = "도서추가";
            this.buttonbadd.UseVisualStyleBackColor = true;
            this.buttonbadd.Click += new System.EventHandler(this.buttonbadd_Click);
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Location = new System.Drawing.Point(19, 16);
            this.labelPlayerName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(136, 21);
            this.labelPlayerName.TabIndex = 8;
            this.labelPlayerName.Text = "접속인물표시";
            this.labelPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMy
            // 
            this.btnMy.Location = new System.Drawing.Point(848, 7);
            this.btnMy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnMy.Name = "btnMy";
            this.btnMy.Size = new System.Drawing.Size(123, 38);
            this.btnMy.TabIndex = 9;
            this.btnMy.Text = "내정보";
            this.btnMy.UseVisualStyleBackColor = true;
            this.btnMy.Click += new System.EventHandler(this.btnMy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 719);
            this.Controls.Add(this.btnMy);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.buttonbadd);
            this.Controls.Add(this.buttonbdel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewBooks);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchKeyword);
            this.Controls.Add(this.comboBoxSearchType);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "도서 검색 프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSearchType;
        private System.Windows.Forms.TextBox textBoxSearchKeyword;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListView listViewBooks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonbdel;
        private System.Windows.Forms.Button buttonbadd;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Button btnMy;
    }
}

