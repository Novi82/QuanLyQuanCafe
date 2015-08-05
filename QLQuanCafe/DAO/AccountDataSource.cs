using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQuanCafe.DTO;
using System.Data;

namespace QLQuanCafe.DAO
{
    public class AccountDataSource : DataSourceBase
    {
        public List<AccountData> GetAllAccount()
        {
            List<AccountData> listAccount = new List<AccountData>();
            DataTable dt = provider.ExecuteReader("TAIKHOAN_proc_load");

            foreach (DataRow row in dt.Rows)
            {
                AccountData Account = new AccountData();
                Account.UserName = row["Username"].ToString();
                Account.Permission = new PermissionData()
                {
                    PermissionName = row["TenQuyen"].ToString(),
                };

                listAccount.Add(Account);
            }

            return listAccount;
        }

        public List<PermissionData> GetAllPermission()
        {
            List<PermissionData> listPermission = new List<PermissionData>();
            DataTable dt = provider.ExecuteReader("PHANQUYEN_proc_load");

            foreach (DataRow row in dt.Rows)
            {
                PermissionData permission = new PermissionData();
                permission.PermissionId = row["MaPhanQuyen"].ToString();
                permission.PermissionName = row["TenQuyen"].ToString();

                listPermission.Add(permission);
            }

            return listPermission;
        }

        public AccountData GetAccount(AccountData account)
        {
            AccountData getAccount = new AccountData();
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("username", account.UserName);
            sqlStoredProcedureParams.Add("password", account.Password);
            DataTable dt = provider.ExecuteReader("TAIKHOAN_proc_get", sqlStoredProcedureParams);


            if (dt.Rows.Count == 1)
            {
                getAccount.UserName = dt.Rows[0]["Username"].ToString();
                getAccount.Permission = new PermissionData()
                {
                    PermissionId = dt.Rows[0]["MaPhanQuyen"].ToString(),
                    PermissionName = dt.Rows[0]["TenQuyen"].ToString(),
                };
            }

            return getAccount;
        }

        public AccountData Login(AccountData account)
        {
            AccountData getAccount = new AccountData();
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("username", account.UserName);
            sqlStoredProcedureParams.Add("password", account.Password);
            DataTable dt = provider.ExecuteReader("TAIKHOAN_proc_login", sqlStoredProcedureParams);

            if (dt.Rows.Count == 1)
            {
                getAccount.UserName = dt.Rows[0]["Username"].ToString();
                getAccount.Permission = new PermissionData()
                {
                    PermissionId = dt.Rows[0]["MaPhanQuyen"].ToString(),
                    PermissionName = dt.Rows[0]["TenQuyen"].ToString(),
                };
            }

            return getAccount;
        }

        public int Logout(AccountData account)
        {
            AccountData getAccount = new AccountData();
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("username", account.UserName);
            return provider.ExecuteNonQuery("TAIKHOAN_proc_logout", sqlStoredProcedureParams);

        }

        public int AddAccount(AccountData Account)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("username", Account.UserName);
            sqlStoredProcedureParams.Add("password", Account.Password);
            sqlStoredProcedureParams.Add("maPhanQuyen", Account.Permission.PermissionId);
            return provider.ExecuteNonQuery("TAIKHOAN_proc_insert", sqlStoredProcedureParams);
        }

        public int ChangePassword(AccountData Account)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("username", Account.UserName);
            sqlStoredProcedureParams.Add("password", Account.Password);
            return provider.ExecuteNonQuery("TAIKHOAN_proc_change_password", sqlStoredProcedureParams);
        }

        public int DeleteAccount(AccountData Account)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("username", Account.UserName);
            return provider.ExecuteNonQuery("TAIKHOAN_proc_delete", sqlStoredProcedureParams);
        }
    }
}
