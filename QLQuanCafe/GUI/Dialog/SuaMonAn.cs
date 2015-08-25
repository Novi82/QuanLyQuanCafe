using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;
using QLQuanCafe.Common;
using QLQuanCafe.DTO;

namespace QLQuanCafe.GUI.Dialog
{
    public partial class SuaMonAn : MetroForm
    {
        private MenuCategoryAndMenuItemBll bll = LocatorBll.MenuCategoryAndMenuItemVM;
        private UnitBll unitbll = LocatorBll.UnitVM;
        public SuaMonAn()
        {
            InitializeComponent();
        }

        private void SuaMonAn_Load(object sender, EventArgs e)
        {
            MenuItemData selectedItem = bll.MenuItemSelected;
            txtTenMonAn.Text = selectedItem.MenuItemName;
            cbxLoaiMonAn.DataSource = bll.ListMenuCategory;
            cbxLoaiMonAn.SelectedIndex = cbxLoaiMonAn.FindString(selectedItem.MenuCategory.MenuCategoryName);

            dipDonGia.Value = (double)selectedItem.Price;
            LoadDonViTinh();
            cbxDonViTinh.SelectedIndex = cbxDonViTinh.FindString(selectedItem.Unit.UnitName);

        }

        private void LoadDonViTinh()
        {
            cbxDonViTinh.DataSource = unitbll.ListUnit;
            
        }
        private void bntDongY_Click(object sender, EventArgs e)
        {
            String message = string.Empty;

            if (string.IsNullOrEmpty(txtTenMonAn.Text))
                message += "Tên món ăn không được bỏ trống.\n";
            if (cbxDonViTinh.SelectedItem == null)
                message += "Đơn vị tính không được bỏ trống.\n";

            bll.MenuItemToSave.MenuItemName = txtTenMonAn.Text.Trim();
            bll.MenuItemToSave.MenuCategory = cbxLoaiMonAn.SelectedItem as MenuCategoryData;
            bll.MenuItemToSave.Price = (decimal)dipDonGia.Value;
            bll.MenuItemToSave.Unit = cbxDonViTinh.SelectedItem as UnitData;

            if (!string.IsNullOrEmpty(message))
            {
                MessageDialogHelper.CreateErrorMessage(message);
                return;
            }

            if (bll.EditMenuItem())
            {
                if (MessageDialogHelper.CreateInformationMessage("Lưu thành công.") == DialogResult.OK)
                    this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            if (unitbll.ShowAddUnitWindowCommand.CanExecute(null))
            {
                unitbll.ShowAddUnitWindowCommand.Execute(null);
                LoadDonViTinh();
                cbxDonViTinh.SelectedIndex = cbxDonViTinh.FindString(unitbll.UnitToSave.UnitName);
            }
        }



        
    }
}
