using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;
using QLQuanCafe.Common;

namespace QLQuanCafe.GUI.Dialog
{
    public partial class SuaDonViTinh : MetroForm

    {
        public SuaDonViTinh()
        {
            InitializeComponent();
        }

        private void SuaDonViTinh_Load(object sender, EventArgs e)
        {
            DonViTinh.Text = LocatorBll.UnitBll.UnitToSave.UnitName;
        }

        private void btnAccept(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DonViTinh.Text.Trim()))
            {
                MessageDialogHelper.CreateErrorMessage("Tên đơn vị tính không được để trống.");
                return;
            }
            LocatorBll.UnitBll.UnitToSave.UnitName = DonViTinh.Text.Trim();
            if (LocatorBll.UnitBll.EditUnit())
            {
                if (MessageDialogHelper.CreateInformationMessage("Lưu thành công.") == DialogResult.OK)
                    this.Close();
            }
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
