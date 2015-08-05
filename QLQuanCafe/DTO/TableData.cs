using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQuanCafe.Common;

namespace QLQuanCafe.DTO
{
    public class TableData : BindableBase
    {
        private string _tableId;
        public string TableId
        {
            get { return _tableId; }
            set { SetProperty<string>(ref _tableId, value); }
        }

        private string _tableName;
        public string TableName
        {
            get { return _tableName; }
            set { SetProperty<string>(ref _tableName, value); }
        }

        private AreaData _area;
        public AreaData Area
        {
            get { return _area; }
            set { SetProperty<AreaData>(ref _area, value); }
        }

        private string _note;
        public string Note
        {
            get { return _note; }
            set { SetProperty<string>(ref _note, value); }
        }

        private string _tableState;
        public string TableState
        {
            get { return _tableState; }
            set { SetProperty<string>(ref _tableState, value); }
        }
    }
}
