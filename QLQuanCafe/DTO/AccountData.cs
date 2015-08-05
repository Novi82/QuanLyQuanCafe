using QLQuanCafe.Common;

namespace QLQuanCafe.DTO
{
    public class AccountData : BindableBase
    {
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        private PermissionData _permission;
        public PermissionData Permission
        {
            get { return _permission; }
            set { SetProperty(ref _permission, value); }
        }
    }
}
