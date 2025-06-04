using MySql.Data.MySqlClient; // DB를 받아 오기 위해 필수 작성
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinForm250530_LoginSQLWinForm
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn;
        private string currentUser = null;
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;user=root;password=1234;database=user_db;");
            lbl_who.Text = "로그인 하세요.";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtLoginUsername.Text;
            string password = txtLoginPassword.Text;
            try
            {
                conn.Open();
                string query = "select * from users where username=@username and password=@password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                var reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    currentUser = username;
                    lbl_who.Text = currentUser + "님 안녕하세요.";
                    MessageBox.Show("로그인 성공");
                }
                else
                {
                    MessageBox.Show("로그인 실패, ID/PW를 확인해보세요.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
                txtLoginUsername.Text = "";
                txtLoginPassword.Text = "";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            currentUser = null;
            txtLoginUsername.Text = "";
            txtLoginPassword.Text = "";
            lbl_who.Text = "로그인 하세요.";
            MessageBox.Show("로그아웃 되었습니다.");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtRegUsername.Text;
            string password = txtRegPassword.Text;
            string name = txtRegName.Text;
            string email = txtRegEmail.Text;
            try
            {
                conn.Open();
                string query = "insert into users (username, password, name, email)" +
                    "values (@username, @password, @name, @email)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();
                MessageBox.Show("회원가입 성공");
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러", ex.Message);
            }
            finally
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentUser == null)
            {
                MessageBox.Show("먼저 로그인하세요.");
                return;
            }
            string newPassword = txtNewPassword.Text;
            string newName = txtNewName.Text;
            string newEmail = txtNewEmail.Text;
            try
            {
                conn.Open();
                string query = "update users set password=@password, name=@name, email=@email " +
                    "where username=@username"; // 이런식으로 줄바꿈할땐 뛰어쓰기 신경쓰기
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", currentUser);
                cmd.Parameters.AddWithValue("@Password", newPassword);
                cmd.Parameters.AddWithValue("@name", newName);
                cmd.Parameters.AddWithValue("@email", newEmail);
                cmd.ExecuteNonQuery();
                MessageBox.Show("회원정보 수정 성공");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentUser == null)
            {
                MessageBox.Show("먼저 로그인하세요.");
                return;
            }
            var confirm = MessageBox.Show("정말?", "확인", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
            {
                return;
            }
            try
            {
                conn.Open();
                string query = "delete from users where username=@username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", currentUser);
                cmd.ExecuteNonQuery();
                MessageBox.Show("회원탈퇴 성공");
                currentUser = null;
                lbl_who.Text = "로그인 하세요.";
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
