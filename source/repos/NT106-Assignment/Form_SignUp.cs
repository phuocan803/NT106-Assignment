using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // Thêm thư viện kết nối SQL
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography; // Thư viện mã hóa 

namespace NT106_Assignment
{
    public partial class Form_SignUp : Form
    {
        // Chuỗi kết nối SQL Server - Dựa trên SSMS connection string
        private string connectionString = "Data Source=localhost;Database=NT106_Assignment;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public Form_SignUp()
        {
            InitializeComponent();
        }

        public Form_SignUp(Point location, Size size)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
            this.Size = size;
        }

        // Phương thức kiểm tra username đã tồn tại
        private bool IsUsernameTaken(string username)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra username: " + ex.Message);
                return true; // Return true để tránh tạo user khi có lỗi
            }
        }

        // Phương thức đăng ký user mới - ENHANCED: Thêm FullName và PhoneNumber
        private bool RegisterUser(string username, string password, string email, string fullName = "", string phoneNumber = "")
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Tạo salt và hash password
                    string salt = GenerateSalt();
                    string hashedPassword = HashPassword(password, salt);

                    string insertQuery = "INSERT INTO Users (Username, Password, Salt, Email, FullName, PhoneNumber) VALUES (@username, @password, @salt, @email, @fullName, @phoneNumber)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", hashedPassword);
                        command.Parameters.AddWithValue("@salt", salt);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@fullName", fullName);
                        command.Parameters.AddWithValue("@phoneNumber", phoneNumber);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng ký user: " + ex.Message);
                return false;
            }
        }

        // Phương thức tạo bảng Users nếu chưa tồn tại - SYNC với Form_Login
        private void CreateUsersTableIfNotExists()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string createTableQuery = @"
                        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Users' AND xtype='U')
                        CREATE TABLE Users (
                            Id INT IDENTITY(1,1) PRIMARY KEY,
                            Username NVARCHAR(50) NOT NULL UNIQUE,
                            Password NVARCHAR(255) NOT NULL,
                            Salt NVARCHAR(255) NOT NULL,
                            Email NVARCHAR(100),
                            FullName NVARCHAR(100),
                            PhoneNumber NVARCHAR(20),
                            CreatedDate DATETIME DEFAULT GETDATE()
                        )";

                    using (SqlCommand command = new SqlCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo bảng: " + ex.Message);
            }
        }

        // Sự kiện click nút đăng ký - FIXED: Kích hoạt tính năng
        private void Button_SignUp_Click(object sender, EventArgs e)
        {
            // Tạo bảng nếu chưa có
            CreateUsersTableIfNotExists();

            // Lấy thông tin từ các TextBox
            string username = TextBox_Username.Text.Trim();
            string password = TextBox_PassW.Text.Trim();
            string confirmPassword = TextBox_ConfirmPass.Text.Trim();
            string email = TextBox_Email.Text.Trim();
            string fullName = TextBox_FullName.Text.Trim();
            string phoneNumber = TextBox_PhoneNumber.Text.Trim();

            // Kiểm tra Captcha
            if (!CheckBox_Capt.Checked)
            {
                MessageBox.Show("Bạn phải xác nhận Captcha trước!");
                return;
            }

            // Validation cơ bản
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!");
                return;
            }

            // Kiểm tra password match
            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!");
                TextBox_ConfirmPass.Clear();
                TextBox_ConfirmPass.Focus();
                return;
            }

            // Kiểm tra username đã tồn tại
            if (IsUsernameTaken(username))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
                TextBox_Username.Focus();
                return;
            }

            // Đăng ký user mới - FIXED: Truyền đầy đủ parameters
            if (RegisterUser(username, password, email, fullName, phoneNumber))
            {
                MessageBox.Show("Đăng ký thành công!");
                Form_Login loginForm = new Form_Login(this.Location, this.Size);
                loginForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại!");
            }
        }

        // Tạo salt ngẫu nhiên
        private string GenerateSalt()
        {
            byte[] saltBytes = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        // Hash password với SHA256 + Salt
        private string HashPassword(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                string saltedPassword = password + salt;
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
                return Convert.ToBase64String(bytes);
            }
        }

        private void Label_SignUp_Click(object sender, EventArgs e)
        {
            Form_Login loginForm = new Form_Login(this.Location, this.Size);
            loginForm.Show();
            this.Hide();
        }
    }

}
