using System;
using System.Drawing;
using System.Data.SqlClient; // Thêm thư viện kết nối SQL
//using System.Drawing; 
using System.Windows.Forms;

namespace NT106_Assignment
{
    public partial class Form_Login : Form
    {
        // Chuỗi kết nối SQL Server - Dựa trên SSMS connection string  - lầy từ ssms
        private string connectionString = "Data Source=localhost;Database=NT106_Assignment;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        
        public Form_Login()
        {
            InitializeComponent();
        }
        public Form_Login(Point location, Size size)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
            this.Size = size;

            Screen currentScreen = Screen.FromPoint(Cursor.Position);

            int x = currentScreen.WorkingArea.Left +
                    (currentScreen.WorkingArea.Width - this.Width) / 2;
            int y = currentScreen.WorkingArea.Top +
                    (currentScreen.WorkingArea.Height - this.Height) / 2;

            this.Location = new Point(x, y);
        }
                
        // Phương thức kiểm tra kết nối database
        private bool TestDatabaseConnection()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối database: " + ex.Message);
                return false;
            }
        }

        // Phương thức xác thực user từ database
        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        
                        int userCount = (int)command.ExecuteScalar();
                        return userCount > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xác thực: " + ex.Message);
                return false;
            }
        }

        // Phương thức tạo bảng Users nếu chưa tồn tại - ENHANCED: Thêm các field từ SignUp form
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

        // Phương thức thêm user mặc định
        private void AddDefaultUser()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // Kiểm tra xem user admin đã tồn tại chưa
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = 'admin'";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        int adminExists = (int)checkCommand.ExecuteScalar();
                        
                        if (adminExists == 0)
                        {
                            string insertQuery = "INSERT INTO Users (Username, Password, Email) VALUES ('admin', '123', 'admin@example.com')";
                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm user mặc định: " + ex.Message);
            }
        }
                
        // Bước 3: Kết nối đến SQL Server - Method theo hướng dẫn (FIX: Sử dụng cùng connection string)
        private void ConnectToDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Kết nối thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        // Method để tạo database trước khi kết nối
        private void CreateDatabaseIfNotExists()
        {
            try
            {
                // Kết nối đến master database để tạo database mới - dựa trên SSMS connection
                string masterConnectionString = "Data Source=localhost;Database=master;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
                
                using (SqlConnection connection = new SqlConnection(masterConnectionString))
                {
                    connection.Open();
                    
                    // Kiểm tra database đã tồn tại chưa
                    string checkDbQuery = "SELECT COUNT(*) FROM sys.databases WHERE name = 'NT106_Assignment'";
                    using (SqlCommand checkCommand = new SqlCommand(checkDbQuery, connection))
                    {
                        int dbExists = (int)checkCommand.ExecuteScalar();
                        
                        if (dbExists == 0)
                        {
                            // Tạo database mới
                            string createDbQuery = "CREATE DATABASE NT106_Assignment";
                            using (SqlCommand createCommand = new SqlCommand(createDbQuery, connection))
                            {
                                createCommand.ExecuteNonQuery();
                                MessageBox.Show("Database NT106_Assignment đã được tạo thành công!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo database: " + ex.Message);
            }
        }
        
        // Method test kết nối đơn giản - sử dụng SSMS connection
        private void TestSQLServerConnection()
        {
            try
            {
                // Test kết nối master database với SSMS connection string
                string masterConnection = "Data Source=localhost;Database=master;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
                using (SqlConnection connection = new SqlConnection(masterConnection))
                {
                    connection.Open();
                    
                    // Lấy thông tin SQL Server
                    string query = "SELECT @@SERVERNAME as ServerName, @@VERSION as Version";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string serverInfo = $"SQL Server kết nối thành công!\n\n" +
                                                   $"Server: {reader["ServerName"]}\n" +
                                                   $"Connection: Windows Authentication\n" +
                                                   $"Version: {reader["Version"].ToString().Substring(0, 50)}...";
                                
                                MessageBox.Show(serverInfo, "SQL Server Connected");
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối SQL Server:\n\n{ex.Message}\n\n" +
                               $"Kiểm tra:\n" +
                               $"1. SQL Server service đang chạy\n" +
                               $"2. Windows Authentication được phép\n" +
                               $"3. User hiện tại có quyền truy cập SQL Server", 
                               "Connection Error");
            }
        }

        // Sự kiện click nút LOGIN - OPTIMIZED: Giảm số lần hiện MessageBox
        private void Button_LOGIN_Click(object sender, EventArgs e)
        {
            string acc = TextBox_Acc.Text.Trim();
            string pass = TextBox_Pass.Text.Trim();

            if (!CheckBox_Catpcha.Checked)
            {
                MessageBox.Show("Bạn phải xác nhận Captcha trước!");
                TextBox_Acc.Clear();
                TextBox_Pass.Clear();
                TextBox_Acc.Focus();
                return;
            }

            try 
            {
                // Tạo database và setup một lần
                CreateDatabaseIfNotExists();
                CreateUsersTableIfNotExists();
                AddDefaultUser();

                // Xác thực user từ database
                if (AuthenticateUser(acc, pass))
                {
                    MessageBox.Show("Đăng nhập thành công!");

                    Form_Client clientForm = new Form_Client();
                    clientForm.Location = this.Location;
                    clientForm.Size = this.Size;
                    clientForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                    TextBox_Pass.Clear();
                    TextBox_Pass.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}\n\nVui lòng kiểm tra kết nối SQL Server!");
            }

            //if (acc == "admin" && pass == "123")
            //{
            //    MessageBox.Show("Đăng nhập thành công!");

            //    Form_Client clientForm = new Form_Client(this.Location, this.Size);
            //    clientForm.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            //    TextBox_Pass.Clear();
            //    TextBox_Pass.Focus();
            //}
        }
           
        private void Button_CreateAcc_Click(object sender, EventArgs e)
        {
            Form_SignUp signupForm = new Form_SignUp(this.Location, this.Size);
            signupForm.Show();
            this.Hide();
        }

        private void Button_LOGIN_Click_1(object sender, EventArgs e)
        {

        }

        // Gọi test khi form load
        private void Form_Login_Load(object sender, EventArgs e)
        {
            // Test kết nối SQL Server ngay khi mở form
            //TestSQLServerConnection();
        }

        // Event handler cho Label_Pass click
        private void Label_Pass_Click(object sender, EventArgs e)
        {
            // Empty event handler for designer
        }
    }
}

