using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;
using QLQuanCafe.Common;

namespace QLQuanCafe.GUI.Dialog
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void BLogin_Click(object sender, EventArgs e)
        {
           
 LogintoSystem();
        }

        private void LogintoSystem()
        {
            String message = string.Empty;

            if (string.IsNullOrEmpty(txtUserName.Text))
                message += "Tên tài khoản không được bỏ trống.\n";
            if (string.IsNullOrEmpty(txtPassword.Text))
                message += "Mật khẩu không được bỏ trống.\n";

            if (!string.IsNullOrEmpty(message))
            {
                MessageDialogHelper.CreateErrorMessage(message);
                return;
            }

            if (LocatorBll.LoginBll.Login(txtUserName.Text, txtPassword.Text))
            {
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LogintoSystem();
            }
        }
    }
}
