namespace QLQuanCafe.BLL
{
    public class LocatorBll
    {
        private static MainWindowBll _mainWindowVM;
        public static MainWindowBll MainWindowVM
        {
            get
            {
                if (_mainWindowVM == null)
                    _mainWindowVM = new MainWindowBll();

                return _mainWindowVM;
            }
        }

        private static HomePageBll _homePageVM;
        public static HomePageBll HomePageVM
        {
            get
            {
                if (_homePageVM == null)
                    _homePageVM = new HomePageBll();

                return _homePageVM;
            }
        }

        private static AreaAndTableBll _areaAndTableVM;
        public static AreaAndTableBll AreaAndTableVM
        {
            get
            {
                if (_areaAndTableVM == null)
                    _areaAndTableVM = new AreaAndTableBll();

                return _areaAndTableVM;
            }
        }

        private static MenuCategoryAndMenuItemBll _menuCategoryAndMenuItemVM;
        public static MenuCategoryAndMenuItemBll MenuCategoryAndMenuItemVM
        {
            get
            {
                if (_menuCategoryAndMenuItemVM == null)
                    _menuCategoryAndMenuItemVM = new MenuCategoryAndMenuItemBll();

                return _menuCategoryAndMenuItemVM;
            }
        }

        private static UnitBll _unitVM;
        public static UnitBll UnitVM
        {
            get
            {
                if (_unitVM == null)
                    _unitVM = new UnitBll();

                return _unitVM;
            }
        }

        private static BillBll _billVM;
        public static BillBll BillVM
        {
            get
            {
                if (_billVM == null)
                    _billVM = new BillBll();

                return _billVM;
            }
        }

        private static MaterialBll _materialVM;
        public static MaterialBll MaterialVM
        {
            get
            {
                if (_materialVM == null)
                    _materialVM = new MaterialBll();

                return _materialVM;
            }
        }

        private static LoginBll _loginVM;
        public static LoginBll LoginVM
        {
            get
            {
                if (_loginVM == null)
                    _loginVM = new LoginBll();

                return _loginVM;
            }
        }

        private static AccountBll _accountVM;
        public static AccountBll AccountVM
        {
            get
            {
                if (_accountVM == null)
                    _accountVM = new AccountBll();

                return _accountVM;
            }
        }
    }
}
