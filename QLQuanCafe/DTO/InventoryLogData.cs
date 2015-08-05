using System;
using QLQuanCafe.Common;

namespace QLQuanCafe.DTO
{
    public class InventoryLogData : BindableBase
    {
        private MaterialData _material;
        public MaterialData Material
        {
            get { return _material; }
            set { SetProperty(ref _material, value); }
        }

        private DateTime _time;
        public DateTime Time
        {
            get { return _time; }
            set { SetProperty(ref _time, value); }
        }

        private int _quantityBeforeChange;
        public int QuantityBeforeChange
        {
            get { return _quantityBeforeChange; }
            set { SetProperty(ref _quantityBeforeChange, value); }
        }

        private int _quantityChange;
        public int QuantityChange
        {
            get { return _quantityChange; }
            set { SetProperty(ref _quantityChange, value); }
        }

        private int _quantityAfterChange;
        public int QuantityAfterChange
        {
            get { return _quantityAfterChange; }
            set { SetProperty(ref _quantityAfterChange, value); }
        }
    }
}
