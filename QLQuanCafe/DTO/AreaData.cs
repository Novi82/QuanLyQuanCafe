using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQuanCafe.Common;

namespace QLQuanCafe.DTO
{
     public class AreaData : BindableBase
    {
        private string _areaId;
        public string AreaId
        {
            get { return _areaId; }
            set { SetProperty<string>(ref _areaId, value); }
        }

        private string _areaName;
        public string AreaName
        {
            get { return _areaName; }
            set { SetProperty<string>(ref _areaName, value); }
        }

        private string _note;
        public string Note
        {
            get { return _note; }
            set { SetProperty<string>(ref _note, value); }
        }
    }
}


