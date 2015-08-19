using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;
using QLQuanCafe.Common;
using QLQuanCafe.DTO;

namespace QLQuanCafe.GUI.Dialog
{
    public partial class ThemBan : MetroForm
    {
        public ThemBan()
        {
            InitializeComponent();
        }

        private void ThemBan_Load(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenBan.Text))
            {
                MessageDialogHelper.CreateErrorMessage("Tên bàn không được để trống.");
                return;
            }
            TableData tableToSave = new TableData();
            tableToSave.TableName = txtTenBan.Text;

            // TODO test it plz
            tableToSave.Area = LocatorBll.AreaAndTableVM.AreaSelected;

            // TODO trang thai = ??
            tableToSave.TableState = "Trong";


            LocatorBll.AreaAndTableVM.TableToSave = tableToSave;

            if (LocatorBll.AreaAndTableVM.AddTable())
            {
                if (MessageDialogHelper.CreateInformationMessage("Lưu thành công.") == DialogResult.OK)
                    this.Close();
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
