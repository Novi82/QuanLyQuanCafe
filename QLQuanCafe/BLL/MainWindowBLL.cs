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
        AccountPage
    }

    public class MainWindowBll : BllBase
    {
        private MyPage _currentPage;
        public MyPage CurrentPage
        {
            get { return _currentPage; }
            set { SetProperty(ref _currentPage, value); }
        }

        public MainWindowBll()
        {
            Load();
        }


        public override void Load()
        {
            CurrentPage = MyPage.HomePage;
        }
    }
}
