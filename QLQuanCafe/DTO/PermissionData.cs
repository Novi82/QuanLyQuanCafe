using QLQuanCafe.Common;

namespace QLQuanCafe.DTO
{
    public class PermissionData : BindableBase
    {
        private string _permissionId;
        public string PermissionId
        {
            get { return _permissionId; }
            set { SetProperty(ref _permissionId, value); }
        }

        private string _permissionName;
        public string PermissionName
        {
            get { return _permissionName; }
            set { SetProperty(ref _permissionName, value); }
        }
    }
}
