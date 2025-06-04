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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace OneDayProject2
{
    public partial class Form1 : Form
    {
        string connectionString = "server=localhost; user=root; password=1234; database=book_project;";
        private string currentUser = null; 
        private FormBadd formBaddInstance = null;

        public Form1()
        {
            InitializeComponent();
            LoadTableColumnsToListView(); 
            comboBoxSearchType.SelectedItem = "제목"; //시작시 기본으로 제목 설정
            comboBoxSearchType.DropDownStyle = ComboBoxStyle.DropDownList; //콤보박스에 글자쓰기 불가능하게(읽기모드)
        }
        private void LoadTableColumnsToListView()
        {
            
            string query = "SELECT book_id, book_name, book_author, book_publ, book_location FROM book_list ORDER BY CAST(book_location AS UNSIGNED);";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    listViewBooks.Clear(); // 컬럼과 아이템 모두 초기화

                    // 컬럼 헤더를 직접 지정 (MySQL 컬럼명과 순서 일치해야 함)
                    listViewBooks.Columns.Add("번호");
                    listViewBooks.Columns.Add("제목");
                    listViewBooks.Columns.Add("저자");
                    listViewBooks.Columns.Add("출판사");
                    listViewBooks.Columns.Add("위치"); 
                    listViewBooks.GridLines = true;
                    listViewBooks.FullRowSelect = true;

                    int number = 1;
                    // 행 데이터 추가
                    while (reader.Read())
                    {
                        string[] rowItems = new string[]
                        {
                            number.ToString(),
                            reader["book_name"].ToString(),
                            reader["book_author"].ToString(),
                            reader["book_publ"].ToString(),
                            reader["book_location"].ToString()
                        };

                        ListViewItem item = new ListViewItem(rowItems);
                        item.Tag = reader["book_id"]; // book_id를 Tag에 저장
                        listViewBooks.Items.Add(item);
                        number++;
                    }

                    listViewBooks.View = View.Details;

                    // 컬럼 너비 자동 조정
                    foreach (ColumnHeader column in listViewBooks.Columns)
                    {
                        column.Width = -2;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"데이터 불러오기 실패: {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (FormLogin loginForm = new FormLogin())
            {
                var result = loginForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    currentUser = loginForm.LoggedInUsername;
                    MessageBox.Show($"안녕하세요, {currentUser}님!", "환영", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labelPlayerName.Text = ""+ currentUser + "님 이 접속중 입니다";
                    // 필요한 초기화 작업 실행
                }
                else
                {
                    // 로그인 실패 또는 취소 → 메인 폼 종료
                    MessageBox.Show("로그인하지 않으면 프로그램을 종료합니다.", "종료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string selectedType = comboBoxSearchType.SelectedItem.ToString();
            string keyword = textBoxSearchKeyword.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("검색어를 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTableColumnsToListView(); //키워드 아무것도 안넣고 검색시 검색어 초기화
                return;
            }

            string columnName = "";
            switch (selectedType)
            {
                case "제목":
                    columnName = "book_name";
                    break;
                case "저자":
                    columnName = "book_author";
                    break;
                case "출판사":
                    columnName = "book_publ";
                    break;
                default:
                    MessageBox.Show("유효한 검색 타입을 선택해주세요.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            SearchBooks(columnName, keyword);
        }
        private void SearchBooks(string column, string keyword)
        {
            string query = $"SELECT book_id, book_name, book_author, book_publ, book_location FROM book_list WHERE {column} LIKE @keyword;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@keyword", $"%{keyword}%");

                    MySqlDataReader reader = command.ExecuteReader();

                    listViewBooks.Items.Clear();

                    int number = 1;
                    while (reader.Read())
                    {
                        string[] rowItems = new string[]
                        {
                            number.ToString(),
                            reader["book_name"].ToString(),
                            reader["book_author"].ToString(),
                            reader["book_publ"].ToString(),
                            reader["book_location"].ToString()
                        };

                        ListViewItem item = new ListViewItem(rowItems);
                        listViewBooks.Items.Add(item);
                        number++;
                    }

                    foreach (ColumnHeader columnHeader in listViewBooks.Columns)
                    {
                        columnHeader.Width = -2;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"검색 실패: {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(formBaddInstance != null)
            {
                formBaddInstance.Close();
            }

            this.Hide();
            
            // 새로운 로그인 폼을 생성
            using (FormLogin loginForm = new FormLogin())
            {
                var result = loginForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // 로그인 성공 → Form1 다시 보여줌
                    MessageBox.Show($"안녕하세요, {loginForm.LoggedInUsername}님!", "환영", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Show();
                }
                else
                {
                    // 로그인 실패나 취소 → 프로그램 종료
                    Application.Exit();
                }
            }
        }

        private void buttonbdel_Click(object sender, EventArgs e)
        {
            if (listViewBooks.SelectedItems.Count == 0)
            {
                MessageBox.Show("삭제할 도서를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmResult = MessageBox.Show("정말 선택한 도서를 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                // 선택된 아이템의 book_id를 가져와서 DB에서 삭제
                var selectedItem = listViewBooks.SelectedItems[0];
                int bookId = (int)listViewBooks.SelectedItems[0].Tag;

                string deleteQuery = "DELETE FROM book_list WHERE book_id = @bookId;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@bookId", bookId);
                            int result = command.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("도서가 성공적으로 삭제되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // 삭제 후 리스트뷰 갱신
                                LoadTableColumnsToListView();
                            }
                            else
                            {
                                MessageBox.Show("도서 삭제에 실패했습니다.", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"삭제 중 오류 발생: {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void buttonbadd_Click(object sender, EventArgs e)
        {
            if (formBaddInstance == null || formBaddInstance.IsDisposed)
            {
                formBaddInstance = new FormBadd();
                formBaddInstance.BookAdded += (s, args) => LoadTableColumnsToListView();
                formBaddInstance.FormClosed += (s, args) => formBaddInstance = null; // 닫히면 변수 초기화
                formBaddInstance.Show();
            }
            else
            {
                MessageBox.Show("도서 추가 창이 이미 열려 있습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnMy_Click(object sender, EventArgs e)
        {
            FormMy formMy = new FormMy(currentUser);
            formMy.Show();
        }
    }
}
