using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace E_CommerceSystem
{
    public partial class Login : KryptonForm

    {
        public Login()
        {
            InitializeComponent();
        }

        private void log_in_Click(object sender, EventArgs e)
        {

        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            su.Show();
        }

        private void user_name_Click(object sender, EventArgs e)
        {
            user_name.Text = string.Empty;
        }

        private void password_Click(object sender, EventArgs e)
        {
            password.Text = string.Empty;
        }
    }
}
