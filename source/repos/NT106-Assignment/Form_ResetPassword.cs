using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace NT106_Assignment
{
    public partial class Form_ResetPassword : Form
    {
        public Form_ResetPassword()
        {
            InitializeComponent();
        }

        private void Form_ResetPassword_Load(object sender, EventArgs e)
        {

        }

        private readonly string _Email; // giá trị định danh của user
        public Form_ResetPassword(string Email) : this()
        {
            _Email = Email ?? throw new ArgumentNullException(nameof(Email));
        }



        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click_1(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelResetPassword_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelResetPassword_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void textConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private static byte[] GenerateSalt(int size = 16)
        {
            var salt = new byte[size];
            using (var rng = RandomNumberGenerator.Create())
                rng.GetBytes(salt);
            return salt;
        }

        private static byte[] HashPassword(string password, byte[] salt, int iterations = 100_000, int outputBytes = 32)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations))
                return pbkdf2.GetBytes(outputBytes);

        }

        private void buttonResetPassword_Click(object sender, EventArgs e)
        {
            string password = textPassword.Text.Trim();
            string confirmPassword = textConfirmPassword.Text.Trim();
            // Kiểm tra password match
            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!");
                textConfirmPassword.Clear();
                textConfirmPassword.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!");
                textPassword.Clear();
                textPassword.Focus();
                return;
            }

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Tạo salt và hash mật khẩu
                    byte[] salt = GenerateSalt();
                    byte[] hash = HashPassword(password, salt);
                    // Cập nhật mật khẩu và salt vào cơ sở dữ liệu
                    string updateQuery = "UPDATE Users SET Password = @Password, Salt = @Salt WHERE Email = @Email";
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Password", Convert.ToBase64String(hash));
                        command.Parameters.AddWithValue("@Salt", Convert.ToBase64String(salt));
                        command.Parameters.AddWithValue("@Email", _Email);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đặt lại mật khẩu thành công!");
                            this.Close(); // Đóng form sau khi đặt lại mật khẩu thành công
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy người dùng với email đã cho.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đặt lại mật khẩu: " + ex.Message);
            }
        }
    }
}
