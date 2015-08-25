using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;
using QLQuanCafe.Common;
using QLQuanCafe.DTO;

namespace QLQuanCafe.GUI.Dialog
{
    public partial class frmThemNguyenLieu : MetroForm
    {
        private UnitBll unitbll = LocatorBll.UnitVM;
        private MaterialBll materialBll = LocatorBll.MaterialVM;
        public frmThemNguyenLieu()
        {
            InitializeComponent();
        }

        private void ThemThongTinNguyenLieu_Load(object sender, EventArgs e)
        {
            loadDonViTinh();
        }

        private void loadDonViTinh()
        {
            cbxDonViTinh.DataSource = unitbll.ListUnit;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            String message = string.Empty;

            if (string.IsNullOrEmpty(TxtTenNguyenLieu.Text.Trim()))
                message += "Tên nguyên liệu không được bỏ trống.\n";
            if (cbxDonViTinh.SelectedItem == null)
                message += "Đơn vị tính không được bỏ trống.\n";

            if (!string.IsNullOrEmpty(message))
            {
                MessageDialogHelper.CreateErrorMessage(message);
                return;
            }

            MaterialData materialData = new MaterialData();

            materialData.MaterialName = TxtTenNguyenLieu.Text.Trim();
            materialData.Price = (decimal)dipDonGia.Value;
            materialData.Unit = cbxDonViTinh.SelectedItem as UnitData;

            materialBll.MaterialToSave = materialData;

            if (materialBll.AddMaterial())
            {
                if (MessageDialogHelper.CreateInformationMessage("Lưu thành công.") == DialogResult.OK)
                    this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemDvt_Click(object sender, EventArgs e)
        {
            if (unitbll.ShowAddUnitWindowCommand.CanExecute(null))
            {
                unitbll.ShowAddUnitWindowCommand.Execute(null);
                loadDonViTinh();
                cbxDonViTinh.SelectedIndex = cbxDonViTinh.FindString(unitbll.UnitToSave.UnitName);

            }
        }
    }
}
