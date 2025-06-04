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
    public partial class FormMy : Form
    {
        string connectionString = "server=localhost; user=root; password=1234; database=book_project;";
        private string currentUser = null;
        public FormMy(string username)
        {
            InitializeComponent();
            currentUser = username;
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            string newpassword = txtchangePassword.Text;
            string newname = txtchangename.Text.Trim();  // 앞뒤 공백 제거
                                                         //string nameid = currentUser;


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE userex SET userpw = @newpassword, username = @newname WHERE username = @currentUsername";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@newpassword", newpassword);
                    cmd.Parameters.AddWithValue("@newname", newname);
                    cmd.Parameters.AddWithValue("@currentUsername", currentUser);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("회원 정보가 성공적으로 변경되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        currentUser = newname; // 사용자 이름이 변경되었으므로 상태도 갱신
                    }
                    else
                    {
                        MessageBox.Show("회원 정보 변경에 실패했습니다.", "실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"오류 발생: {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "delete from userex where username=@username";

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@username", currentUser);


                    cmd.ExecuteNonQuery();                     //로그인과 다르게 수정할거니까 다른 메소드를 사용.

                    MessageBox.Show("회원 탈퇴 성공!", "결과", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    currentUser = null;
                    //lbl_who.Text = "로그인하세요";
                }
                catch (Exception ex) { }
            }
        }
    }
}
