using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;
using QLQuanCafe.Common;
using QLQuanCafe.DTO;

namespace QLQuanCafe.GUI.Dialog
{
    public partial class ThemMonAn : MetroForm
    {
        private UnitBll unitBll = LocatorBll.UnitVM;
        public ThemMonAn()
        {
            InitializeComponent();
        }

        private void ThemMonAn_Load(object sender, EventArgs e)
        {
            LoadDonViTinh();
        }

        private void LoadDonViTinh()
        {
            cbxDonViTinh.DataSource = unitBll.ListUnit;
        }

        private void ImgaeA_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            String message = string.Empty;

            if (string.IsNullOrEmpty(txtTenMonAn.Text))
                message += "Tên món ăn không được bỏ trống.\n";
            if (cbxDonViTinh.SelectedItem == null)
                message += "Đơn vị tính không được bỏ trống.\n";

            if (!string.IsNullOrEmpty(message))
            {
                MessageDialogHelper.CreateErrorMessage(message);
                return;
            }

            MenuItemData menuItemData= new MenuItemData();

            menuItemData.MenuItemName = txtTenMonAn.Text;
//            TODO     
//            menuItemData.ImagePath
            menuItemData.MenuCategory = LocatorBll.MenuCategoryAndMenuItemVM.MenuCategorySelected;
            menuItemData.Price = (decimal)dipDonGia.Value;
            menuItemData.Unit = cbxDonViTinh.SelectedItem as UnitData;

            LocatorBll.MenuCategoryAndMenuItemVM.MenuItemToSave = menuItemData;

            if (LocatorBll.MenuCategoryAndMenuItemVM.AddMenuItem())
            {
                if (MessageDialogHelper.CreateInformationMessage("Lưu thành công.") == DialogResult.OK)
                    this.Close();
            }
        }
    }
}
