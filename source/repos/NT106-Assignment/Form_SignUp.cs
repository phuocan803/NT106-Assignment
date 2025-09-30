using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106_Assignment
{
    public partial class Form_SignUp : Form
    {        
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

        private void Label_SignUp_Click(object sender, EventArgs e)
        {
            Form_Login loginForm = new Form_Login(this.Location, this.Size);
            loginForm.Show();
            this.Hide();
        }
    }

}
