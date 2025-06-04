namespace WinForm250520_성적계산기
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_kor = new System.Windows.Forms.TextBox();
            this.textBox_math = new System.Windows.Forms.TextBox();
            this.textBox_Eng = new System.Windows.Forms.TextBox();
            this.textBox_sum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_avg = new System.Windows.Forms.TextBox();
            this.button_result = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Eng);
            this.groupBox1.Controls.Add(this.textBox_math);
            this.groupBox1.Controls.Add(this.textBox_kor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(43, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "성적입력";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_avg);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_sum);
            this.groupBox2.Location = new System.Drawing.Point(434, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "국어";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "수학";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "영어";
            // 
            // textBox_kor
            // 
            this.textBox_kor.Location = new System.Drawing.Point(120, 76);
            this.textBox_kor.Name = "textBox_kor";
            this.textBox_kor.Size = new System.Drawing.Size(100, 32);
            this.textBox_kor.TabIndex = 4;
            this.textBox_kor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_math
            // 
            this.textBox_math.Location = new System.Drawing.Point(120, 145);
            this.textBox_math.Name = "textBox_math";
            this.textBox_math.Size = new System.Drawing.Size(100, 32);
            this.textBox_math.TabIndex = 5;
            this.textBox_math.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Eng
            // 
            this.textBox_Eng.Location = new System.Drawing.Point(120, 214);
            this.textBox_Eng.Name = "textBox_Eng";
            this.textBox_Eng.Size = new System.Drawing.Size(100, 32);
            this.textBox_Eng.TabIndex = 6;
            this.textBox_Eng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_sum
            // 
            this.textBox_sum.Location = new System.Drawing.Point(135, 52);
            this.textBox_sum.Name = "textBox_sum";
            this.textBox_sum.ReadOnly = true;
            this.textBox_sum.Size = new System.Drawing.Size(100, 32);
            this.textBox_sum.TabIndex = 7;
            this.textBox_sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "총점";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "평균";
            // 
            // textBox_avg
            // 
            this.textBox_avg.Location = new System.Drawing.Point(135, 105);
            this.textBox_avg.Name = "textBox_avg";
            this.textBox_avg.ReadOnly = true;
            this.textBox_avg.Size = new System.Drawing.Size(100, 32);
            this.textBox_avg.TabIndex = 9;
            this.textBox_avg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_result
            // 
            this.button_result.Location = new System.Drawing.Point(548, 264);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(146, 93);
            this.button_result.TabIndex = 2;
            this.button_result.Text = "계산";
            this.button_result.UseVisualStyleBackColor = true;
            this.button_result.Click += new System.EventHandler(this.button_result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_result);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "성적계산기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Eng;
        private System.Windows.Forms.TextBox textBox_math;
        private System.Windows.Forms.TextBox textBox_kor;
        private System.Windows.Forms.TextBox textBox_avg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_sum;
        private System.Windows.Forms.Button button_result;
    }
}

