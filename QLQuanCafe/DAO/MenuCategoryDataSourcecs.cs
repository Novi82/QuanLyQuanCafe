using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQuanCafe.DTO;
using System.Data;

namespace QLQuanCafe.DAO
{
    public class MenuCategoryDataSourcecs : DataSourceBase
    {
        public List<MenuCategoryData> GetAllMenuCategoryToChoose()
        {
            List<MenuCategoryData> listMenuCategory = new List<MenuCategoryData>();

            MenuCategoryData all = new MenuCategoryData();
            all.MenuCategoryName = "Tất cả";
            listMenuCategory.Add(all);

            DataTable dt = provider.ExecuteReader("LOAIMON_proc_load");

            foreach (DataRow row in dt.Rows)
            {
                MenuCategoryData menuCategory = new MenuCategoryData();
                menuCategory.MenuCategoryId = row["MaLoaiMon"].ToString();
                menuCategory.MenuCategoryName = row["TenLoaiMon"].ToString();

                listMenuCategory.Add(menuCategory);
            }

            return listMenuCategory;
        }

        public List<MenuCategoryData> GetAllMenuCategory()
        {
            List<MenuCategoryData> listMenuCategory = new List<MenuCategoryData>();

            DataTable dt = provider.ExecuteReader("LOAIMON_proc_load");

            foreach (DataRow row in dt.Rows)
            {
                MenuCategoryData menuCategory = new MenuCategoryData();
                menuCategory.MenuCategoryId = row["MaLoaiMon"].ToString();
                menuCategory.MenuCategoryName = row["TenLoaiMon"].ToString();

                listMenuCategory.Add(menuCategory);
            }

            return listMenuCategory;
        }

        public int AddMenuCategory(MenuCategoryData menuCategory)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maLoaiMon", menuCategory.MenuCategoryId);
            sqlStoredProcedureParams.Add("tenLoaiMon", menuCategory.MenuCategoryName);
            return provider.ExecuteNonQuery("LOAIMON_proc_insert", sqlStoredProcedureParams);
        }

        public int UpdateMenuCategory(MenuCategoryData menuCategory)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maLoaiMon", menuCategory.MenuCategoryId);
            sqlStoredProcedureParams.Add("tenLoaiMon", menuCategory.MenuCategoryName);
            return provider.ExecuteNonQuery("LOAIMON_proc_update", sqlStoredProcedureParams);
        }

        public int DeleteMenuCategory(MenuCategoryData menuCategory)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maLoaiMon", menuCategory.MenuCategoryId);
            return provider.ExecuteNonQuery("LOAIMON_proc_delete", sqlStoredProcedureParams);
        }
    }
}

