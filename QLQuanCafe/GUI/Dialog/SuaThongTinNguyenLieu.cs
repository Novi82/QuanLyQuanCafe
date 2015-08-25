using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;
using QLQuanCafe.Common;
using QLQuanCafe.DTO;

namespace QLQuanCafe.GUI.Dialog
{
    public partial class frmSuaThongTinNguyenLieu : MetroForm
    {
        private UnitBll unitBll = LocatorBll.UnitVM;
        private MaterialBll materialBll = LocatorBll.MaterialVM;
        public frmSuaThongTinNguyenLieu()
        {
            InitializeComponent();
        }

        private void SuaThongTinNguyenLieu_Load(object sender, EventArgs e)
        {
            MaterialData materialData = materialBll.MaterialSelected;
            txtTenNguyenLieu.Text = materialData.MaterialName;

//            dipDonGia.Value = (double)materialData.Price;

            LoadDonViTinh();
            cbxDonViTinh.SelectedIndex = cbxDonViTinh.FindString(materialData.Unit.UnitName);
        }

        private void LoadDonViTinh()
        {
            cbxDonViTinh.DataSource = unitBll.ListUnit;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            String message = string.Empty;

            if (string.IsNullOrEmpty(txtTenNguyenLieu.Text.Trim()))
                message += "Tên nguyên liệu không được bỏ trống.\n";
            if (cbxDonViTinh.SelectedItem == null)
                message += "Đơn vị tính không được bỏ trống.\n";

            if (!string.IsNullOrEmpty(message))
            {
                MessageDialogHelper.CreateErrorMessage(message);
                return;
            }

            materialBll.MaterialToSave.MaterialName = txtTenNguyenLieu.Text.Trim();
//            materialBll.MaterialToSave.Price = (decimal)dipDonGia.Value;
            materialBll.MaterialToSave.Unit = cbxDonViTinh.SelectedItem as UnitData;

            if (materialBll.EditMaterial())
            {
                if (MessageDialogHelper.CreateInformationMessage("Lưu thành công.") == DialogResult.OK)
                    this.Close();
            }
        }

        private void btnThemDonViTinh_Click(object sender, EventArgs e)
        {
            if (unitBll.ShowAddUnitWindowCommand.CanExecute(null))
            {
                unitBll.ShowAddUnitWindowCommand.Execute(null);
                LoadDonViTinh();
                cbxDonViTinh.SelectedIndex = cbxDonViTinh.FindString(unitBll.UnitToSave.UnitName);
            }       
        }
    }
}
