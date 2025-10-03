using System.Drawing;
using System.Windows.Forms;

namespace NT106_Assignment
{
    partial class Form_ResetPassword
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
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.labelResetPassword = new System.Windows.Forms.Label();
            this.buttonResetPassword = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.panelResetPassword = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textConfirmPassword = new System.Windows.Forms.TextBox();
            this.panelResetPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelConfirmPassword.Location = new System.Drawing.Point(60, 226);
            this.labelConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(148, 21);
            this.labelConfirmPassword.TabIndex = 0;
            this.labelConfirmPassword.Text = "Confirm Password";
            this.labelConfirmPassword.Click += new System.EventHandler(this.labelConfirmPassword_Click);
            // 
            // labelResetPassword
            // 
            this.labelResetPassword.AutoEllipsis = true;
            this.labelResetPassword.AutoSize = true;
            this.labelResetPassword.Cursor = System.Windows.Forms.Cursors.No;
            this.labelResetPassword.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelResetPassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelResetPassword.Location = new System.Drawing.Point(60, 49);
            this.labelResetPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResetPassword.MaximumSize = new System.Drawing.Size(500, 200);
            this.labelResetPassword.MinimumSize = new System.Drawing.Size(200, 50);
            this.labelResetPassword.Name = "labelResetPassword";
            this.labelResetPassword.Size = new System.Drawing.Size(200, 50);
            this.labelResetPassword.TabIndex = 1;
            this.labelResetPassword.Text = "Reset Password";
            this.labelResetPassword.Click += new System.EventHandler(this.labelResetPassword_Click);
            // 
            // buttonResetPassword
            // 
            this.buttonResetPassword.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonResetPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonResetPassword.ForeColor = System.Drawing.Color.White;
            this.buttonResetPassword.Location = new System.Drawing.Point(139, 336);
            this.buttonResetPassword.Margin = new System.Windows.Forms.Padding(4);
            this.buttonResetPassword.Name = "buttonResetPassword";
            this.buttonResetPassword.Size = new System.Drawing.Size(226, 52);
            this.buttonResetPassword.TabIndex = 4;
            this.buttonResetPassword.Text = "Reset Password";
            this.buttonResetPassword.UseVisualStyleBackColor = false;
            this.buttonResetPassword.Click += new System.EventHandler(this.buttonResetPassword_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelPassword.Location = new System.Drawing.Point(60, 121);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(82, 21);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // panelResetPassword
            // 
            this.panelResetPassword.BackColor = System.Drawing.Color.White;
            this.panelResetPassword.Controls.Add(this.textConfirmPassword);
            this.panelResetPassword.Controls.Add(this.textPassword);
            this.panelResetPassword.Controls.Add(this.labelResetPassword);
            this.panelResetPassword.Controls.Add(this.buttonResetPassword);
            this.panelResetPassword.Controls.Add(this.labelPassword);
            this.panelResetPassword.Controls.Add(this.labelConfirmPassword);
            this.panelResetPassword.Location = new System.Drawing.Point(300, 121);
            this.panelResetPassword.Name = "panelResetPassword";
            this.panelResetPassword.Size = new System.Drawing.Size(479, 414);
            this.panelResetPassword.TabIndex = 6;
            this.panelResetPassword.Paint += new System.Windows.Forms.PaintEventHandler(this.panelResetPassword_Paint);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Location = new System.Drawing.Point(78, 25);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(896, 40);
            this.panelHeader.TabIndex = 7;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(65, 146);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(312, 29);
            this.textPassword.TabIndex = 6;
            this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            // 
            // textConfirmPassword
            // 
            this.textConfirmPassword.Location = new System.Drawing.Point(65, 261);
            this.textConfirmPassword.Name = "textConfirmPassword";
            this.textConfirmPassword.Size = new System.Drawing.Size(312, 29);
            this.textConfirmPassword.TabIndex = 7;
            this.textConfirmPassword.TextChanged += new System.EventHandler(this.textConfirmPassword_TextChanged);
            // 
            // Form_ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1048, 610);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelResetPassword);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Location = new System.Drawing.Point(100, 50);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_ResetPassword";
            this.Text = "Reset Password";
            this.Load += new System.EventHandler(this.Form_ResetPassword_Load);
            this.panelResetPassword.ResumeLayout(false);
            this.panelResetPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelConfirmPassword;
        private Label labelResetPassword;
        private Button buttonResetPassword;
        private Label labelPassword;
        private Panel panelResetPassword;
        private Panel panelHeader;
        private TextBox textConfirmPassword;
        private TextBox textPassword;
    }
}