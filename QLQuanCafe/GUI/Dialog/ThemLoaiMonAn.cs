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
            if (string.IsNullOrEmpty(txtTenLoaiMon.Text))
            {
                MessageDialogHelper.CreateErrorMessage("Tên loại món ăn không được để trống.");
                return;
            }

            MenuCategoryData menuCategoryData = new MenuCategoryData();
            menuCategoryData.MenuCategoryName = txtTenLoaiMon.Text;
            LocatorBll.MenuCategoryAndMenuItemVM.MenuCategoryToSave = menuCategoryData;

            if (LocatorBll.MenuCategoryAndMenuItemVM.AddMenuCategory())
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
