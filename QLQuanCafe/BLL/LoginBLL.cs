using MySql.Data.MySqlClient;
using QLQuanCafe.Common;
using QLQuanCafe.DAO;
using QLQuanCafe.DTO;

namespace QLQuanCafe.BLL
{
    public class LoginBll : BllBase
    {

        #region Properties

        private AccountData _account;

        public AccountData Account
        {
            get { return _account; }
            set { SetProperty(ref _account, value); }
        }

        private bool _isLogin;
        public bool IsLogin
        {
            get { return _isLogin; }
            set { SetProperty(ref _isLogin, value); }
        }

        private bool _isManageAccount;
        public bool IsManageAccount
        {
            get { return _isManageAccount; }
            set { SetProperty(ref _isManageAccount, value); }
        }


        private bool _isMenu;
        public bool IsMenu
        {
            get { return _isMenu; }
            set { SetProperty(ref _isMenu, value); }
        }

        private bool _isHomePage;
        public bool IsHomePage
        {
            get { return _isHomePage; }
            set { SetProperty(ref _isHomePage, value); }
        }

        #endregion

        #region Commands



        #endregion

        #region Actions



        #endregion

        public LoginBll()
        {
            Load();
        }


        #region Methods

        public override void Load()
        {
            IsLogin = false;
            Account = new AccountData();
        }

        private void SetPermission()
        {
            switch (Account.Permission.PermissionName)
            {
                case "Admin":
                    IsManageAccount = true;
                    IsMenu = true;
                    IsHomePage = true;
                    break;
                case "Quản lý":
                    IsManageAccount = false;
                    IsMenu = true;
                    IsHomePage = false;
                    break;
                case "Thu ngân":
                    IsManageAccount = false;
                    IsMenu = false;
                    IsHomePage = true;
                    break;
            }
        }

        public bool Login(string user,string password)
        {
            try
            {
                Account.UserName = user;
                Account.Password = password;
                Account = LocatorDataSource.AccountDS.Login(Account);

                IsLogin = true;
                SetPermission();

                return true;
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);
                return false;
            }
        }

        public bool Logout()
        {
            try
            {
                LocatorDataSource.AccountDS.Logout(Account);

                IsLogin = false;
                return true;
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);
                return false;
            }
        }

        public bool ChangePassword(string password)
        {
            try
            {
                Account.Password = password;
                LocatorDataSource.AccountDS.ChangePassword(Account);

                return true;
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);
                return false;
            }
        }

        #endregion
    }
}
