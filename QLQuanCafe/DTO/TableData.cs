using QLQuanCafe.Common;

namespace QLQuanCafe.DTO
{
    public class TableData : BindableBase
    {
        private string _tableId;
        public string TableId
        {
            get { return _tableId; }
            set { SetProperty(ref _tableId, value); }
        }

        private string _tableName;
        public string TableName
        {
            get { return _tableName; }
            set { SetProperty(ref _tableName, value); }
        }

        private AreaData _area;
        public AreaData Area
        {
            get { return _area; }
            set { SetProperty(ref _area, value); }
        }

        private string _note;
        public string Note
        {
            get { return _note; }
            set { SetProperty(ref _note, value); }
        }

        private string _tableState;
        public string TableState
        {
            get { return _tableState; }
            set { SetProperty(ref _tableState, value); }
        }
    }
}
