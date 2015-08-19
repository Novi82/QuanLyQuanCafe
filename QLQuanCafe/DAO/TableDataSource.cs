using System.Collections.Generic;
using System.Data;
using QLQuanCafe.DTO;

namespace QLQuanCafe.DAO
{
    public class TableDataSource : DataSourceBase
    {
        public List<TableData> GetAllTable()
        {
            List<TableData> listTable = new List<TableData>();
            DataTable dt = provider.ExecuteReader("BAN_proc_load");

            foreach (DataRow row in dt.Rows)
            {
                TableData table = new TableData();
                table.TableId = row["MaBan"].ToString();
                table.TableName = row["TenBan"].ToString();
                table.Area = new AreaData
                {
                    AreaId = row["MaKhuVuc"].ToString(),
                    AreaName = row["TenKhuVuc"].ToString()
                };

                table.TableState = row["TinhTrang"].ToString();

                listTable.Add(table);
            }

            return listTable;
        }

        public List<TableData> GetAllTable(AreaData area)
        {
            List<TableData> listTable = new List<TableData>();
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maKhuVuc", area.AreaId);
            DataTable dt = provider.ExecuteReader("BAN_proc_load_with_MaKhuVuc", sqlStoredProcedureParams);

            foreach (DataRow row in dt.Rows)
            {
                TableData table = new TableData();
                table.TableId = row["MaBan"].ToString();
                table.TableName = row["TenBan"].ToString();
                table.Area = area;
                table.TableState = row["TinhTrang"].ToString();
                table.Note = row["GhiChu"].ToString();

                listTable.Add(table);
            }

            return listTable;
        }

        public List<TableData> GetAllTableToChoose(AreaData area)
        {
            List<TableData> listTable = new List<TableData>();

            TableData all = new TableData();
            all.TableName = "Tất cả bàn";
            listTable.Add(all);

            DataTable dt = null;

            if (string.IsNullOrEmpty(area.AreaId))
            {
                dt = provider.ExecuteReader("BAN_proc_load");
            }
            else
            {
                Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
                sqlStoredProcedureParams.Add("maKhuVuc", area.AreaId);
                dt = provider.ExecuteReader("BAN_proc_load_with_MaKhuVuc", sqlStoredProcedureParams);
            }

            foreach (DataRow row in dt.Rows)
            {
                TableData table = new TableData();
                table.TableId = row["MaBan"].ToString();
                table.TableName = row["TenBan"].ToString();

                table.Area = new AreaData
                {
                    AreaId = row["MaKhuVuc"].ToString()
                };

                listTable.Add(table);
            }

            return listTable;
        }

        public TableData GetTable(TableData table)
        {
            TableData getTable = new TableData();
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maBan", table.TableId);
            DataTable dt = provider.ExecuteReader("BAN_proc_get", sqlStoredProcedureParams);


            if (dt.Rows.Count == 1)
            {
                getTable.TableId = dt.Rows[0]["MaBan"].ToString();
                getTable.TableName = dt.Rows[0]["TenBan"].ToString();
                getTable.Area = new AreaData
                {
                    AreaId = dt.Rows[0]["MaKhuVuc"].ToString(),
                    AreaName = dt.Rows[0]["TenKhuVuc"].ToString()
                };

                getTable.TableState = dt.Rows[0]["TinhTrang"].ToString();
            }

            return getTable;
        }

        public int AddTable(TableData table)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maBan", table.TableId);
            sqlStoredProcedureParams.Add("tenBan", table.TableName);
            sqlStoredProcedureParams.Add("maKhuVuc", table.Area.AreaId);
            sqlStoredProcedureParams.Add("ghiChu", table.Note);
            return provider.ExecuteNonQuery("BAN_proc_insert", sqlStoredProcedureParams);
        }

        public int UpdateTable(TableData table)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maBan", table.TableId);
            sqlStoredProcedureParams.Add("tenBan", table.TableName);
            sqlStoredProcedureParams.Add("maKhuVuc", table.Area.AreaId);
            sqlStoredProcedureParams.Add("ghiChu", table.Note);
            return provider.ExecuteNonQuery("BAN_proc_update", sqlStoredProcedureParams);
        }

        public int DeleteTable(TableData table)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maBan", table.TableId);
            return provider.ExecuteNonQuery("BAN_proc_delete", sqlStoredProcedureParams);
        }

        public int OrderTable(TableData table)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maBan", table.TableId);
            return provider.ExecuteNonQuery("BAN_proc_dat_ban", sqlStoredProcedureParams);
        }

        public int CancelOrderTable(TableData table)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maBan", table.TableId);
            return provider.ExecuteNonQuery("BAN_proc_huy_dat_ban", sqlStoredProcedureParams);
        }
    }
}
