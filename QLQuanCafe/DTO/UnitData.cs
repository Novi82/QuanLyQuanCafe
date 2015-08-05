using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQuanCafe.Common;

namespace QLQuanCafe.DTO
{
    public class UnitData : BindableBase
    {
        private string _unitId;
        public string UnitId
        {
            get { return _unitId; }
            set { SetProperty<string>(ref _unitId, value); }
        }

        private string _unitName;
        public string UnitName
        {
            get { return _unitName; }
            set { SetProperty<string>(ref _unitName, value); }
        }
    }
}
