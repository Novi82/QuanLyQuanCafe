using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.GUI.Form;

namespace QLQuanCafe.GUI
{
    public partial class FormMain : MetroForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

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
    }
}
