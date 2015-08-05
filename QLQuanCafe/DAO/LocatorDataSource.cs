namespace QLQuanCafe.DAO
{
    public class LocatorDataSource
    {
        private static TableDataSource _tableDS;
        public static TableDataSource TableDS
        {
            get
            {
                if (_tableDS == null)
                    _tableDS = new TableDataSource();
                return _tableDS;
            }
        }

        private static MenuCategoryDataSourcecs _menuCategoryDS;
        public static MenuCategoryDataSourcecs MenuCategoryDS
        {
            get
            {
                if (_menuCategoryDS == null)
                    _menuCategoryDS = new MenuCategoryDataSourcecs();
                return _menuCategoryDS;
            }
        }

        private static MenuItemDataSource _menuItemDS;
        public static MenuItemDataSource MenuItemDS
        {
            get
            {
                if (_menuItemDS == null)
                    _menuItemDS = new MenuItemDataSource();
                return _menuItemDS;
            }
        }

        private static BillDataSource _billDS;
        public static BillDataSource BillDS
        {
            get
            {
                if (_billDS == null)
                    _billDS = new BillDataSource();
                return _billDS;
            }
        }

        private static BillDetailDataSource _billDetailDS;
        public static BillDetailDataSource BillDetailDS
        {
            get
            {
                if (_billDetailDS == null)
                    _billDetailDS = new BillDetailDataSource();
                return _billDetailDS;
            }
        }

        private static AreaDataSource _areaDS;
        public static AreaDataSource AreaDS
        {
            get
            {
                if (_areaDS == null)
                    _areaDS = new AreaDataSource();
                return _areaDS;
            }
        }

        private static UnitDataSource _unitDS;
        public static UnitDataSource UnitDS
        {
            get
            {
                if (_unitDS == null)
                    _unitDS = new UnitDataSource();
                return _unitDS;
            }
        }

        private static MaterialDataSource _materialDS;
        public static MaterialDataSource MaterialDS
        {
            get
            {
                if (_materialDS == null)
                    _materialDS = new MaterialDataSource();
                return _materialDS;
            }
        }

        private static AccountDataSource _accountDS;
        public static AccountDataSource AccountDS
        {
            get
            {
                if (_accountDS == null)
                    _accountDS = new AccountDataSource();
                return _accountDS;
            }
        }
        private static ReportDataSource _reportDS;

        public static ReportDataSource ReportDS
        {
            get
            {
                if (_reportDS == null)
                    _reportDS = new ReportDataSource();
                return _reportDS;
            }
        }

    }
}
