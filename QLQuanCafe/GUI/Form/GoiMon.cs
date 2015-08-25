using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;
using QLQuanCafe.DTO;

namespace QLQuanCafe.GUI.Form
{
    public partial class GoiMon : MetroForm
    {
        private HomePageBll homePageBll = LocatorBll.HomePageVM;
        public GoiMon()
        {
            InitializeComponent();
        }

        private void YeuCauMon_Load(object sender, EventArgs e)
        {
            LoadLoaiMonAn();
        }

        private void LoadLoaiMonAn()
        {
            homePageBll.Load();
            cbxLoaiMonAn.DataSource = homePageBll.ListMenuCategory;
        }

        private void LoadMonAn()
        {
            dgvMonAn.DataSource = homePageBll.ListMenuItem;
            dgvMonAn.ClearSelection();
        }

        private void cbxLoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEx cbx = sender as ComboBoxEx;
            if (cbx != null)
            {
                homePageBll.MenuCategorySelected = cbx.SelectedItem as MenuCategoryData;
            }
            LoadMonAn();
        }

        private void btnTimMonAn_Click(object sender, EventArgs e)
        {
            if (txtTimMonAn.Text != null)
            {
                homePageBll.SearchTextMenuItem = txtTimMonAn.Text;
            }
            if (homePageBll.SearchMenuItemCommand.CanExecute(null))
            {
                homePageBll.SearchMenuItemCommand.Execute(null);
            }
            LoadMonAn();
        }



        private void dgvMonAn_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void dgvMonAn_CellContentClick_1(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
        }

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvMonAn.SelectedRows.Count > 0)
                {
                    if (homePageBll != null)
                    {
                        if (homePageBll.SelectMenuItemCommand.CanExecute(null))
                        {

                            homePageBll.SelectMenuItemCommand.Execute(dgvMonAn.SelectedRows[0].DataBoundItem);

                            dgvMonAn.ClearSelection();
                        }
                    }
                }
            }
        }
    }
}
