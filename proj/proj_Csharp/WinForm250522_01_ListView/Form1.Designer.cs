namespace WinForm250522_01_ListView
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
            this.components = new System.ComponentModel.Container();
            this.myListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Selected = new System.Windows.Forms.TextBox();
            this.radioButton_Detail = new System.Windows.Forms.RadioButton();
            this.radioButton_List = new System.Windows.Forms.RadioButton();
            this.radioButton_Small = new System.Windows.Forms.RadioButton();
            this.radioButton_Large = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // myListView
            // 
            this.myListView.HideSelection = false;
            this.myListView.Location = new System.Drawing.Point(71, 93);
            this.myListView.Name = "myListView";
            this.myListView.Size = new System.Drawing.Size(749, 431);
            this.myListView.TabIndex = 0;
            this.myListView.UseCompatibleStateImageBehavior = false;
            this.myListView.SelectedIndexChanged += new System.EventHandler(this.myListView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 559);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected:";
            // 
            // textBox_Selected
            // 
            this.textBox_Selected.Location = new System.Drawing.Point(404, 556);
            this.textBox_Selected.Name = "textBox_Selected";
            this.textBox_Selected.Size = new System.Drawing.Size(416, 32);
            this.textBox_Selected.TabIndex = 2;
            // 
            // radioButton_Detail
            // 
            this.radioButton_Detail.AutoSize = true;
            this.radioButton_Detail.Location = new System.Drawing.Point(130, 44);
            this.radioButton_Detail.Name = "radioButton_Detail";
            this.radioButton_Detail.Size = new System.Drawing.Size(98, 25);
            this.radioButton_Detail.TabIndex = 3;
            this.radioButton_Detail.TabStop = true;
            this.radioButton_Detail.Text = "자세히";
            this.radioButton_Detail.UseVisualStyleBackColor = true;
            this.radioButton_Detail.CheckedChanged += new System.EventHandler(this.radioButton_Detail_CheckedChanged);
            // 
            // radioButton_List
            // 
            this.radioButton_List.AutoSize = true;
            this.radioButton_List.Location = new System.Drawing.Point(276, 44);
            this.radioButton_List.Name = "radioButton_List";
            this.radioButton_List.Size = new System.Drawing.Size(98, 25);
            this.radioButton_List.TabIndex = 4;
            this.radioButton_List.TabStop = true;
            this.radioButton_List.Text = "리스트";
            this.radioButton_List.UseVisualStyleBackColor = true;
            this.radioButton_List.CheckedChanged += new System.EventHandler(this.radioButton_List_CheckedChanged);
            // 
            // radioButton_Small
            // 
            this.radioButton_Small.AutoSize = true;
            this.radioButton_Small.Location = new System.Drawing.Point(421, 44);
            this.radioButton_Small.Name = "radioButton_Small";
            this.radioButton_Small.Size = new System.Drawing.Size(147, 25);
            this.radioButton_Small.TabIndex = 6;
            this.radioButton_Small.TabStop = true;
            this.radioButton_Small.Text = "작은 아이콘";
            this.radioButton_Small.UseVisualStyleBackColor = true;
            this.radioButton_Small.CheckedChanged += new System.EventHandler(this.radioButton_Small_CheckedChanged);
            // 
            // radioButton_Large
            // 
            this.radioButton_Large.AutoSize = true;
            this.radioButton_Large.Location = new System.Drawing.Point(618, 44);
            this.radioButton_Large.Name = "radioButton_Large";
            this.radioButton_Large.Size = new System.Drawing.Size(126, 25);
            this.radioButton_Large.TabIndex = 8;
            this.radioButton_Large.TabStop = true;
            this.radioButton_Large.Text = "큰 아이콘";
            this.radioButton_Large.UseVisualStyleBackColor = true;
            this.radioButton_Large.CheckedChanged += new System.EventHandler(this.radioButton_Large_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 638);
            this.Controls.Add(this.radioButton_Large);
            this.Controls.Add(this.radioButton_Small);
            this.Controls.Add(this.radioButton_List);
            this.Controls.Add(this.radioButton_Detail);
            this.Controls.Add(this.textBox_Selected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myListView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView myListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Selected;
        private System.Windows.Forms.RadioButton radioButton_Detail;
        private System.Windows.Forms.RadioButton radioButton_List;
        private System.Windows.Forms.RadioButton radioButton_Small;
        private System.Windows.Forms.RadioButton radioButton_Large;
        private System.Windows.Forms.ImageList imageList1;
    }
}

