using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using QLQuanCafe.BLL;
using QLQuanCafe.DTO;

namespace QLQuanCafe.GUI.UserControl
{
   
    public partial class ThucDonUC : System.Windows.Forms.UserControl
    {
   
        private HomePageBll homePageBll = LocatorBll.HomePageBll;

        private MenuCategoryAndMenuItemBll menuCategoryAndMenuItemBll = LocatorBll.MenuCategoryAndMenuItemBll;

        public ThucDonUC()
        {
            InitializeComponent();
        }

        private void ThucDonUC_Load(object sender, EventArgs e)
        {
        }

        public void LoadLoaiMonAn()
        {
                if (menuCategoryAndMenuItemBll.ListMenuCategory != null)
                {
                    cbxLoaiMonAn.DataSource = menuCategoryAndMenuItemBll.ListMenuCategory;
                }
        }

        private void LoadMonAn()
        {
            var menuItemDatas = menuCategoryAndMenuItemBll.ListMenuItem;
            if (menuItemDatas != null)
            {
                dgvThucDon.DataSource = menuItemDatas;
            }
        }

        private void cbxLoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            menuCategoryAndMenuItemBll.SelectMenuCategoryCommand.Execute(cbxLoaiMonAn.SelectedItem);
            LoadMonAn();
        }

        private void dgvThucDon_SelectionChanged(object sender, EventArgs e)
        {
            if (homePageBll != null)
            {
                DataGridViewX dgv = sender as DataGridViewX;
                if (dgv.SelectedRows.Count > 0)
                {
                    if (homePageBll.SelectMenuItemCommand.CanExecute(null))
                    {
//                        homePageBll.SelectMenuItemCommand.Execute(dgv.SelectedRows[0].DataBoundItem);

                        dgv.ClearSelection();
                    }
                }
            }
        }
    }
}
