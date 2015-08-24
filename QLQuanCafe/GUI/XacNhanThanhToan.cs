using System;
using System.Globalization;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;
using QLQuanCafe.DTO;

namespace QLQuanCafe.GUI
{
    public partial class XacNhanThanhToan : MetroForm
    {
        private BillData bill =null;
        public XacNhanThanhToan()
        {
            InitializeComponent();
        }

        public XacNhanThanhToan(BillData bill) : this()
        {
            this.bill = bill;
        }

        private void XacNhanThanhToan_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadHoaDon()
        {
            //bill = LocatorBll.HomePageVM.BillOfTableSelected;
            txtKhuVuc.Text = LocatorBll.HomePageVM.TableSelected.Area.AreaName;
            txtBan.Text = LocatorBll.HomePageVM.TableSelected.TableName;
            txtTongTien.Text = bill.TotalMoney.ToString();
        }
    }
}
