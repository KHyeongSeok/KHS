using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneDayProject2
{
    public partial class FormReg : Form
    {
        string connectionString = "server=localhost; user=root; password=1234; database=book_project;";
        public FormReg()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string name = txtRegID.Text;
            string pw = txtRegPW.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "insert into userex(username, userpw) values(@username, @userpw)";

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@username", name);
                    cmd.Parameters.AddWithValue("@userpw", pw);

                    cmd.ExecuteNonQuery();                     //로그인과 다르게 수정할거니까 다른 메소드를 사용.



                    MessageBox.Show("회원가입 성공!", "결과", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtRegID.Text = "";
                    txtRegPW.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("이미 사용중인 이름입니다. 다른 이름을 입력해 주세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRegID.Text = "";
                }
            }
        }
    }
}
