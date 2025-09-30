using System;
using System.Drawing;
//using System.Drawing; 
using System.Windows.Forms;

namespace NT106_Assignment
{
    public partial class Form_Login : Form
    {
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
                
        // Sự kiện click nút LOGIN
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
    }
}
