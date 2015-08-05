using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCafe.BLL
{
    public class LocatorViewModel
    {
        private static MainWindowBLL _mainWindowVM;
        public static MainWindowBLL MainWindowVM
        {
            get
            {
                if (_mainWindowVM == null)
                    _mainWindowVM = new MainWindowBLL();

                return _mainWindowVM;
            }
        }

        private static HomePageViewModel _homePageVM;
        public static HomePageViewModel HomePageVM
        {
            get
            {
                if (_homePageVM == null)
                    _homePageVM = new HomePageViewModel();

                return _homePageVM;
            }
        }

        private static AreaAndTableBLL _areaAndTableVM;
        public static AreaAndTableBLL AreaAndTableVM
        {
            get
            {
                if (_areaAndTableVM == null)
                    _areaAndTableVM = new AreaAndTableBLL();

                return _areaAndTableVM;
            }
        }

        private static MenuCategoryAndMenuItemBLL _menuCategoryAndMenuItemVM;
        public static MenuCategoryAndMenuItemBLL MenuCategoryAndMenuItemVM
        {
            get
            {
                if (_menuCategoryAndMenuItemVM == null)
                    _menuCategoryAndMenuItemVM = new MenuCategoryAndMenuItemBLL();

                return _menuCategoryAndMenuItemVM;
            }
        }

        private static UnitBLL _unitVM;
        public static UnitBLL UnitVM
        {
            get
            {
                if (_unitVM == null)
                    _unitVM = new UnitBLL();

                return _unitVM;
            }
        }

        private static BillBLL _billVM;
        public static BillBLL BillVM
        {
            get
            {
                if (_billVM == null)
                    _billVM = new BillBLL();

                return _billVM;
            }
        }

        private static MaterialBLL _materialVM;
        public static MaterialBLL MaterialVM
        {
            get
            {
                if (_materialVM == null)
                    _materialVM = new MaterialBLL();

                return _materialVM;
            }
        }

        private static LoginBLL _loginVM;
        public static LoginBLL LoginVM
        {
            get
            {
                if (_loginVM == null)
                    _loginVM = new LoginBLL();

                return _loginVM;
            }
        }

        private static AccountViewModel _accountVM;
        public static AccountViewModel AccountVM
        {
            get
            {
                if (_accountVM == null)
                    _accountVM = new AccountViewModel();

                return _accountVM;
            }
        }
    }
}
