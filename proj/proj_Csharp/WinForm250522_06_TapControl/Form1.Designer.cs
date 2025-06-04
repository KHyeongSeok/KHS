namespace WinForm250522_06_TapControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_AlarmSet = new System.Windows.Forms.TabPage();
            this.btnReSet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.tabPage_Watch = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbAlarmSet = new System.Windows.Forms.Label();
            this.lbAlarm = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage_AlarmSet.SuspendLayout();
            this.tabPage_Watch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_AlarmSet);
            this.tabControl1.Controls.Add(this.tabPage_Watch);
            this.tabControl1.Location = new System.Drawing.Point(58, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 465);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_AlarmSet
            // 
            this.tabPage_AlarmSet.Controls.Add(this.btnReSet);
            this.tabPage_AlarmSet.Controls.Add(this.label2);
            this.tabPage_AlarmSet.Controls.Add(this.btnSet);
            this.tabPage_AlarmSet.Controls.Add(this.label1);
            this.tabPage_AlarmSet.Controls.Add(this.timePicker);
            this.tabPage_AlarmSet.Controls.Add(this.datePicker);
            this.tabPage_AlarmSet.Location = new System.Drawing.Point(4, 31);
            this.tabPage_AlarmSet.Name = "tabPage_AlarmSet";
            this.tabPage_AlarmSet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AlarmSet.Size = new System.Drawing.Size(631, 430);
            this.tabPage_AlarmSet.TabIndex = 0;
            this.tabPage_AlarmSet.Text = "알람 설정";
            this.tabPage_AlarmSet.UseVisualStyleBackColor = true;
            // 
            // btnReSet
            // 
            this.btnReSet.Location = new System.Drawing.Point(408, 322);
            this.btnReSet.Name = "btnReSet";
            this.btnReSet.Size = new System.Drawing.Size(170, 45);
            this.btnReSet.TabIndex = 2;
            this.btnReSet.Text = "해제";
            this.btnReSet.UseVisualStyleBackColor = true;
            this.btnReSet.Click += new System.EventHandler(this.btnReSet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "시간 설정";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(218, 322);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(170, 45);
            this.btnSet.TabIndex = 1;
            this.btnSet.Text = "설정";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "날짜 설정";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(61, 115);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(327, 32);
            this.datePicker.TabIndex = 0;
            // 
            // tabPage_Watch
            // 
            this.tabPage_Watch.Controls.Add(this.lbAlarm);
            this.tabPage_Watch.Controls.Add(this.groupBox1);
            this.tabPage_Watch.Controls.Add(this.lbAlarmSet);
            this.tabPage_Watch.Location = new System.Drawing.Point(4, 31);
            this.tabPage_Watch.Name = "tabPage_Watch";
            this.tabPage_Watch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Watch.Size = new System.Drawing.Size(631, 430);
            this.tabPage_Watch.TabIndex = 1;
            this.tabPage_Watch.Text = "디지털 시계";
            this.tabPage_Watch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTime);
            this.groupBox1.Controls.Add(this.lbDate);
            this.groupBox1.Location = new System.Drawing.Point(30, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "현재 시간";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("굴림", 30F);
            this.lbTime.Location = new System.Drawing.Point(23, 96);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(188, 70);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "Time";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(31, 64);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(50, 21);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "Date";
            // 
            // lbAlarmSet
            // 
            this.lbAlarmSet.AutoSize = true;
            this.lbAlarmSet.Location = new System.Drawing.Point(26, 40);
            this.lbAlarmSet.Name = "lbAlarmSet";
            this.lbAlarmSet.Size = new System.Drawing.Size(101, 21);
            this.lbAlarmSet.TabIndex = 0;
            this.lbAlarmSet.Text = "알람 설정";
            // 
            // lbAlarm
            // 
            this.lbAlarm.AutoSize = true;
            this.lbAlarm.Location = new System.Drawing.Point(26, 101);
            this.lbAlarm.Name = "lbAlarm";
            this.lbAlarm.Size = new System.Drawing.Size(55, 21);
            this.lbAlarm.TabIndex = 2;
            this.lbAlarm.Text = "Alarm";
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(62, 226);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(327, 32);
            this.timePicker.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 594);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_AlarmSet.ResumeLayout(false);
            this.tabPage_AlarmSet.PerformLayout();
            this.tabPage_Watch.ResumeLayout(false);
            this.tabPage_Watch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_AlarmSet;
        private System.Windows.Forms.TabPage tabPage_Watch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnReSet;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbAlarmSet;
        private System.Windows.Forms.Label lbAlarm;
        private System.Windows.Forms.DateTimePicker timePicker;
    }
}

