using System;
using QLQuanCafe.Common;

namespace QLQuanCafe.DTO
{
    public class MenuItemData : BindableBase
    {
        private string _menuItemId;
        public string MenuItemId
        {
            get { return _menuItemId; }
            set { SetProperty(ref _menuItemId, value); }
        }

        private string _menuItemName;
        public string MenuItemName
        {
            get { return _menuItemName; }
            set { SetProperty(ref _menuItemName, value); }
        }

        private string _imagePath;
        public string ImagePath
        {
            get { return _imagePath; }
            set { SetProperty(ref _imagePath, value); }
        }

        private Decimal _price;
        public Decimal Price
        {
            get { return _price; }
            set { SetProperty(ref _price, value); }
        }

        private UnitData _unit;
        public UnitData Unit
        {
            get { return _unit; }
            set { SetProperty(ref _unit, value); }
        }

        private MenuCategoryData _menuCategory;
        public MenuCategoryData MenuCategory
        {
            get { return _menuCategory; }
            set { SetProperty(ref _menuCategory, value); }
        }

        public MenuItemData()
        {
            Price = 1000;
        }

        public override string ToString()
        {
            return MenuItemName;
        }
    }
}
