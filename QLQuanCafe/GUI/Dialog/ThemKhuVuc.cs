using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;
using QLQuanCafe.Common;
using QLQuanCafe.DTO;

namespace QLQuanCafe.GUI.Dialog
{
    public partial class ThemKhuVuc : MetroForm
    {
        public ThemKhuVuc()
        {
            InitializeComponent();
        }

        private void ThemKhuVuc_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKhuVuc.Text.Trim()))
            {
                MessageDialogHelper.CreateErrorMessage("Tên khu vực không được để trống.");
                return;
            }

            AreaData areaToSave = new AreaData();
            areaToSave.AreaName = txtKhuVuc.Text.Trim();
            LocatorBll.AreaAndTableVM.AreaToSave = areaToSave;

            if (LocatorBll.AreaAndTableVM.AddArea())
            {
                if (MessageDialogHelper.CreateInformationMessage("Lưu thành công.") == DialogResult.OK)
                    this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
