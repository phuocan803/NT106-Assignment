using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NT106_Assignment
{
    public partial class Form_ForgotPassword : Form
    {
        public Form_ForgotPassword()
        {
            InitializeComponent();
        }

        private static bool IsValidEmail(string email) 
        { 
            try 
            { 
                _ = new MailAddress(email); 
                return true; 
            } 
            catch { return false; } 
        }

        private static string GenerateCode(int digits = 6)
        {
            var bytes = new byte[4]; 
            using (var rng = RandomNumberGenerator.Create()) 
            { 
                rng.GetBytes(bytes); 
            }
            int value = Math.Abs(BitConverter.ToInt32(bytes, 0)); 
            // Ràng buộc vào khoảng [0, 10^digits - 1]
            int mod = (int)Math.Pow(10, digits); 
            int codeNum = value % mod; 
            return codeNum.ToString(new string('0', digits)); // zero-pad
            } 
        private async void buttonSendCode_Click(object sender, EventArgs e) 
        { 
            string email = textEmailorPhoneNumber.Text.Trim(); 
            if (string.IsNullOrEmpty(email) || !IsValidEmail(email)) 
            { 
                MessageBox.Show("Email không hợp lệ. Vui lòng kiểm tra lại.", 
                                "Thông báo", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning); 
                return; 
            } 
            string code = GenerateCode(6); // Mã OTP cua tao co 6 số
            DateTime expiresAt = DateTime.UtcNow.AddMinutes(10); // hết hạn sau 10 phút ok
            string connStr = ConfigurationManager.ConnectionStrings["AppDb"]?.ConnectionString; 
            if (string.IsNullOrWhiteSpace(connStr)) 
            { 
                MessageBox.Show("Chưa cấu hình connection string 'AppDb' trong App.config.", 
                                "Lỗi", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error
                                ); 
                return; 
            } 
            try 
            { 
                using (var conn = new SqlConnection(connStr)) 
                { 
                    await conn.OpenAsync(); 
                    using (var tran = conn.BeginTransaction()) 
                    { 
                        // Vô hiệu hoá mã cũ
                        using (var cmdUpdate = new SqlCommand( @"UPDATE dbo.ResetCodes SET IsUsed = 1 WHERE Email = @Email AND IsUsed = 0;",
                                                                conn, tran)) 
                        { 
                            cmdUpdate.Parameters.AddWithValue("@Email", email); 
                            await cmdUpdate.ExecuteNonQueryAsync(); 
                        } 
                          // Thêm mã mới
                        using (var cmdInsert = new SqlCommand( @"INSERT INTO dbo.ResetCodes (Email, Code, ExpiresAt, IsUsed) VALUES (@Email, @Code, @ExpiresAt, 0);", 
                                                                conn, tran)) 
                        { 
                        cmdInsert.Parameters.AddWithValue("@Email", email); 
                        cmdInsert.Parameters.AddWithValue("@Code", code); 
                        cmdInsert.Parameters.AddWithValue("@ExpiresAt", expiresAt); 
                        await cmdInsert.ExecuteNonQueryAsync(); 
                        } 
                    tran.Commit(); 
                    } 
                } 
                MessageBox.Show("Đã tạo mã khôi phục và lưu vào CSDL.\n(10 phút hết hạn)", 
                                "Thành công", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information); // Gửi email cho bo
            } 
            catch (SqlException ex) 
            { 
                // Ví dụ: vi phạm unique index X_ResetCodes_Email_Active 
                    MessageBox.Show("Lỗi CSDL: " + ex.Message, "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error); 
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", 
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error); 
            } 
        } 
        //Gửi OTP xác nhận về email hoặc số điện thoại đã nhập


        private void Form_ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelForgotPassword_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelForgotPassword_Click(object sender, EventArgs e)
        {

        }

        private void labelEmailorPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void panelCaptcha_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelCaptcha_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textEmailorPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
