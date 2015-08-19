using System;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;

namespace QLQuanCafe.GUI.Dialog
{
    
    public partial class CapNhatKho : MetroForm
    {
        private MaterialBll materialBll = LocatorBll.MaterialVM;
        public CapNhatKho()
        {
            InitializeComponent();
        }

        private void HieuChinhSoLuong_Load(object sender, EventArgs e)
        {
            txtTenNguyenLieu.Text = materialBll.MaterialSelected.MaterialName;
            txtGiaNhap.Text = materialBll.MaterialSelected.Price.ToString();
            txtMaNguyenLieu.Text = materialBll.MaterialSelected.MaterialId;
            txtDonViTinh.Text = materialBll.MaterialSelected.Unit.UnitName;
            dipSoLuong.Value = materialBll.MaterialSelected.Quantity;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            materialBll.MaterialToSave.Quantity = Convert.ToInt32(dipSoLuong.Value);
            if (materialBll.UpdateInventory())
            {
                this.Close();
            }
        }
    }
}
