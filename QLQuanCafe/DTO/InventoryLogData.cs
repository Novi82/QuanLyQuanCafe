using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQuanCafe.Common;

namespace QLQuanCafe.DTO
{
    public class InventoryLogData : BindableBase
    {
        private MaterialData _material;
        public MaterialData Material
        {
            get { return _material; }
            set { SetProperty<MaterialData>(ref _material, value); }
        }

        private DateTime _time;
        public DateTime Time
        {
            get { return _time; }
            set { SetProperty<DateTime>(ref _time, value); }
        }

        private int _quantityBeforeChange;
        public int QuantityBeforeChange
        {
            get { return _quantityBeforeChange; }
            set { SetProperty<int>(ref _quantityBeforeChange, value); }
        }

        private int _quantityChange;
        public int QuantityChange
        {
            get { return _quantityChange; }
            set { SetProperty<int>(ref _quantityChange, value); }
        }

        private int _quantityAfterChange;
        public int QuantityAfterChange
        {
            get { return _quantityAfterChange; }
            set { SetProperty<int>(ref _quantityAfterChange, value); }
        }
    }
}
