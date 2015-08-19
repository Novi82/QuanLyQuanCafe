﻿using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;
using QLQuanCafe.Common;
using QLQuanCafe.DTO;

namespace QLQuanCafe.GUI.Dialog
{
    public partial class ThemTaiKhoan : MetroForm
    {
        private AccountBll bll = LocatorBll.AccountVM;
        public ThemTaiKhoan()
        {
            InitializeComponent();
            
        }

        private void ThemTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadQuyen();
        }

        private void LoadQuyen()
        {
            cbxQuyen.DataSource = bll.ListPermission;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            String message = string.Empty;

            if (string.IsNullOrEmpty(txtTenTaiKhoan.Text))
                message += "Tên tài khoản không được bỏ trống.\n";
            if (string.IsNullOrEmpty(txtMatKhau.Text))
                message += "Mật khẩu không được bỏ trống.\n";
            if (string.IsNullOrEmpty(txtMatKhau2.Text))
                message += "Mật khẩu nhập lại không được bỏ trống.\n";
            if (!string.IsNullOrEmpty(txtMatKhau.Text) && !string.IsNullOrEmpty(txtMatKhau2.Text) && !txtMatKhau.Text.Equals(txtMatKhau2.Text)) // should use equal();
                message += "Mật khẩu và mật khẩu nhập lại không trùng nhau.\n";
            if (cbxQuyen.SelectedItem == null)
                message += "Quyền không được bỏ trống.\n";

            if (!string.IsNullOrEmpty(message))
            {
                MessageDialogHelper.CreateErrorMessage(message);
                return;
            }

            AccountData accountData = new AccountData();
            accountData.UserName = txtTenTaiKhoan.Text;
            accountData.Password = txtMatKhau.Text;
            accountData.Permission = cbxQuyen.SelectedItem as PermissionData;
            bll.AccountToSave = accountData;

            if (bll.AddAccount(txtMatKhau.Text))
            {
                if (MessageDialogHelper.CreateInformationMessage("Lưu thành công.") == DialogResult.OK)
                    this.Close();
            }
        }
    }
}
