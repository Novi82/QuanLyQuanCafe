using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.GUI.Form;
using QLQuanCafe.BLL;
using QLQuanCafe.DTO;
using QLQuanCafe.GUI.UserControl;

namespace QLQuanCafe.GUI
{
    public partial class FormMain : MetroForm
    {
        private AreaAndTableBll areaAndTableBll = LocatorBll.AreaAndTableVM;
        public FormMain()
        {
            InitializeComponent();

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
            LoadKhuVuc_Ban();
            LoadThucDon();
            hoaDonUC1.LoadHoaDonTrongNgay();
        }

        private void LoadKhuVuc_Ban()
        {
            khuVuc_BanUC1.LoadKhuVuc();
        }

        private void LoadThucDon()
        {
      
        }

        private void khuVuc_BanUC1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
