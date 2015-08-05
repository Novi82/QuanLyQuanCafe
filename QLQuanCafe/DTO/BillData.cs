using System;
using QLQuanCafe.Common;

namespace QLQuanCafe.DTO
{
    public class BillData : BindableBase
    {
        private string _billId;
        public string BillId
        {
            get { return _billId; }
            set { SetProperty(ref _billId, value); }
        }

        private TableData _table;
        public TableData Table
        {
            get { return _table; }
            set { SetProperty(ref _table, value); }
        }

        private TableData _tableLiquidate;
        public TableData TableLiquidate
        {
            get { return _tableLiquidate; }
            set { SetProperty(ref _tableLiquidate, value); }
        }

        private Decimal _totalMoney;
        public Decimal TotalMoney
        {
            get { return _totalMoney; }
            set { SetProperty(ref _totalMoney, value); }
        }

        private DateTime? _time;
        public DateTime? Time
        {
            get { return _time; }
            set { SetProperty(ref _time, value); }
        }

        private bool _isPaid;
        public bool IsPaid
        {
            get { return _isPaid; }
            set { SetProperty(ref _isPaid, value); }
        }
    }
}
