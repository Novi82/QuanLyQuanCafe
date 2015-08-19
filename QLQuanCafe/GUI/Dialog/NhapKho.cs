using System;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;

namespace QLQuanCafe.GUI.Dialog
{
    public partial class NhapKho : MetroForm
    {
        private MaterialBll materialBll = LocatorBll.MaterialVM;

        public NhapKho()
        {
            InitializeComponent();
        }

        private void NhapKho_Load(object sender, EventArgs e)
        {
            txtTenNguyenLieu.Text = materialBll.MaterialSelected.MaterialName;
            txtGiaNhap.Text = materialBll.MaterialSelected.Price.ToString();
            txtMaNguyenLieu.Text = materialBll.MaterialSelected.MaterialId;
            txtDonViTinh.Text = materialBll.MaterialSelected.Unit.UnitName;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            materialBll.MaterialToSave.Quantity = Convert.ToInt32(dipSoLuong.Value);
            if (materialBll.ImportMaterial())
            {
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
