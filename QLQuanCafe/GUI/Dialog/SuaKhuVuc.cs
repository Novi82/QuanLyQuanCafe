using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;
using QLQuanCafe.Common;

namespace QLQuanCafe.GUI.Dialog
{
    public partial class SuaKhuVuc : MetroForm
    {
        public SuaKhuVuc()
        {
            InitializeComponent();
        }

        private void SuaKhuVuc_Load(object sender, EventArgs e)
        {
            txtTenKhuVuc.Text = LocatorBll.AreaAndTableVM.AreaToSave.AreaName;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenKhuVuc.Text))
            {
                MessageDialogHelper.CreateErrorMessage("Tên khu vực không được để trống.");
                return;
            }
            LocatorBll.AreaAndTableVM.AreaToSave.AreaName = txtTenKhuVuc.Text;    

            if (LocatorBll.AreaAndTableVM.EditArea())
            {
                if (MessageDialogHelper.CreateInformationMessage("Lưu thành công.") == DialogResult.OK)
                    this.Close();
            }
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
