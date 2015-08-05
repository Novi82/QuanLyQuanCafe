using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQuanCafe.Common;


namespace QLQuanCafe.DTO
{
    public class PermissionData : BindableBase
    {
        private string _permissionId;
        public string PermissionId
        {
            get { return _permissionId; }
            set { SetProperty<string>(ref _permissionId, value); }
        }

        private string _permissionName;
        public string PermissionName
        {
            get { return _permissionName; }
            set { SetProperty<string>(ref _permissionName, value); }
        }
    }
}
