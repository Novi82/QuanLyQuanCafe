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
            DonViTinh.Text = LocatorBll.UnitVM.UnitToSave.UnitName;
        }

        private void btnAccept(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DonViTinh.Text))
            {
                MessageDialogHelper.CreateErrorMessage("Tên đơn vị tính không được để trống.");
                return;
            }
            LocatorBll.UnitVM.UnitToSave.UnitName = DonViTinh.Text;
            if (LocatorBll.UnitVM.EditUnit())
            {
                if (MessageDialogHelper.CreateInformationMessage("Lưu thành công.") == DialogResult.OK)
                    this.Close();
            }
        }
    }
}
