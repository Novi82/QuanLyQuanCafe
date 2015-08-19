using System;
using DevComponents.DotNetBar.Metro;

namespace QLQuanCafe.GUI
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
            String message = string.Empty;
/*
            if (string.IsNullOrEmpty(TUser.Text))
                message += "Tên tài khoản không được bỏ trống.\n";
            if (string.IsNullOrEmpty(TPass.Password))
                message += "Mật khẩu không được bỏ trống.\n";

            if (!string.IsNullOrEmpty(message))
            {
                MessageDialogHelper.CreateErrorMessage(message);
                return;
            }

            if (LocatorViewModel.LoginVM.Login(MyPasswordBox.Password))
            {
                this.Close();
            }
 */
        }
    }
}
