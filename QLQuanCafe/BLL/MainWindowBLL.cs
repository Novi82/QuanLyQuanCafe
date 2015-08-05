using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCafe.BLL
{
    public enum MyPage
    {
        HomePage,
        AreaAndTablePage,
        MenuCategoryAndMenuItemPage,
        UnitPage,
        BillPage,
        MaterialPage,
        InventoryPage,
        AccountPage,
    }

    public class MainWindowBLL : BllBase
    {
        private MyPage _currentPage;
        public MyPage CurrentPage
        {
            get { return _currentPage; }
            set { SetProperty<MyPage>(ref _currentPage, value); }
        }

        public MainWindowBLL()
        {
            Load();
        }


        public override void Load()
        {
            CurrentPage = MyPage.HomePage;
        }
    }
}
