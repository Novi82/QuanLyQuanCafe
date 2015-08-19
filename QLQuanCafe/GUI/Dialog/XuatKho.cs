using System;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;

namespace QLQuanCafe.GUI.Dialog
{
    public partial class XuatKho : MetroForm
    {
        private MaterialBll materialBll = LocatorBll.MaterialVM;
        public XuatKho()
        {
            InitializeComponent();
        }

        private void XuatKho_Load(object sender, EventArgs e)
        {
            txtTenNguyenLieu.Text = materialBll.MaterialSelected.MaterialName;
            txtGiaNhap.Text = materialBll.MaterialSelected.Price.ToString();
            txtMaNguyenLieu.Text = materialBll.MaterialSelected.MaterialId;
            txtDonViTinh.Text = materialBll.MaterialSelected.Unit.UnitName;
            dipSoLuong.MaxValue = materialBll.MaterialSelected.Quantity;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            materialBll.MaterialToSave.Quantity = Convert.ToInt32(dipSoLuong.Value);
            if (materialBll.ExportMaterial())
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
