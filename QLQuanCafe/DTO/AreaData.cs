using QLQuanCafe.Common;

namespace QLQuanCafe.DTO
{
     public class AreaData : BindableBase
    {
        private string _areaId;
        public string AreaId
        {
            get { return _areaId; }
            set { SetProperty(ref _areaId, value); }
        }

        private string _areaName;
        public string AreaName
        {
            get { return _areaName; }
            set { SetProperty(ref _areaName, value); }
        }

        private string _note;
        public string Note
        {
            get { return _note; }
            set { SetProperty(ref _note, value); }
        }
    }
}


