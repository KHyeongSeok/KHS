namespace OneDayProject2
{
    partial class FormMy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnchange = new System.Windows.Forms.Button();
            this.txtchangePassword = new System.Windows.Forms.TextBox();
            this.txtchangename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnchange);
            this.groupBox1.Controls.Add(this.txtchangePassword);
            this.groupBox1.Controls.Add(this.txtchangename);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(99, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 289);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "수정/탈퇴";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(423, 224);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 47);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "탈퇴";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnchange
            // 
            this.btnchange.Location = new System.Drawing.Point(423, 161);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(108, 47);
            this.btnchange.TabIndex = 4;
            this.btnchange.Text = "수정";
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // txtchangePassword
            // 
            this.txtchangePassword.Location = new System.Drawing.Point(205, 171);
            this.txtchangePassword.Name = "txtchangePassword";
            this.txtchangePassword.Size = new System.Drawing.Size(180, 32);
            this.txtchangePassword.TabIndex = 3;
            // 
            // txtchangename
            // 
            this.txtchangename.Location = new System.Drawing.Point(205, 97);
            this.txtchangename.Name = "txtchangename";
            this.txtchangename.Size = new System.Drawing.Size(180, 32);
            this.txtchangename.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름:";
            // 
            // FormMy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 486);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMy";
            this.Text = "FormMy";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.TextBox txtchangePassword;
        private System.Windows.Forms.TextBox txtchangename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}