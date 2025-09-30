using System.Drawing;
using System.Windows.Forms;

namespace NT106_Assignment
{
    partial class Form_SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_SIGNUP = new System.Windows.Forms.Panel();
            this.Panel_Capt = new System.Windows.Forms.Panel();
            this.Label_Captcha = new System.Windows.Forms.Label();
            this.CheckBox_Capt = new System.Windows.Forms.CheckBox();
            this.Label_ConfirmPass = new System.Windows.Forms.Label();
            this.TextBox_ConfirmPass = new System.Windows.Forms.TextBox();
            this.TextBox_PassW = new System.Windows.Forms.TextBox();
            this.Label_PassW = new System.Windows.Forms.Label();
            this.Label_Email = new System.Windows.Forms.Label();
            this.TextBox_Email = new System.Windows.Forms.TextBox();
            this.TextBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.Label_PhongNumber = new System.Windows.Forms.Label();
            this.Label_SignIn = new System.Windows.Forms.Label();
            this.Label_Username = new System.Windows.Forms.Label();
            this.TextBox_Username = new System.Windows.Forms.TextBox();
            this.TextBox_FullName = new System.Windows.Forms.TextBox();
            this.Label_FullName = new System.Windows.Forms.Label();
            this.Button_SignIn = new System.Windows.Forms.Button();
            this.Panel_SIGNUP.SuspendLayout();
            this.Panel_Capt.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_SIGNUP
            // 
            this.Panel_SIGNUP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_SIGNUP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel_SIGNUP.Controls.Add(this.Panel_Capt);
            this.Panel_SIGNUP.Controls.Add(this.Label_ConfirmPass);
            this.Panel_SIGNUP.Controls.Add(this.TextBox_ConfirmPass);
            this.Panel_SIGNUP.Controls.Add(this.TextBox_PassW);
            this.Panel_SIGNUP.Controls.Add(this.Label_PassW);
            this.Panel_SIGNUP.Controls.Add(this.Label_Email);
            this.Panel_SIGNUP.Controls.Add(this.TextBox_Email);
            this.Panel_SIGNUP.Controls.Add(this.TextBox_PhoneNumber);
            this.Panel_SIGNUP.Controls.Add(this.Label_PhongNumber);
            this.Panel_SIGNUP.Controls.Add(this.Label_SignIn);
            this.Panel_SIGNUP.Controls.Add(this.Label_Username);
            this.Panel_SIGNUP.Controls.Add(this.TextBox_Username);
            this.Panel_SIGNUP.Controls.Add(this.TextBox_FullName);
            this.Panel_SIGNUP.Controls.Add(this.Label_FullName);
            this.Panel_SIGNUP.Controls.Add(this.Button_SignIn);
            this.Panel_SIGNUP.Location = new System.Drawing.Point(346, 25);
            this.Panel_SIGNUP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_SIGNUP.Name = "Panel_SIGNUP";
            this.Panel_SIGNUP.Size = new System.Drawing.Size(398, 552);
            this.Panel_SIGNUP.TabIndex = 6;
            // 
            // Panel_Capt
            // 
            this.Panel_Capt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Panel_Capt.Controls.Add(this.Label_Captcha);
            this.Panel_Capt.Controls.Add(this.CheckBox_Capt);
            this.Panel_Capt.Location = new System.Drawing.Point(76, 420);
            this.Panel_Capt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_Capt.Name = "Panel_Capt";
            this.Panel_Capt.Size = new System.Drawing.Size(252, 30);
            this.Panel_Capt.TabIndex = 24;
            // 
            // Label_Captcha
            // 
            this.Label_Captcha.AutoSize = true;
            this.Label_Captcha.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.Label_Captcha.ForeColor = System.Drawing.Color.Transparent;
            this.Label_Captcha.Location = new System.Drawing.Point(69, 7);
            this.Label_Captcha.Name = "Label_Captcha";
            this.Label_Captcha.Size = new System.Drawing.Size(115, 15);
            this.Label_Captcha.TabIndex = 16;
            this.Label_Captcha.Text = "[ I\'m not a ROBOT ]";
            // 
            // CheckBox_Capt
            // 
            this.CheckBox_Capt.AutoSize = true;
            this.CheckBox_Capt.Location = new System.Drawing.Point(12, 8);
            this.CheckBox_Capt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBox_Capt.Name = "CheckBox_Capt";
            this.CheckBox_Capt.Size = new System.Drawing.Size(18, 17);
            this.CheckBox_Capt.TabIndex = 15;
            this.CheckBox_Capt.UseVisualStyleBackColor = true;
            // 
            // Label_ConfirmPass
            // 
            this.Label_ConfirmPass.AutoSize = true;
            this.Label_ConfirmPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Label_ConfirmPass.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Label_ConfirmPass.Location = new System.Drawing.Point(76, 361);
            this.Label_ConfirmPass.Name = "Label_ConfirmPass";
            this.Label_ConfirmPass.Size = new System.Drawing.Size(157, 23);
            this.Label_ConfirmPass.TabIndex = 23;
            this.Label_ConfirmPass.Text = "Confirm password";
            // 
            // TextBox_ConfirmPass
            // 
            this.TextBox_ConfirmPass.Location = new System.Drawing.Point(76, 387);
            this.TextBox_ConfirmPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox_ConfirmPass.Name = "TextBox_ConfirmPass";
            this.TextBox_ConfirmPass.PasswordChar = '*';
            this.TextBox_ConfirmPass.Size = new System.Drawing.Size(252, 22);
            this.TextBox_ConfirmPass.TabIndex = 22;
            // 
            // TextBox_PassW
            // 
            this.TextBox_PassW.Location = new System.Drawing.Point(76, 336);
            this.TextBox_PassW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox_PassW.Name = "TextBox_PassW";
            this.TextBox_PassW.PasswordChar = '*';
            this.TextBox_PassW.Size = new System.Drawing.Size(252, 22);
            this.TextBox_PassW.TabIndex = 21;
            // 
            // Label_PassW
            // 
            this.Label_PassW.AutoSize = true;
            this.Label_PassW.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Label_PassW.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Label_PassW.Location = new System.Drawing.Point(76, 310);
            this.Label_PassW.Name = "Label_PassW";
            this.Label_PassW.Size = new System.Drawing.Size(85, 23);
            this.Label_PassW.TabIndex = 20;
            this.Label_PassW.Text = "Password";
            // 
            // Label_Email
            // 
            this.Label_Email.AutoSize = true;
            this.Label_Email.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Label_Email.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Label_Email.Location = new System.Drawing.Point(76, 259);
            this.Label_Email.Name = "Label_Email";
            this.Label_Email.Size = new System.Drawing.Size(120, 23);
            this.Label_Email.TabIndex = 19;
            this.Label_Email.Text = "Email address";
            // 
            // TextBox_Email
            // 
            this.TextBox_Email.Location = new System.Drawing.Point(76, 285);
            this.TextBox_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox_Email.Name = "TextBox_Email";
            this.TextBox_Email.Size = new System.Drawing.Size(252, 22);
            this.TextBox_Email.TabIndex = 18;
            // 
            // TextBox_PhoneNumber
            // 
            this.TextBox_PhoneNumber.Location = new System.Drawing.Point(76, 234);
            this.TextBox_PhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox_PhoneNumber.Name = "TextBox_PhoneNumber";
            this.TextBox_PhoneNumber.Size = new System.Drawing.Size(252, 22);
            this.TextBox_PhoneNumber.TabIndex = 17;
            // 
            // Label_PhongNumber
            // 
            this.Label_PhongNumber.AutoSize = true;
            this.Label_PhongNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Label_PhongNumber.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Label_PhongNumber.Location = new System.Drawing.Point(76, 208);
            this.Label_PhongNumber.Name = "Label_PhongNumber";
            this.Label_PhongNumber.Size = new System.Drawing.Size(127, 23);
            this.Label_PhongNumber.TabIndex = 16;
            this.Label_PhongNumber.Text = "Phone number";
            // 
            // Label_SignIn
            // 
            this.Label_SignIn.AutoSize = true;
            this.Label_SignIn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.Label_SignIn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Label_SignIn.Location = new System.Drawing.Point(72, 32);
            this.Label_SignIn.Name = "Label_SignIn";
            this.Label_SignIn.Size = new System.Drawing.Size(142, 46);
            this.Label_SignIn.TabIndex = 15;
            this.Label_SignIn.Text = "Sign up";
            // 
            // Label_Username
            // 
            this.Label_Username.AutoSize = true;
            this.Label_Username.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Label_Username.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Label_Username.Location = new System.Drawing.Point(76, 157);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(89, 23);
            this.Label_Username.TabIndex = 14;
            this.Label_Username.Text = "Username";
            // 
            // TextBox_Username
            // 
            this.TextBox_Username.Location = new System.Drawing.Point(76, 183);
            this.TextBox_Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.Size = new System.Drawing.Size(252, 22);
            this.TextBox_Username.TabIndex = 13;
            // 
            // TextBox_FullName
            // 
            this.TextBox_FullName.Location = new System.Drawing.Point(76, 132);
            this.TextBox_FullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox_FullName.Name = "TextBox_FullName";
            this.TextBox_FullName.Size = new System.Drawing.Size(252, 22);
            this.TextBox_FullName.TabIndex = 12;
            // 
            // Label_FullName
            // 
            this.Label_FullName.AutoSize = true;
            this.Label_FullName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Label_FullName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Label_FullName.Location = new System.Drawing.Point(76, 106);
            this.Label_FullName.Name = "Label_FullName";
            this.Label_FullName.Size = new System.Drawing.Size(88, 23);
            this.Label_FullName.TabIndex = 11;
            this.Label_FullName.Text = "Full name";
            // 
            // Button_SignIn
            // 
            this.Button_SignIn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Button_SignIn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Button_SignIn.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.Button_SignIn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Button_SignIn.Location = new System.Drawing.Point(138, 479);
            this.Button_SignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_SignIn.Name = "Button_SignIn";
            this.Button_SignIn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Button_SignIn.Size = new System.Drawing.Size(118, 36);
            this.Button_SignIn.TabIndex = 10;
            this.Button_SignIn.Text = "SIGN UP";
            this.Button_SignIn.UseCompatibleTextRendering = true;
            this.Button_SignIn.UseVisualStyleBackColor = false;
            this.Button_SignIn.Click += new System.EventHandler(this.Button_SignUp_Click);
            // 
            // Form_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1077, 588);
            this.Controls.Add(this.Panel_SIGNUP);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayArt";
            this.Panel_SIGNUP.ResumeLayout(false);
            this.Panel_SIGNUP.PerformLayout();
            this.Panel_Capt.ResumeLayout(false);
            this.Panel_Capt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Panel_SIGNUP;
        private Panel Panel_Capt;
        private CheckBox CheckBox_Capt;
        private Label Label_ConfirmPass;
        private TextBox TextBox_ConfirmPass;
        private TextBox TextBox_PassW;
        private Label Label_PassW;
        private Label Label_Email;
        private TextBox TextBox_Email;
        private TextBox TextBox_PhoneNumber;
        private Label Label_PhongNumber;
        private Label Label_SignIn;
        private Label Label_Username;
        private TextBox TextBox_Username;
        private TextBox TextBox_FullName;
        private Label Label_FullName;
        private Button Button_SignIn;
        private Label Label_Captcha;
    }
}