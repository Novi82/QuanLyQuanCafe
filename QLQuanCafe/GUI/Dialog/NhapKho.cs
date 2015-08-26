using System;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;
using QLQuanCafe.Common;

namespace QLQuanCafe.GUI.Dialog
{
    public partial class NhapKho : MetroForm
    {
        private MaterialBll materialBll = LocatorBll.MateriaBll;

        public NhapKho()
        {
            InitializeComponent();
        }

        private void NhapKho_Load(object sender, EventArgs e)
        {
            txtTenNguyenLieu.Text = materialBll.MaterialSelected.MaterialName;
            txtGiaNhap.Text = materialBll.MaterialSelected.Price.ToString("#,###");
            txtMaNguyenLieu.Text = materialBll.MaterialSelected.MaterialId;
            txtDonViTinh.Text = materialBll.MaterialSelected.Unit.UnitName;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        { int quantity = Convert.ToInt32(dipSoLuong.Value);
            if (quantity > 0)
            {
                materialBll.MaterialToSave.Quantity = Convert.ToInt32(dipSoLuong.Value);
                if (materialBll.ImportMaterial())
                {
                    this.Close();
                }
            }
            else
            {
                MessageDialogHelper.CreateErrorMessage("Số lượng phải lớn hơn 0");
                dipSoLuong.Focus();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
