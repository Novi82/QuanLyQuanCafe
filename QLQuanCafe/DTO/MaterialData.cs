using System;
using QLQuanCafe.Common;

namespace QLQuanCafe.DTO
{
    public class MaterialData : BindableBase
    {
        private string _materialId;
        public string MaterialId
        {
            get { return _materialId; }
            set { SetProperty(ref _materialId, value); }
        }

        private string _materialName;
        public string MaterialName
        {
            get { return _materialName; }
            set { SetProperty(ref _materialName, value); }
        }

        private UnitData _unit;
        public UnitData Unit
        {
            get { return _unit; }
            set { SetProperty(ref _unit, value); }
        }

        private Decimal _price;
        public Decimal Price
        {
            get { return _price; }
            set { SetProperty(ref _price, value); }
        }

        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set { SetProperty(ref _quantity, value); }
        }

        public MaterialData()
        {
            Price = 1000;
        }
    }
}
