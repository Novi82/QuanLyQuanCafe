using System;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;
using QLQuanCafe.DTO;

namespace QLQuanCafe.GUI.Dialog
{
    public partial class YeuCauMon : MetroForm
    {
        private BillDetailData itemBillDetailData = LocatorBll.HomePageVM.BillDetaiSelected;
        private HomePageBll HomePageBll = LocatorBll.HomePageVM;
        public YeuCauMon()
        {
            InitializeComponent();
            dipSoLuong.Value = 1;
        }

        private void YeuCauMon_Load(object sender, EventArgs e)
        {
            LoadThongTinMonAn();
        }

        private void LoadThongTinMonAn()
        {
            txtTenMon.Text = itemBillDetailData.MenuItem.MenuItemName;
            txtDonGia.Text = itemBillDetailData.MenuItem.Price.ToString();
        }

        private void dipSoLuong_ValueChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = ((decimal)dipSoLuong.Value * itemBillDetailData.MenuItem.Price).ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            HomePageBll.BillDetaiSelected.Quantity = Convert.ToInt32(dipSoLuong.Value);
            HomePageBll.BillDetaiSelected.Note = txtGhiChu.Text;
            if (HomePageBll.AcceptRequireMenuItemCommand.CanExecute(null))
            {
                HomePageBll.AcceptRequireMenuItemCommand.Execute(null);
                this.Close();
            }

        }
    }
}
