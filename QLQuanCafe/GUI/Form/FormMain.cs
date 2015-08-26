using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;
using QLQuanCafe.DTO;
using QLQuanCafe.GUI.Dialog;
using QLQuanCafe.GUI;

namespace QLQuanCafe.GUI.Form
{
    public partial class FormMain : MetroForm
    {
        private AreaAndTableBll areaAndTableBll = LocatorBll.AreaAndTableBll;
        public FormMain()
        {

            InitializeComponent();
            Login login = new Login();
            login.ShowDialog();
        }

        #region Menu

        private void buttonItem20_Click(object sender, EventArgs e)
        {
            new ThucDon().ShowDialog();
        }

        private void buttonItem22_Click(object sender, EventArgs e)
        {
            new Kho().ShowDialog();
        }

        private void buttonItem23_Click(object sender, EventArgs e)
        {
            new HoaDon().ShowDialog();
        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {
            new QuanLyKhuVuc_Ban().ShowDialog();
        }

        private void buttonItem19_Click(object sender, EventArgs e)
        {
            new DonViTinh().ShowDialog();
        }

        private void buttonItem21_Click(object sender, EventArgs e)
        {
            new ThongTinNguyenLieu().ShowDialog();
        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {
            new QuanLyTaiKhoan().ShowDialog();
        }

        private void buttonItem24_Click(object sender, EventArgs e)
        {
            // TODO export to pdf file
        }

        private void buttonItem27_Click(object sender, EventArgs e)
        {
            // TODO write it later
            new QLQuanCafe.GUI.Dialog.About().ShowDialog();

        }

        private void buttonX25_Click(object sender, EventArgs e)
        {
            new XacNhanThanhToan().ShowDialog();

        }
        #endregion

        private void FormMain_Load(object sender, EventArgs e)
        {
            LocatorBll.HomePageBll.Load();
            LoadKhuVuc_Ban();
            LoadThucDon();
            LoadHoaDonTrongNgay();

        }

        private void LoadKhuVuc_Ban()
        {
            khuVuc_BanUC1.LoadKhuVuc();
        }

        private void LoadThucDon()
        {
            khuVuc_BanUC1.getBtnThanhToan().Click += thanhtoan_Click;
        }

        private void thanhtoan_Click(object sender, EventArgs e)
        {
            LoadHoaDonTrongNgay();
        }

        private void khuVuc_BanUC1_Load(object sender, EventArgs e)
        {

        }
        public void LoadHoaDonTrongNgay()
        {

            dgvHoaDonTrongNgay.DataSource = LocatorBll.HomePageBll.ListBillToday;
        }

        private void dgvHoaDonTrongNgay_RowsAdded(object sender, System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
        {
            var rows = dgvHoaDonTrongNgay.Rows;
            foreach (DataGridViewRow row in rows)
            {
                TableData tableData = (row.Cells["tableDataGridViewTextBoxColumn"]).Value as TableData;
                if (tableData != null) (row.Cells["KhuVuc"]).Value = tableData.Area;
            }
        }

        private void buttonItem25_Click(object sender, EventArgs e)
        {
            BaoCao_ThongKe BCTK = new BaoCao_ThongKe();
            BCTK.ShowDialog();
        }

        private void buttonItem26_Click(object sender, EventArgs e)
        {
            Nhap n = new Nhap();
            n.ShowDialog();
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            if (LocatorBll.LoginBll.Logout())
            {
                Application.Restart();
            }
        }

        private void dgvHoaDonTrongNgay_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           
        }
    }
}
