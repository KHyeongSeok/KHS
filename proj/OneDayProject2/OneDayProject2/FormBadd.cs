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
    public partial class FormBadd : Form
    {
        string connectionString = "server=localhost; user=root; password=1234; database=book_project;";

        public event EventHandler BookAdded; // 이벤트 선언
        public FormBadd()
        {
            InitializeComponent();
        }

        private void buttonBAdd_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost; user=root; password=1234; database=book_project;";
            string bookName = textBoxAN.Text.Trim();
            string bookAuthor = textBoxAA.Text.Trim();
            string bookPubl = textBoxAPB.Text.Trim();

            if (string.IsNullOrEmpty(bookName) || string.IsNullOrEmpty(bookAuthor))
            {
                MessageBox.Show("제목과 저자는 반드시 입력해야 합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 출판 위치 자동 생성 (책 개수가 50개 있다고 하셨으니 아래 예시처럼)
            string bookLocation = GenerateBookLocation();

            string query = "INSERT INTO book_list (book_name, book_author, book_publ, book_location) VALUES (@name, @author, @publ, @location);";

            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", bookName);
                        cmd.Parameters.AddWithValue("@author", bookAuthor);
                        cmd.Parameters.AddWithValue("@publ", bookPubl);
                        cmd.Parameters.AddWithValue("@location", bookLocation);

                        cmd.ExecuteNonQuery();
                    }

                    BookAdded?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show("도서가 성공적으로 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 입력값 초기화
                    textBoxAN.Clear();
                    textBoxAA.Clear();
                    textBoxAPB.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"도서 추가 실패: {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private string GenerateBookLocation()
        {

            // 예를 들어 기존 책 개수가 50개라면, 새 책 위치는 D-10, E-1 식으로 순서대로 부여
            List<string> usedLocations = new List<string>();

            using (var conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT book_location FROM book_list;";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        usedLocations.Add(reader.GetString(0));
                    }
                }
            }

            // 최대 26글자(A~Z) 범위, 1~10까지
            //// 10단위 구간으로 구분, 예) 0~9 : D-1~D-10, 10~19 : E-1~E-10, 20~29 : F-1~F-10 ...
            for (char row = 'D'; row <= 'Z'; row++)
            {
                for (int col = 1; col <= 10; col++)
                {
                    string loc = $"{row}-{col}";
                    if (!usedLocations.Contains(loc))
                    {
                        return loc; // 비어있는 위치가 있으면 반환
                    }
                }
            }

            // 모든 자리가 다 찼다면
            throw new Exception("책 위치가 모두 찼습니다. 추가할 수 없습니다.");
        }

    }
}
