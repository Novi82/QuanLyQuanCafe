using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;
using QLQuanCafe.Common;

namespace QLQuanCafe.GUI.Dialog
{
    public partial class SuaLoaiMonAn : MetroForm
    {
        private readonly MenuCategoryAndMenuItemBll bll = LocatorBll.MenuCategoryAndMenuItemVM;
        public SuaLoaiMonAn()
        {
            InitializeComponent();
        }

        private void SuaLoaiMonAn_Load(object sender, EventArgs e)
        {
            txtTenLoaiMonAn.Text = bll.MenuCategorySelected.MenuCategoryName;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenLoaiMonAn.Text.Trim()))
            {
                MessageDialogHelper.CreateErrorMessage("Tên loại món ăn không được để trống.");
                return;
            }
            bll.MenuCategoryToSave.MenuCategoryName = txtTenLoaiMonAn.Text.Trim();
            if (bll.EditMenuCategory())
            {
                if (MessageDialogHelper.CreateInformationMessage("Lưu thành công.") == DialogResult.OK)
                    this.Close();
            }
        }
    }
}
