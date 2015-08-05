using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQuanCafe.Common;

namespace QLQuanCafe.DTO
{
    public class MenuCategoryData : BindableBase
    {
        private string _menuCategoryId;
        public string MenuCategoryId
        {
            get { return _menuCategoryId; }
            set { SetProperty<string>(ref _menuCategoryId, value); }
        }

        private string _menuCategoryName;
        public string MenuCategoryName
        {
            get { return _menuCategoryName; }
            set { SetProperty<string>(ref _menuCategoryName, value); }
        }
    }
}
