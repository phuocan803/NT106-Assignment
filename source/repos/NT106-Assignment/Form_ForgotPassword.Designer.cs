using System.Drawing;
using System.Windows.Forms;


namespace NT106_Assignment
{
    partial class Form_ForgotPassword
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelForgotPassword = new System.Windows.Forms.Panel();
            this.textEmailorPhoneNumber = new System.Windows.Forms.TextBox();
            this.panelCaptcha = new System.Windows.Forms.Panel();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.labelCaptcha = new System.Windows.Forms.Label();
            this.labelForgotPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonSendCode = new System.Windows.Forms.Button();
            this.panelForgotPassword.SuspendLayout();
            this.panelCaptcha.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Location = new System.Drawing.Point(62, 19);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(669, 29);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // panelForgotPassword
            // 
            this.panelForgotPassword.BackColor = System.Drawing.Color.White;
            this.panelForgotPassword.Controls.Add(this.textEmailorPhoneNumber);
            this.panelForgotPassword.Controls.Add(this.panelCaptcha);
            this.panelForgotPassword.Controls.Add(this.labelForgotPassword);
            this.panelForgotPassword.Controls.Add(this.labelEmail);
            this.panelForgotPassword.Controls.Add(this.buttonSendCode);
            this.panelForgotPassword.Location = new System.Drawing.Point(213, 85);
            this.panelForgotPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelForgotPassword.Name = "panelForgotPassword";
            this.panelForgotPassword.Size = new System.Drawing.Size(357, 299);
            this.panelForgotPassword.TabIndex = 1;
            this.panelForgotPassword.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForgotPassword_Paint);
            // 
            // textEmailorPhoneNumber
            // 
            this.textEmailorPhoneNumber.BackColor = System.Drawing.Color.White;
            this.textEmailorPhoneNumber.Location = new System.Drawing.Point(36, 109);
            this.textEmailorPhoneNumber.Name = "textEmailorPhoneNumber";
            this.textEmailorPhoneNumber.Size = new System.Drawing.Size(260, 20);
            this.textEmailorPhoneNumber.TabIndex = 7;
            this.textEmailorPhoneNumber.TextChanged += new System.EventHandler(this.textEmailorPhoneNumber_TextChanged);
            // 
            // panelCaptcha
            // 
            this.panelCaptcha.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelCaptcha.Controls.Add(this.checkBox);
            this.panelCaptcha.Controls.Add(this.labelCaptcha);
            this.panelCaptcha.Location = new System.Drawing.Point(36, 162);
            this.panelCaptcha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCaptcha.Name = "panelCaptcha";
            this.panelCaptcha.Size = new System.Drawing.Size(260, 30);
            this.panelCaptcha.TabIndex = 6;
            this.panelCaptcha.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCaptcha_Paint);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(8, 8);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 14);
            this.checkBox.TabIndex = 3;
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // labelCaptcha
            // 
            this.labelCaptcha.AutoSize = true;
            this.labelCaptcha.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelCaptcha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelCaptcha.ForeColor = System.Drawing.Color.White;
            this.labelCaptcha.Location = new System.Drawing.Point(62, 3);
            this.labelCaptcha.Name = "labelCaptcha";
            this.labelCaptcha.Size = new System.Drawing.Size(143, 21);
            this.labelCaptcha.TabIndex = 2;
            this.labelCaptcha.Text = "[ I\'m not a ROBOT ]";
            this.labelCaptcha.Click += new System.EventHandler(this.labelCaptcha_Click);
            // 
            // labelForgotPassword
            // 
            this.labelForgotPassword.AutoSize = true;
            this.labelForgotPassword.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelForgotPassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelForgotPassword.Location = new System.Drawing.Point(31, 29);
            this.labelForgotPassword.Name = "labelForgotPassword";
            this.labelForgotPassword.Size = new System.Drawing.Size(187, 30);
            this.labelForgotPassword.TabIndex = 3;
            this.labelForgotPassword.Text = "Forgot Password";
            this.labelForgotPassword.Click += new System.EventHandler(this.labelForgotPassword_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.White;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelEmail.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelEmail.Location = new System.Drawing.Point(36, 79);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(52, 27);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email ";
            this.labelEmail.UseCompatibleTextRendering = true;
            this.labelEmail.Click += new System.EventHandler(this.labelEmailorPhoneNumber_Click);
            // 
            // buttonSendCode
            // 
            this.buttonSendCode.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSendCode.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonSendCode.ForeColor = System.Drawing.Color.White;
            this.buttonSendCode.Location = new System.Drawing.Point(102, 246);
            this.buttonSendCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSendCode.Name = "buttonSendCode";
            this.buttonSendCode.Size = new System.Drawing.Size(159, 32);
            this.buttonSendCode.TabIndex = 0;
            this.buttonSendCode.Text = "Send code";
            this.buttonSendCode.UseVisualStyleBackColor = false;
            this.buttonSendCode.Click += new System.EventHandler(this.buttonSendCode_Click);
            // 
            // Form_ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(789, 395);
            this.Controls.Add(this.panelForgotPassword);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_ForgotPassword";
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.Form_ForgotPassword_Load);
            this.panelForgotPassword.ResumeLayout(false);
            this.panelForgotPassword.PerformLayout();
            this.panelCaptcha.ResumeLayout(false);
            this.panelCaptcha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelHeader;
        private Panel panelForgotPassword;
        private Label labelForgotPassword;
        private Label labelCaptcha;
        private Label labelEmail;
        private Button buttonSendCode;
        private Panel panelCaptcha;
        private TextBox textEmailorPhoneNumber;
        private CheckBox checkBox;
    }
}