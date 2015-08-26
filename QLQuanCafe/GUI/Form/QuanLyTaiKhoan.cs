using System;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;

namespace QLQuanCafe.GUI.Form
{
    public partial class QuanLyTaiKhoan : MetroForm
    {
        private AccountBll bll = LocatorBll.AccountBll;
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void LoadAccount()
        {
            dgvTaiKhoan.DataSource = bll.ListAccount;
        }
        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count > 0)
            {
                if (bll.SelectAccountCommand.CanExecute(null))
                {
                    bll.SelectAccountCommand.Execute(dgvTaiKhoan.SelectedRows[0].DataBoundItem);
                }
            }
        }
        
        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            int index = dgvTaiKhoan.CurrentRow.Index;
            if (bll.ShowAddAccountWindowCommand.CanExecute(null))
            {
                bll.ShowAddAccountWindowCommand.Execute(null);
            }
            LoadAccount();
            dgvTaiKhoan.ClearSelection();
            dgvTaiKhoan.Rows[index].Selected = true;
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count > 0)
            {
                if (bll.DeleteAccountCommand.CanExecute(dgvTaiKhoan.SelectedRows[0]))
                {
                    bll.DeleteAccountCommand.Execute(dgvTaiKhoan.SelectedRows[0]);
                    LoadAccount();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
