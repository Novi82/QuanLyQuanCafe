using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQuanCafe.Common;
namespace QLQuanCafe.DTO
{
    public class MenuItemData : BindableBase
    {
        private string _menuItemId;
        public string MenuItemId
        {
            get { return _menuItemId; }
            set { SetProperty<string>(ref _menuItemId, value); }
        }

        private string _menuItemName;
        public string MenuItemName
        {
            get { return _menuItemName; }
            set { SetProperty<string>(ref _menuItemName, value); }
        }

        private string _imagePath;
        public string ImagePath
        {
            get { return _imagePath; }
            set { SetProperty<string>(ref _imagePath, value); }
        }

        private Decimal _price;
        public Decimal Price
        {
            get { return _price; }
            set { SetProperty<Decimal>(ref _price, value); }
        }

        private UnitData _unit;
        public UnitData Unit
        {
            get { return _unit; }
            set { SetProperty<UnitData>(ref _unit, value); }
        }

        private MenuCategoryData _menuCategory;
        public MenuCategoryData MenuCategory
        {
            get { return _menuCategory; }
            set { SetProperty<MenuCategoryData>(ref _menuCategory, value); }
        }

        public MenuItemData()
        {
            Price = 1000;
        }
    }
}
