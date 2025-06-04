namespace WinForm250520_CheckAnsRadio
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
            this.checkBox_seatHeater = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_rearseatFolding = new System.Windows.Forms.CheckBox();
            this.checkBox_smartKey = new System.Windows.Forms.CheckBox();
            this.label_options = new System.Windows.Forms.Label();
            this.radioButton15inch = new System.Windows.Forms.RadioButton();
            this.radioButton16inch = new System.Windows.Forms.RadioButton();
            this.radioButton17inch = new System.Windows.Forms.RadioButton();
            this.groupBoxWheel = new System.Windows.Forms.GroupBox();
            this.label_wheel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_red = new System.Windows.Forms.RadioButton();
            this.radioButton_white = new System.Windows.Forms.RadioButton();
            this.radioButton_balck = new System.Windows.Forms.RadioButton();
            this.label_color = new System.Windows.Forms.Label();
            this.groupBoxWheel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_seatHeater
            // 
            this.checkBox_seatHeater.AutoSize = true;
            this.checkBox_seatHeater.Location = new System.Drawing.Point(113, 144);
            this.checkBox_seatHeater.Name = "checkBox_seatHeater";
            this.checkBox_seatHeater.Size = new System.Drawing.Size(127, 25);
            this.checkBox_seatHeater.TabIndex = 0;
            this.checkBox_seatHeater.Text = "열선 시트";
            this.checkBox_seatHeater.UseVisualStyleBackColor = true;
            this.checkBox_seatHeater.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "옵션을 선택합니다";
            // 
            // checkBox_rearseatFolding
            // 
            this.checkBox_rearseatFolding.AutoSize = true;
            this.checkBox_rearseatFolding.Location = new System.Drawing.Point(113, 175);
            this.checkBox_rearseatFolding.Name = "checkBox_rearseatFolding";
            this.checkBox_rearseatFolding.Size = new System.Drawing.Size(148, 25);
            this.checkBox_rearseatFolding.TabIndex = 2;
            this.checkBox_rearseatFolding.Text = "뒷자석 폴딩";
            this.checkBox_rearseatFolding.UseVisualStyleBackColor = true;
            this.checkBox_rearseatFolding.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox_smartKey
            // 
            this.checkBox_smartKey.AutoSize = true;
            this.checkBox_smartKey.Location = new System.Drawing.Point(113, 206);
            this.checkBox_smartKey.Name = "checkBox_smartKey";
            this.checkBox_smartKey.Size = new System.Drawing.Size(127, 25);
            this.checkBox_smartKey.TabIndex = 3;
            this.checkBox_smartKey.Text = "스마트 키";
            this.checkBox_smartKey.UseVisualStyleBackColor = true;
            this.checkBox_smartKey.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // label_options
            // 
            this.label_options.AutoSize = true;
            this.label_options.Location = new System.Drawing.Point(182, 279);
            this.label_options.Name = "label_options";
            this.label_options.Size = new System.Drawing.Size(129, 21);
            this.label_options.TabIndex = 4;
            this.label_options.Text = "선택된 옵션:";
            // 
            // radioButton15inch
            // 
            this.radioButton15inch.AutoSize = true;
            this.radioButton15inch.Location = new System.Drawing.Point(40, 37);
            this.radioButton15inch.Name = "radioButton15inch";
            this.radioButton15inch.Size = new System.Drawing.Size(127, 25);
            this.radioButton15inch.TabIndex = 5;
            this.radioButton15inch.TabStop = true;
            this.radioButton15inch.Text = "휠 15인치";
            this.radioButton15inch.UseVisualStyleBackColor = true;
            this.radioButton15inch.CheckedChanged += new System.EventHandler(this.radioButtonWheel_CheckedChanged);
            // 
            // radioButton16inch
            // 
            this.radioButton16inch.AutoSize = true;
            this.radioButton16inch.Location = new System.Drawing.Point(40, 68);
            this.radioButton16inch.Name = "radioButton16inch";
            this.radioButton16inch.Size = new System.Drawing.Size(127, 25);
            this.radioButton16inch.TabIndex = 6;
            this.radioButton16inch.TabStop = true;
            this.radioButton16inch.Text = "휠 16인치";
            this.radioButton16inch.UseVisualStyleBackColor = true;
            this.radioButton16inch.CheckedChanged += new System.EventHandler(this.radioButtonWheel_CheckedChanged);
            // 
            // radioButton17inch
            // 
            this.radioButton17inch.AutoSize = true;
            this.radioButton17inch.Location = new System.Drawing.Point(40, 99);
            this.radioButton17inch.Name = "radioButton17inch";
            this.radioButton17inch.Size = new System.Drawing.Size(127, 25);
            this.radioButton17inch.TabIndex = 7;
            this.radioButton17inch.TabStop = true;
            this.radioButton17inch.Text = "휠 17인치";
            this.radioButton17inch.UseVisualStyleBackColor = true;
            this.radioButton17inch.CheckedChanged += new System.EventHandler(this.radioButtonWheel_CheckedChanged);
            // 
            // groupBoxWheel
            // 
            this.groupBoxWheel.Controls.Add(this.radioButton17inch);
            this.groupBoxWheel.Controls.Add(this.radioButton16inch);
            this.groupBoxWheel.Controls.Add(this.radioButton15inch);
            this.groupBoxWheel.Location = new System.Drawing.Point(419, 107);
            this.groupBoxWheel.Name = "groupBoxWheel";
            this.groupBoxWheel.Size = new System.Drawing.Size(220, 156);
            this.groupBoxWheel.TabIndex = 8;
            this.groupBoxWheel.TabStop = false;
            this.groupBoxWheel.Text = "휠 선택";
            // 
            // label_wheel
            // 
            this.label_wheel.AutoSize = true;
            this.label_wheel.Location = new System.Drawing.Point(182, 300);
            this.label_wheel.Name = "label_wheel";
            this.label_wheel.Size = new System.Drawing.Size(108, 21);
            this.label_wheel.TabIndex = 9;
            this.label_wheel.Text = "선택된 휠:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_balck);
            this.groupBox1.Controls.Add(this.radioButton_white);
            this.groupBox1.Controls.Add(this.radioButton_red);
            this.groupBox1.Location = new System.Drawing.Point(728, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 156);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "색상 선택";
            // 
            // radioButton_red
            // 
            this.radioButton_red.AutoSize = true;
            this.radioButton_red.Location = new System.Drawing.Point(42, 36);
            this.radioButton_red.Name = "radioButton_red";
            this.radioButton_red.Size = new System.Drawing.Size(61, 25);
            this.radioButton_red.TabIndex = 6;
            this.radioButton_red.TabStop = true;
            this.radioButton_red.Text = "red";
            this.radioButton_red.UseVisualStyleBackColor = true;
            this.radioButton_red.CheckedChanged += new System.EventHandler(this.radioButton_color_CheckedChanged);
            // 
            // radioButton_white
            // 
            this.radioButton_white.AutoSize = true;
            this.radioButton_white.Location = new System.Drawing.Point(42, 68);
            this.radioButton_white.Name = "radioButton_white";
            this.radioButton_white.Size = new System.Drawing.Size(79, 25);
            this.radioButton_white.TabIndex = 7;
            this.radioButton_white.TabStop = true;
            this.radioButton_white.Text = "white";
            this.radioButton_white.UseVisualStyleBackColor = true;
            this.radioButton_white.CheckedChanged += new System.EventHandler(this.radioButton_color_CheckedChanged);
            // 
            // radioButton_balck
            // 
            this.radioButton_balck.AutoSize = true;
            this.radioButton_balck.Location = new System.Drawing.Point(42, 98);
            this.radioButton_balck.Name = "radioButton_balck";
            this.radioButton_balck.Size = new System.Drawing.Size(78, 25);
            this.radioButton_balck.TabIndex = 8;
            this.radioButton_balck.TabStop = true;
            this.radioButton_balck.Text = "black";
            this.radioButton_balck.UseVisualStyleBackColor = true;
            this.radioButton_balck.CheckedChanged += new System.EventHandler(this.radioButton_color_CheckedChanged);
            // 
            // label_color
            // 
            this.label_color.AutoSize = true;
            this.label_color.Location = new System.Drawing.Point(182, 321);
            this.label_color.Name = "label_color";
            this.label_color.Size = new System.Drawing.Size(129, 21);
            this.label_color.TabIndex = 11;
            this.label_color.Text = "선택된 색상:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 667);
            this.Controls.Add(this.label_color);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_wheel);
            this.Controls.Add(this.groupBoxWheel);
            this.Controls.Add(this.label_options);
            this.Controls.Add(this.checkBox_smartKey);
            this.Controls.Add(this.checkBox_rearseatFolding);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_seatHeater);
            this.Name = "Form1";
            this.Text = "checkbox와 radio";
            this.groupBoxWheel.ResumeLayout(false);
            this.groupBoxWheel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_seatHeater;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_rearseatFolding;
        private System.Windows.Forms.CheckBox checkBox_smartKey;
        private System.Windows.Forms.Label label_options;
        private System.Windows.Forms.RadioButton radioButton15inch;
        private System.Windows.Forms.RadioButton radioButton16inch;
        private System.Windows.Forms.RadioButton radioButton17inch;
        private System.Windows.Forms.GroupBox groupBoxWheel;
        private System.Windows.Forms.Label label_wheel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_white;
        private System.Windows.Forms.RadioButton radioButton_red;
        private System.Windows.Forms.Label label_color;
        private System.Windows.Forms.RadioButton radioButton_balck;
    }
}

