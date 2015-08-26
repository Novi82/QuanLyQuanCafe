using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;
using QLQuanCafe.Common;
using QLQuanCafe.DTO;

namespace QLQuanCafe.GUI.Dialog
{
    public partial class ThemLoaiMonAn : MetroForm
    {
        public ThemLoaiMonAn()
        {
            InitializeComponent();
        }

        private void ThemLoaiMonAn_Load(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenLoaiMon.Text.Trim()))
            {
                MessageDialogHelper.CreateErrorMessage("Tên loại món ăn không được để trống.");
                return;
            }

            MenuCategoryData menuCategoryData = new MenuCategoryData();
            menuCategoryData.MenuCategoryName = txtTenLoaiMon.Text.Trim();
            LocatorBll.MenuCategoryAndMenuItemBll.MenuCategoryToSave = menuCategoryData;

            if (LocatorBll.MenuCategoryAndMenuItemBll.AddMenuCategory())
            {
                if (MessageDialogHelper.CreateInformationMessage("Lưu thành công.") == DialogResult.OK)
                    this.Close();
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
