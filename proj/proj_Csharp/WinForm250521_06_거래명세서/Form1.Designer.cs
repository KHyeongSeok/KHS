namespace WinForm250521_06_거래명세서
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
            this.comboBox_List = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Num = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Cost = new System.Windows.Forms.TextBox();
            this.textBox_AddedCost = new System.Windows.Forms.TextBox();
            this.textBox_Tex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Tex2 = new System.Windows.Forms.TextBox();
            this.textBox_AddedCost2 = new System.Windows.Forms.TextBox();
            this.textBox_Cost2 = new System.Windows.Forms.TextBox();
            this.textBox_Num2 = new System.Windows.Forms.TextBox();
            this.comboBox_List2 = new System.Windows.Forms.ComboBox();
            this.textBox_Tex3 = new System.Windows.Forms.TextBox();
            this.textBox_AddedCost3 = new System.Windows.Forms.TextBox();
            this.textBox_Cost3 = new System.Windows.Forms.TextBox();
            this.textBox_Num3 = new System.Windows.Forms.TextBox();
            this.comboBox_List3 = new System.Windows.Forms.ComboBox();
            this.textBox_AddedSum = new System.Windows.Forms.TextBox();
            this.textBox_TexSum = new System.Windows.Forms.TextBox();
            this.textBox_AR = new System.Windows.Forms.TextBox();
            this.textBox_Sum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_Sum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_List
            // 
            this.comboBox_List.FormattingEnabled = true;
            this.comboBox_List.Location = new System.Drawing.Point(139, 137);
            this.comboBox_List.Name = "comboBox_List";
            this.comboBox_List.Size = new System.Drawing.Size(316, 29);
            this.comboBox_List.TabIndex = 0;
            this.comboBox_List.SelectedIndexChanged += new System.EventHandler(this.comboBox_List_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "품목";
            // 
            // textBox_Num
            // 
            this.textBox_Num.Location = new System.Drawing.Point(488, 134);
            this.textBox_Num.Name = "textBox_Num";
            this.textBox_Num.Size = new System.Drawing.Size(100, 32);
            this.textBox_Num.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "수량";
            // 
            // textBox_Cost
            // 
            this.textBox_Cost.Location = new System.Drawing.Point(615, 134);
            this.textBox_Cost.Name = "textBox_Cost";
            this.textBox_Cost.ReadOnly = true;
            this.textBox_Cost.Size = new System.Drawing.Size(154, 32);
            this.textBox_Cost.TabIndex = 4;
            // 
            // textBox_AddedCost
            // 
            this.textBox_AddedCost.Location = new System.Drawing.Point(798, 137);
            this.textBox_AddedCost.Name = "textBox_AddedCost";
            this.textBox_AddedCost.ReadOnly = true;
            this.textBox_AddedCost.Size = new System.Drawing.Size(154, 32);
            this.textBox_AddedCost.TabIndex = 5;
            // 
            // textBox_Tex
            // 
            this.textBox_Tex.Location = new System.Drawing.Point(972, 137);
            this.textBox_Tex.Name = "textBox_Tex";
            this.textBox_Tex.ReadOnly = true;
            this.textBox_Tex.Size = new System.Drawing.Size(154, 32);
            this.textBox_Tex.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "단가";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(794, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "공급가액";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(968, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "세액";
            // 
            // textBox_Tex2
            // 
            this.textBox_Tex2.Location = new System.Drawing.Point(972, 183);
            this.textBox_Tex2.Name = "textBox_Tex2";
            this.textBox_Tex2.ReadOnly = true;
            this.textBox_Tex2.Size = new System.Drawing.Size(154, 32);
            this.textBox_Tex2.TabIndex = 14;
            // 
            // textBox_AddedCost2
            // 
            this.textBox_AddedCost2.Location = new System.Drawing.Point(798, 183);
            this.textBox_AddedCost2.Name = "textBox_AddedCost2";
            this.textBox_AddedCost2.ReadOnly = true;
            this.textBox_AddedCost2.Size = new System.Drawing.Size(154, 32);
            this.textBox_AddedCost2.TabIndex = 13;
            // 
            // textBox_Cost2
            // 
            this.textBox_Cost2.Location = new System.Drawing.Point(615, 180);
            this.textBox_Cost2.Name = "textBox_Cost2";
            this.textBox_Cost2.ReadOnly = true;
            this.textBox_Cost2.Size = new System.Drawing.Size(154, 32);
            this.textBox_Cost2.TabIndex = 12;
            // 
            // textBox_Num2
            // 
            this.textBox_Num2.Location = new System.Drawing.Point(488, 180);
            this.textBox_Num2.Name = "textBox_Num2";
            this.textBox_Num2.Size = new System.Drawing.Size(100, 32);
            this.textBox_Num2.TabIndex = 11;
            // 
            // comboBox_List2
            // 
            this.comboBox_List2.FormattingEnabled = true;
            this.comboBox_List2.Location = new System.Drawing.Point(139, 183);
            this.comboBox_List2.Name = "comboBox_List2";
            this.comboBox_List2.Size = new System.Drawing.Size(316, 29);
            this.comboBox_List2.TabIndex = 10;
            this.comboBox_List2.SelectedIndexChanged += new System.EventHandler(this.comboBox_List2_SelectedIndexChanged);
            // 
            // textBox_Tex3
            // 
            this.textBox_Tex3.Location = new System.Drawing.Point(972, 229);
            this.textBox_Tex3.Name = "textBox_Tex3";
            this.textBox_Tex3.ReadOnly = true;
            this.textBox_Tex3.Size = new System.Drawing.Size(154, 32);
            this.textBox_Tex3.TabIndex = 24;
            // 
            // textBox_AddedCost3
            // 
            this.textBox_AddedCost3.Location = new System.Drawing.Point(798, 229);
            this.textBox_AddedCost3.Name = "textBox_AddedCost3";
            this.textBox_AddedCost3.ReadOnly = true;
            this.textBox_AddedCost3.Size = new System.Drawing.Size(154, 32);
            this.textBox_AddedCost3.TabIndex = 23;
            // 
            // textBox_Cost3
            // 
            this.textBox_Cost3.Location = new System.Drawing.Point(615, 226);
            this.textBox_Cost3.Name = "textBox_Cost3";
            this.textBox_Cost3.ReadOnly = true;
            this.textBox_Cost3.Size = new System.Drawing.Size(154, 32);
            this.textBox_Cost3.TabIndex = 22;
            // 
            // textBox_Num3
            // 
            this.textBox_Num3.Location = new System.Drawing.Point(488, 226);
            this.textBox_Num3.Name = "textBox_Num3";
            this.textBox_Num3.Size = new System.Drawing.Size(100, 32);
            this.textBox_Num3.TabIndex = 21;
            // 
            // comboBox_List3
            // 
            this.comboBox_List3.FormattingEnabled = true;
            this.comboBox_List3.Location = new System.Drawing.Point(139, 229);
            this.comboBox_List3.Name = "comboBox_List3";
            this.comboBox_List3.Size = new System.Drawing.Size(316, 29);
            this.comboBox_List3.TabIndex = 20;
            this.comboBox_List3.SelectedIndexChanged += new System.EventHandler(this.comboBox_List3_SelectedIndexChanged);
            // 
            // textBox_AddedSum
            // 
            this.textBox_AddedSum.Location = new System.Drawing.Point(798, 309);
            this.textBox_AddedSum.Name = "textBox_AddedSum";
            this.textBox_AddedSum.ReadOnly = true;
            this.textBox_AddedSum.Size = new System.Drawing.Size(154, 32);
            this.textBox_AddedSum.TabIndex = 25;
            // 
            // textBox_TexSum
            // 
            this.textBox_TexSum.Location = new System.Drawing.Point(972, 309);
            this.textBox_TexSum.Name = "textBox_TexSum";
            this.textBox_TexSum.ReadOnly = true;
            this.textBox_TexSum.Size = new System.Drawing.Size(154, 32);
            this.textBox_TexSum.TabIndex = 26;
            // 
            // textBox_AR
            // 
            this.textBox_AR.Location = new System.Drawing.Point(972, 359);
            this.textBox_AR.Name = "textBox_AR";
            this.textBox_AR.Size = new System.Drawing.Size(154, 32);
            this.textBox_AR.TabIndex = 27;
            // 
            // textBox_Sum
            // 
            this.textBox_Sum.Location = new System.Drawing.Point(972, 409);
            this.textBox_Sum.Name = "textBox_Sum";
            this.textBox_Sum.ReadOnly = true;
            this.textBox_Sum.Size = new System.Drawing.Size(154, 32);
            this.textBox_Sum.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(879, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "미수금";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(717, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "합계";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(858, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 21);
            this.label8.TabIndex = 32;
            this.label8.Text = "합계금액";
            // 
            // button_Sum
            // 
            this.button_Sum.Location = new System.Drawing.Point(972, 462);
            this.button_Sum.Name = "button_Sum";
            this.button_Sum.Size = new System.Drawing.Size(154, 43);
            this.button_Sum.TabIndex = 33;
            this.button_Sum.Text = "합계 계산";
            this.button_Sum.UseVisualStyleBackColor = true;
            this.button_Sum.Click += new System.EventHandler(this.button_Sum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 661);
            this.Controls.Add(this.button_Sum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Sum);
            this.Controls.Add(this.textBox_AR);
            this.Controls.Add(this.textBox_TexSum);
            this.Controls.Add(this.textBox_AddedSum);
            this.Controls.Add(this.textBox_Tex3);
            this.Controls.Add(this.textBox_AddedCost3);
            this.Controls.Add(this.textBox_Cost3);
            this.Controls.Add(this.textBox_Num3);
            this.Controls.Add(this.comboBox_List3);
            this.Controls.Add(this.textBox_Tex2);
            this.Controls.Add(this.textBox_AddedCost2);
            this.Controls.Add(this.textBox_Cost2);
            this.Controls.Add(this.textBox_Num2);
            this.Controls.Add(this.comboBox_List2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Tex);
            this.Controls.Add(this.textBox_AddedCost);
            this.Controls.Add(this.textBox_Cost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_List);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Cost;
        private System.Windows.Forms.TextBox textBox_AddedCost;
        private System.Windows.Forms.TextBox textBox_Tex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Tex2;
        private System.Windows.Forms.TextBox textBox_AddedCost2;
        private System.Windows.Forms.TextBox textBox_Cost2;
        private System.Windows.Forms.TextBox textBox_Num2;
        private System.Windows.Forms.ComboBox comboBox_List2;
        private System.Windows.Forms.TextBox textBox_Tex3;
        private System.Windows.Forms.TextBox textBox_AddedCost3;
        private System.Windows.Forms.TextBox textBox_Cost3;
        private System.Windows.Forms.TextBox textBox_Num3;
        private System.Windows.Forms.ComboBox comboBox_List3;
        private System.Windows.Forms.TextBox textBox_AddedSum;
        private System.Windows.Forms.TextBox textBox_TexSum;
        private System.Windows.Forms.TextBox textBox_AR;
        private System.Windows.Forms.TextBox textBox_Sum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_Sum;
    }
}

