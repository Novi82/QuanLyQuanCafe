using System;
using System.Collections;
using System.Collections.Generic;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.GUI.Form;

namespace QLQuanCafe.GUI
{
    public partial class BaoCao_ThongKe : MetroForm
    {
        public BaoCao_ThongKe()
        {
            InitializeComponent();
        }

        private void BaoCao_ThongKe_Load(object sender, EventArgs e)
        {
            LoadThang();
            LoadNam();
            rbtnThang.Checked = true;
            //rbtnThaeng.Checked = false;
            //cbxNam.item
        }

        private void LoadThang()
        {
            int[] thangs = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
         
            cbxThang.DataSource = thangs;
            cbxThang.SelectedIndex = DateTime.Today.Month-1;
        }

        private void LoadNam()
        {
            ArrayList nams = new ArrayList();
            for (int i = 1900; i <= DateTime.Today.Year; ++i)
            {
                nams.Add(i);
            }
            nams.Reverse();
            cbxNam.DataSource = nams;
            cbxNam.SelectedIndex = 0;
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void cbxNam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnThang_CheckedChanged(object sender, EventArgs e)
        {
            cbxNam.Enabled = rbtnNam.Checked;
        }

        private void rbtnNam_CheckedChanged(object sender, EventArgs e)
        {
            cbxNam.Enabled = rbtnNam.Checked;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DoanhThuThang frmDoanhThuThang = new DoanhThuThang();
            frmDoanhThuThang.ShowDialog();
        }
    }
}
