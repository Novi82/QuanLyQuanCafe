using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQuanCafe.Common;

namespace QLQuanCafe.DTO
{
    public class AccountData : BindableBase
    {
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set { SetProperty<string>(ref _userName, value); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty<string>(ref _password, value); }
        }

        private PermissionData _permission;
        public PermissionData Permission
        {
            get { return _permission; }
            set { SetProperty<PermissionData>(ref _permission, value); }
        }
    }
}
