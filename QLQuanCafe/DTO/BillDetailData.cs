using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQuanCafe.Common;

namespace QLQuanCafe.DTO
{
    public class BillDetailData : ValidateDataSchemaBase
    {
        private string _billDetaiId;
        public string BillDetaiId
        {
            get { return _billDetaiId; }
            set { SetProperty<string>(ref _billDetaiId, value); }
        }

        private string _billId;
        public string BillId
        {
            get { return _billId; }
            set { SetProperty<string>(ref _billId, value); }
        }

        private MenuItemData _menuItem;
        public MenuItemData MenuItem
        {
            get { return _menuItem; }
            set
            {
                if (SetProperty<MenuItemData>(ref _menuItem, value))
                {
                    TotalMoney = MenuItem.Price * Quantity;
                }
            }
        }

        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (SetProperty<int>(ref _quantity, value))
                {
                    TotalMoney = MenuItem.Price * Quantity;
                }
            }
        }

        private Decimal _totalMoney;
        public Decimal TotalMoney
        {
            get { return _totalMoney; }
            set { SetProperty<Decimal>(ref _totalMoney, value); }
        }

        private string _note;
        public string Note
        {
            get { return _note; }
            set { SetProperty<string>(ref _note, value); }
        }

        private bool _isPrepare;
        public bool IsPrepare
        {
            get { return _isPrepare; }
            set { SetProperty<bool>(ref _isPrepare, value); }
        }

        public BillDetailData()
        {
            MenuItem = new MenuItemData();
            Quantity = 1;
        }
    }
}
