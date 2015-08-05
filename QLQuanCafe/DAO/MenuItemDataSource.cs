using System;
using System.Collections.Generic;
using System.Data;
using QLQuanCafe.DTO;

namespace QLQuanCafe.DAO
{
    public class MenuItemDataSource : DataSourceBase
    {
        public List<MenuItemData> FindMenuItems(string searchName, string menuCategoryId)
        {
            List<MenuItemData> listMenuItem = new List<MenuItemData>();
            DataTable dt;
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();

            if (string.IsNullOrEmpty(menuCategoryId))
            {
                sqlStoredProcedureParams.Add("tenMonAn", searchName);

                dt = provider.ExecuteReader("MONAN_proc_find", sqlStoredProcedureParams);
            }
            else
            {
                sqlStoredProcedureParams.Add("tenMonAn", searchName);
                sqlStoredProcedureParams.Add("maLoaiMon", menuCategoryId);

                dt = provider.ExecuteReader("MONAN_proc_find_with_MaLoaiMon", sqlStoredProcedureParams);
            }

            foreach (DataRow row in dt.Rows)
            {
                MenuItemData menuItem = new MenuItemData();
                menuItem.MenuItemId = row["MaMonAn"].ToString();
                menuItem.MenuItemName = row["TenMonAn"].ToString();
                menuItem.ImagePath = row["HinhAnh"].ToString();
                menuItem.Unit = new UnitData
                {
                    UnitId = row["MaDonVi"].ToString(),
                    UnitName = row["TenDonVi"].ToString()
                };
                menuItem.Price = Decimal.Parse(row["DonGia"].ToString());

                listMenuItem.Add(menuItem);
            }

            return listMenuItem;
        }

        public List<MenuItemData> GetAllMenuItem(MenuCategoryData menuCategory)
        {
            List<MenuItemData> listMenuItem = new List<MenuItemData>();
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maLoaiMon", menuCategory.MenuCategoryId);
            DataTable dt = provider.ExecuteReader("MONAN_proc_load_with_MaLoaiMon", sqlStoredProcedureParams);

            foreach (DataRow row in dt.Rows)
            {
                MenuItemData MenuItem = new MenuItemData();
                MenuItem.MenuItemId = row["MaMonAn"].ToString();
                MenuItem.MenuItemName = row["TenMonAn"].ToString();
                MenuItem.ImagePath = row["HinhAnh"].ToString();
                MenuItem.Price = Decimal.Parse(row["DonGia"].ToString());

                MenuItem.Unit = new UnitData
                {
                    UnitId = row["MaDonVi"].ToString(),
                    UnitName = row["TenDonVi"].ToString()
                };

                MenuItem.MenuCategory = new MenuCategoryData
                {
                    MenuCategoryId = row["MaLoaiMon"].ToString(),
                    MenuCategoryName = row["TenLoaiMon"].ToString()
                };

                listMenuItem.Add(MenuItem);
            }

            return listMenuItem;
        }

        public int AddMenuItem(MenuItemData MenuItem)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maMonAn", MenuItem.MenuItemId);
            sqlStoredProcedureParams.Add("tenMonAn", MenuItem.MenuItemName);
            sqlStoredProcedureParams.Add("hinhAnh", MenuItem.ImagePath);
            sqlStoredProcedureParams.Add("donGia", MenuItem.Price);
            sqlStoredProcedureParams.Add("maDonVi", MenuItem.Unit.UnitId);
            sqlStoredProcedureParams.Add("maLoaiMon", MenuItem.MenuCategory.MenuCategoryId);
            return provider.ExecuteNonQuery("MONAN_proc_insert", sqlStoredProcedureParams);
        }

        public int UpdateMenuItem(MenuItemData MenuItem)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maMonAn", MenuItem.MenuItemId);
            sqlStoredProcedureParams.Add("tenMonAn", MenuItem.MenuItemName);
            sqlStoredProcedureParams.Add("hinhAnh", MenuItem.ImagePath);
            sqlStoredProcedureParams.Add("donGia", MenuItem.Price);
            sqlStoredProcedureParams.Add("maDonVi", MenuItem.Unit.UnitId);
            sqlStoredProcedureParams.Add("maLoaiMon", MenuItem.MenuCategory.MenuCategoryId);
            return provider.ExecuteNonQuery("MONAN_proc_update", sqlStoredProcedureParams);
        }

        public int DeleteMenuItem(MenuItemData MenuItem)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maMonAn", MenuItem.MenuItemId);
            return provider.ExecuteNonQuery("MONAN_proc_delete", sqlStoredProcedureParams);
        }
    }
}
