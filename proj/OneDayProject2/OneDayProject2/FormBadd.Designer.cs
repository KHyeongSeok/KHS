namespace OneDayProject2
{
    partial class FormBadd
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
            this.labelBAN = new System.Windows.Forms.Label();
            this.labelBAA = new System.Windows.Forms.Label();
            this.textBoxAN = new System.Windows.Forms.TextBox();
            this.textBoxAA = new System.Windows.Forms.TextBox();
            this.textBoxAPB = new System.Windows.Forms.TextBox();
            this.labelBAPB = new System.Windows.Forms.Label();
            this.buttonBAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBAN
            // 
            this.labelBAN.AutoSize = true;
            this.labelBAN.Location = new System.Drawing.Point(50, 46);
            this.labelBAN.Name = "labelBAN";
            this.labelBAN.Size = new System.Drawing.Size(29, 12);
            this.labelBAN.TabIndex = 0;
            this.labelBAN.Text = "제목";
            // 
            // labelBAA
            // 
            this.labelBAA.AutoSize = true;
            this.labelBAA.Location = new System.Drawing.Point(52, 87);
            this.labelBAA.Name = "labelBAA";
            this.labelBAA.Size = new System.Drawing.Size(29, 12);
            this.labelBAA.TabIndex = 1;
            this.labelBAA.Text = "저자";
            // 
            // textBoxAN
            // 
            this.textBoxAN.Location = new System.Drawing.Point(159, 43);
            this.textBoxAN.Name = "textBoxAN";
            this.textBoxAN.Size = new System.Drawing.Size(100, 21);
            this.textBoxAN.TabIndex = 2;
            // 
            // textBoxAA
            // 
            this.textBoxAA.Location = new System.Drawing.Point(159, 84);
            this.textBoxAA.Name = "textBoxAA";
            this.textBoxAA.Size = new System.Drawing.Size(100, 21);
            this.textBoxAA.TabIndex = 3;
            // 
            // textBoxAPB
            // 
            this.textBoxAPB.Location = new System.Drawing.Point(159, 131);
            this.textBoxAPB.Name = "textBoxAPB";
            this.textBoxAPB.Size = new System.Drawing.Size(100, 21);
            this.textBoxAPB.TabIndex = 4;
            // 
            // labelBAPB
            // 
            this.labelBAPB.AutoSize = true;
            this.labelBAPB.Location = new System.Drawing.Point(51, 134);
            this.labelBAPB.Name = "labelBAPB";
            this.labelBAPB.Size = new System.Drawing.Size(41, 12);
            this.labelBAPB.TabIndex = 5;
            this.labelBAPB.Text = "출판사";
            // 
            // buttonBAdd
            // 
            this.buttonBAdd.Location = new System.Drawing.Point(159, 194);
            this.buttonBAdd.Name = "buttonBAdd";
            this.buttonBAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonBAdd.TabIndex = 6;
            this.buttonBAdd.Text = "추가";
            this.buttonBAdd.UseVisualStyleBackColor = true;
            this.buttonBAdd.Click += new System.EventHandler(this.buttonBAdd_Click);
            // 
            // FormBadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 266);
            this.Controls.Add(this.buttonBAdd);
            this.Controls.Add(this.labelBAPB);
            this.Controls.Add(this.textBoxAPB);
            this.Controls.Add(this.textBoxAA);
            this.Controls.Add(this.textBoxAN);
            this.Controls.Add(this.labelBAA);
            this.Controls.Add(this.labelBAN);
            this.Name = "FormBadd";
            this.Text = "FormBadd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBAN;
        private System.Windows.Forms.Label labelBAA;
        private System.Windows.Forms.TextBox textBoxAN;
        private System.Windows.Forms.TextBox textBoxAA;
        private System.Windows.Forms.TextBox textBoxAPB;
        private System.Windows.Forms.Label labelBAPB;
        private System.Windows.Forms.Button buttonBAdd;
    }
}