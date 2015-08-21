using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLQuanCafe.BLL;
using QLQuanCafe.DTO;

namespace QLQuanCafe.GUI.UserControl
{
    public partial class ThucDonUC : System.Windows.Forms.UserControl
    {
        private HomePageBll homePageBll = LocatorBll.HomePageVM;

        private MenuCategoryAndMenuItemBll menuCategoryAndMenuItemBll = LocatorBll.MenuCategoryAndMenuItemVM;

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
    }
}
