using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace NT106_Assignment
{
    partial class Form_Login
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Panel_LOGIN = new System.Windows.Forms.Panel();
            this.Button_CreateAcc = new System.Windows.Forms.Button();
            this.Button_LOGIN = new System.Windows.Forms.Button();
            this.TextBox_Pass = new System.Windows.Forms.TextBox();
            this.TextBox_Acc = new System.Windows.Forms.TextBox();
            this.Label_OR = new System.Windows.Forms.Label();
            this.LinkLb_ForgotPass = new System.Windows.Forms.LinkLabel();
            this.Label_Login = new System.Windows.Forms.Label();
            this.Panel_Captcha = new System.Windows.Forms.Panel();
            this.CheckBox_Catpcha = new System.Windows.Forms.CheckBox();
            this.Label_Captcha = new System.Windows.Forms.Label();
            this.Label_Acc = new System.Windows.Forms.Label();
            this.Label_Pass = new System.Windows.Forms.Label();
            this.Panel_LOGIN.SuspendLayout();
            this.Panel_Captcha.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Panel_LOGIN
            // 
            this.Panel_LOGIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_LOGIN.BackColor = System.Drawing.Color.White;
            this.Panel_LOGIN.Controls.Add(this.Button_CreateAcc);
            this.Panel_LOGIN.Controls.Add(this.Button_LOGIN);
            this.Panel_LOGIN.Controls.Add(this.TextBox_Pass);
            this.Panel_LOGIN.Controls.Add(this.TextBox_Acc);
            this.Panel_LOGIN.Controls.Add(this.Label_OR);
            this.Panel_LOGIN.Controls.Add(this.LinkLb_ForgotPass);
            this.Panel_LOGIN.Controls.Add(this.Label_Login);
            this.Panel_LOGIN.Controls.Add(this.Panel_Captcha);
            this.Panel_LOGIN.Controls.Add(this.Label_Acc);
            this.Panel_LOGIN.Controls.Add(this.Label_Pass);
            this.Panel_LOGIN.Location = new System.Drawing.Point(316, 57);
            this.Panel_LOGIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_LOGIN.Name = "Panel_LOGIN";
            this.Panel_LOGIN.Size = new System.Drawing.Size(381, 469);
            this.Panel_LOGIN.TabIndex = 6;
            // 
            // Button_CreateAcc
            // 
            this.Button_CreateAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_CreateAcc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Button_CreateAcc.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Button_CreateAcc.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.Button_CreateAcc.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Button_CreateAcc.Location = new System.Drawing.Point(120, 397);
            this.Button_CreateAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_CreateAcc.Name = "Button_CreateAcc";
            this.Button_CreateAcc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Button_CreateAcc.Size = new System.Drawing.Size(141, 44);
            this.Button_CreateAcc.TabIndex = 34;
            this.Button_CreateAcc.Text = "Create Account";
            this.Button_CreateAcc.UseCompatibleTextRendering = true;
            this.Button_CreateAcc.UseVisualStyleBackColor = false;
            this.Button_CreateAcc.Click += new System.EventHandler(this.Button_CreateAcc_Click);
            // 
            // Button_LOGIN
            // 
            this.Button_LOGIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_LOGIN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Button_LOGIN.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Button_LOGIN.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.Button_LOGIN.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Button_LOGIN.Location = new System.Drawing.Point(132, 311);
            this.Button_LOGIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_LOGIN.Name = "Button_LOGIN";
            this.Button_LOGIN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Button_LOGIN.Size = new System.Drawing.Size(118, 36);
            this.Button_LOGIN.TabIndex = 25;
            this.Button_LOGIN.Text = "LOGIN";
            this.Button_LOGIN.UseCompatibleTextRendering = true;
            this.Button_LOGIN.UseVisualStyleBackColor = false;
            // 
            // TextBox_Pass
            // 
            this.TextBox_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_Pass.Location = new System.Drawing.Point(67, 189);
            this.TextBox_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox_Pass.Name = "TextBox_Pass";
            this.TextBox_Pass.PasswordChar = '*';
            this.TextBox_Pass.Size = new System.Drawing.Size(252, 22);
            this.TextBox_Pass.TabIndex = 28;
            // 
            // TextBox_Acc
            // 
            this.TextBox_Acc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_Acc.Location = new System.Drawing.Point(68, 134);
            this.TextBox_Acc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox_Acc.Name = "TextBox_Acc";
            this.TextBox_Acc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBox_Acc.Size = new System.Drawing.Size(252, 22);
            this.TextBox_Acc.TabIndex = 27;
            // 
            // Label_OR
            // 
            this.Label_OR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_OR.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label_OR.Location = new System.Drawing.Point(62, 366);
            this.Label_OR.Name = "Label_OR";
            this.Label_OR.Size = new System.Drawing.Size(265, 16);
            this.Label_OR.TabIndex = 33;
            this.Label_OR.Text = "_______________OR_______________";
            this.Label_OR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LinkLb_ForgotPass
            // 
            this.LinkLb_ForgotPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LinkLb_ForgotPass.AutoSize = true;
            this.LinkLb_ForgotPass.LinkColor = System.Drawing.Color.DodgerBlue;
            this.LinkLb_ForgotPass.Location = new System.Drawing.Point(65, 267);
            this.LinkLb_ForgotPass.Name = "LinkLb_ForgotPass";
            this.LinkLb_ForgotPass.Size = new System.Drawing.Size(119, 16);
            this.LinkLb_ForgotPass.TabIndex = 32;
            this.LinkLb_ForgotPass.TabStop = true;
            this.LinkLb_ForgotPass.Text = "Forgot Password ?";
            // 
            // Label_Login
            // 
            this.Label_Login.AutoSize = true;
            this.Label_Login.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.Label_Login.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Label_Login.Location = new System.Drawing.Point(55, 31);
            this.Label_Login.Name = "Label_Login";
            this.Label_Login.Size = new System.Drawing.Size(110, 46);
            this.Label_Login.TabIndex = 30;
            this.Label_Login.Text = "Login";
            // 
            // Panel_Captcha
            // 
            this.Panel_Captcha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_Captcha.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Panel_Captcha.Controls.Add(this.CheckBox_Catpcha);
            this.Panel_Captcha.Controls.Add(this.Label_Captcha);
            this.Panel_Captcha.Location = new System.Drawing.Point(67, 225);
            this.Panel_Captcha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_Captcha.Name = "Panel_Captcha";
            this.Panel_Captcha.Size = new System.Drawing.Size(252, 37);
            this.Panel_Captcha.TabIndex = 31;
            // 
            // CheckBox_Catpcha
            // 
            this.CheckBox_Catpcha.AutoSize = true;
            this.CheckBox_Catpcha.Location = new System.Drawing.Point(13, 11);
            this.CheckBox_Catpcha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBox_Catpcha.Name = "CheckBox_Catpcha";
            this.CheckBox_Catpcha.Size = new System.Drawing.Size(18, 17);
            this.CheckBox_Catpcha.TabIndex = 15;
            this.CheckBox_Catpcha.UseVisualStyleBackColor = true;
            // 
            // Label_Captcha
            // 
            this.Label_Captcha.AutoSize = true;
            this.Label_Captcha.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.Label_Captcha.ForeColor = System.Drawing.Color.Transparent;
            this.Label_Captcha.Location = new System.Drawing.Point(68, 11);
            this.Label_Captcha.Name = "Label_Captcha";
            this.Label_Captcha.Size = new System.Drawing.Size(115, 15);
            this.Label_Captcha.TabIndex = 11;
            this.Label_Captcha.Text = "[ I\'m not a ROBOT ]";
            // 
            // Label_Acc
            // 
            this.Label_Acc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Acc.AutoSize = true;
            this.Label_Acc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Label_Acc.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Label_Acc.Location = new System.Drawing.Point(64, 106);
            this.Label_Acc.Name = "Label_Acc";
            this.Label_Acc.Size = new System.Drawing.Size(75, 23);
            this.Label_Acc.TabIndex = 26;
            this.Label_Acc.Text = "Account";
            // 
            // Label_Pass
            // 
            this.Label_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Pass.AutoSize = true;
            this.Label_Pass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Label_Pass.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Label_Pass.Location = new System.Drawing.Point(64, 161);
            this.Label_Pass.Name = "Label_Pass";
            this.Label_Pass.Size = new System.Drawing.Size(78, 23);
            this.Label_Pass.TabIndex = 29;
            this.Label_Pass.Text = "Pasword";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1019, 572);
            this.Controls.Add(this.Panel_LOGIN);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "KayArt";
            this.Panel_LOGIN.ResumeLayout(false);
            this.Panel_LOGIN.PerformLayout();
            this.Panel_Captcha.ResumeLayout(false);
            this.Panel_Captcha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private ContextMenuStrip contextMenuStrip1;
        private ToolTip toolTip1;
        private Panel Panel_LOGIN;
        private Button Button_CreateAcc;
        private Button Button_LOGIN;
        private TextBox TextBox_Pass;
        private TextBox TextBox_Acc;
        private Label Label_OR;
        private LinkLabel LinkLb_ForgotPass;
        private Label Label_Login;
        private Panel Panel_Captcha;
        private CheckBox CheckBox_Catpcha;
        private Label Label_Captcha;
        private Label Label_Acc;
        private Label Label_Pass;
    }
}
