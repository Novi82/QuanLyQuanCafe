using QLQuanCafe.Common;

namespace QLQuanCafe.DTO
{
    public class MenuCategoryData : BindableBase
    {
        private string _menuCategoryId;
        public string MenuCategoryId
        {
            get { return _menuCategoryId; }
            set { SetProperty(ref _menuCategoryId, value); }
        }

        private string _menuCategoryName;
        public string MenuCategoryName
        {
            get { return _menuCategoryName; }
            set { SetProperty(ref _menuCategoryName, value); }
        }

        public override string ToString()
        {
            return MenuCategoryName;
        }
    }
}
