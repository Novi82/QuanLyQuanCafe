using System;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;
using QLQuanCafe.DAO;
using QLQuanCafe.DTO;

namespace QLQuanCafe.GUI.Dialog
{
    public partial class XacNhanThanhToan : MetroForm
    {
        private BillData bill =null;
        //private string tongtien = String.Empty;
        public XacNhanThanhToan()
        {
            InitializeComponent();
        }

        public XacNhanThanhToan(BillData bill) : this()
        {
            LocatorBll.BillBll.Load();
            this.bill = LocatorBll.BillBll.ListBill.Find(x=>x.BillId.Contains(bill.BillId));
        }

        public decimal TongTien { get; set; }
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
            txtKhuVuc.Text = LocatorBll.HomePageBll.TableSelected.Area.AreaName;
            txtBan.Text = LocatorBll.HomePageBll.TableSelected.TableName;
            txtTongTien.Text = bill.TotalMoney.ToString("#,###") + " VND";
        }
    }
}
