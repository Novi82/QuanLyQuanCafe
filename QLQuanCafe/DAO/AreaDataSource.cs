using System.Collections.Generic;
using System.Data;
using QLQuanCafe.DTO;

namespace QLQuanCafe.DAO
{
    public class AreaDataSource : DataSourceBase
    {
      public List<AreaData> GetAllArea()
        {
            List<AreaData> listArea = new List<AreaData>();
            DataTable dt = provider.ExecuteReader("KHUVUC_proc_load");

            foreach (DataRow row in dt.Rows)
            {
                AreaData area = new AreaData();
                area.AreaId = row["MaKhuVuc"].ToString();
                area.AreaName = row["TenKhuVuc"].ToString();

                listArea.Add(area);
            }

            return listArea;
        }

      public List<AreaData> GetAllAreaToChoose()
        {
            List<AreaData> listArea = new List<AreaData>();

            AreaData all = new AreaData();
            all.AreaName = "Tất cả khu vực";
            listArea.Add(all);

            DataTable dt = provider.ExecuteReader("KHUVUC_proc_load");

            foreach (DataRow row in dt.Rows)
            {
                AreaData area = new AreaData();
                area.AreaId = row["MaKhuVuc"].ToString();
                area.AreaName = row["TenKhuVuc"].ToString();

                listArea.Add(area);
            }

            return listArea;
        }

        public int AddArea(AreaData area)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maKhuVuc", area.AreaId);
            sqlStoredProcedureParams.Add("tenKhuVuc", area.AreaName);
            sqlStoredProcedureParams.Add("ghiChu", area.Note);
            return provider.ExecuteNonQuery("KHUVUC_proc_insert", sqlStoredProcedureParams);
        }

        public int UpdateArea(AreaData area)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maKhuVuc", area.AreaId);
            sqlStoredProcedureParams.Add("tenKhuVuc", area.AreaName);
            sqlStoredProcedureParams.Add("ghiChu", area.Note);
            return provider.ExecuteNonQuery("KHUVUC_proc_update", sqlStoredProcedureParams);
        }

        public int DeleteArea(AreaData area)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maKhuVuc", area.AreaId);
            return provider.ExecuteNonQuery("KHUVUC_proc_delete", sqlStoredProcedureParams);
        }
    }
}
