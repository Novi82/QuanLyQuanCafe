using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQuanCafe.Common;
namespace QLQuanCafe.DTO
{
    public class MaterialData : BindableBase
    {
        private string _materialId;
        public string MaterialId
        {
            get { return _materialId; }
            set { SetProperty<string>(ref _materialId, value); }
        }

        private string _materialName;
        public string MaterialName
        {
            get { return _materialName; }
            set { SetProperty<string>(ref _materialName, value); }
        }

        private UnitData _unit;
        public UnitData Unit
        {
            get { return _unit; }
            set { SetProperty<UnitData>(ref _unit, value); }
        }

        private Decimal _price;
        public Decimal Price
        {
            get { return _price; }
            set { SetProperty<Decimal>(ref _price, value); }
        }

        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set { SetProperty<int>(ref _quantity, value); }
        }

        public MaterialData()
        {
            Price = 1000;
        }
    }
}
