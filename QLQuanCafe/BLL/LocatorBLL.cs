namespace QLQuanCafe.BLL
{
    public class LocatorBll
    {
        private static MainWindowBll _mainWindowBll;
        public static MainWindowBll MainWindowBll
        {
            get
            {
                if (_mainWindowBll == null)
                    _mainWindowBll = new MainWindowBll();

                return _mainWindowBll;
            }
        }

        private static HomePageBll _homePageBll;
        public static HomePageBll HomePageBll
        {
            get
            {
                if (_homePageBll == null)
                    _homePageBll = new HomePageBll();

                return _homePageBll;
            }
        }

        private static AreaAndTableBll _areaAndTableBll;
        public static AreaAndTableBll AreaAndTableBll
        {
            get
            {
                if (_areaAndTableBll == null)
                    _areaAndTableBll = new AreaAndTableBll();

                return _areaAndTableBll;
            }
        }

        private static MenuCategoryAndMenuItemBll _menuCategoryAndMenuItemBll;
        public static MenuCategoryAndMenuItemBll MenuCategoryAndMenuItemBll
        {
            get
            {
                if (_menuCategoryAndMenuItemBll == null)
                    _menuCategoryAndMenuItemBll = new MenuCategoryAndMenuItemBll();

                return _menuCategoryAndMenuItemBll;
            }
        }

        private static UnitBll _unitBll;
        public static UnitBll UnitBll
        {
            get
            {
                if (_unitBll == null)
                    _unitBll = new UnitBll();

                return _unitBll;
            }
        }

        private static BillBll _billBll;
        public static BillBll BillBll
        {
            get
            {
                if (_billBll == null)
                    _billBll = new BillBll();

                return _billBll;
            }
        }

        private static MaterialBll _materiaBll;
        public static MaterialBll MateriaBll
        {
            get
            {
                if (_materiaBll == null)
                    _materiaBll = new MaterialBll();

                return _materiaBll;
            }
        }

        private static LoginBll _loginBll;
        public static LoginBll LoginBll
        {
            get
            {
                if (_loginBll == null)
                    _loginBll = new LoginBll();

                return _loginBll;
            }
        }

        private static AccountBll _accountBll;
        public static AccountBll AccountBll
        {
            get
            {
                if (_accountBll == null)
                    _accountBll = new AccountBll();

                return _accountBll;
            }
        }
    }
}
