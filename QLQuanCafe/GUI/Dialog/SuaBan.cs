using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;
using QLQuanCafe.Common;

namespace QLQuanCafe.GUI.Dialog
{
    public partial class SuaBan : MetroForm
    {
        public SuaBan()
        {
            InitializeComponent();
        }

        private void SuaBan_Load(object sender, EventArgs e)
        {
            txtTenBan.Text = LocatorBll.AreaAndTableVM.TableSelected.TableName;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenBan.Text))
            {
                MessageDialogHelper.CreateErrorMessage("Tên bàn không được để trống.");
                return;
            }
            LocatorBll.AreaAndTableVM.TableToSave.TableName = txtTenBan.Text;
            if (LocatorBll.AreaAndTableVM.EditTable())
            {
                if (MessageDialogHelper.CreateInformationMessage("Lưu thành công.") == DialogResult.OK)
                    this.Close();
            }
        }
    }
}
