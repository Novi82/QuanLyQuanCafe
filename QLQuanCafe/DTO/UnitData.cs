using QLQuanCafe.Common;

namespace QLQuanCafe.DTO
{
    public class UnitData : BindableBase
    {
        private string _unitId;
        public string UnitId
        {
            get { return _unitId; }
            set { SetProperty(ref _unitId, value); }
        }

        private string _unitName;
        public string UnitName
        {
            get { return _unitName; }
            set { SetProperty(ref _unitName, value); }
        }
    }
}
