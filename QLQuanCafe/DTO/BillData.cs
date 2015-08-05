using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQuanCafe.Common;

namespace QLQuanCafe.DTO
{
    public class BillData : BindableBase
    {
        private string _billId;
        public string BillId
        {
            get { return _billId; }
            set { SetProperty<string>(ref _billId, value); }
        }

        private TableData _table;
        public TableData Table
        {
            get { return _table; }
            set { SetProperty<TableData>(ref _table, value); }
        }

        private TableData _tableLiquidate;
        public TableData TableLiquidate
        {
            get { return _tableLiquidate; }
            set { SetProperty<TableData>(ref _tableLiquidate, value); }
        }

        private Decimal _totalMoney;
        public Decimal TotalMoney
        {
            get { return _totalMoney; }
            set { SetProperty<Decimal>(ref _totalMoney, value); }
        }

        private Nullable<DateTime> _time;
        public Nullable<DateTime> Time
        {
            get { return _time; }
            set { SetProperty<Nullable<DateTime>>(ref _time, value); }
        }

        private bool _isPaid;
        public bool IsPaid
        {
            get { return _isPaid; }
            set { SetProperty<bool>(ref _isPaid, value); }
        }
    }
}
