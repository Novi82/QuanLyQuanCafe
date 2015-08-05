using System.Collections.Generic;
using System.Data;
using QLQuanCafe.DTO;

namespace QLQuanCafe.DAO
{
    public class UnitDataSource : DataSourceBase
    {
        public List<UnitData> GetAllUnit()
        {
            List<UnitData> listUnit = new List<UnitData>();
            DataTable dt = provider.ExecuteReader("DONVITINH_proc_load");

            foreach (DataRow row in dt.Rows)
            {
                UnitData unit = new UnitData();
                unit.UnitId = row["MaDonVi"].ToString();
                unit.UnitName = row["TenDonVi"].ToString();

                listUnit.Add(unit);
            }

            return listUnit;
        }

        public int AddUnit(UnitData unit)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maDonVi", unit.UnitId);
            sqlStoredProcedureParams.Add("tenDonVi", unit.UnitName);
            return provider.ExecuteNonQuery("DONVITINH_proc_insert", sqlStoredProcedureParams);
        }

        public int UpdateUnit(UnitData unit)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maDonVi", unit.UnitId);
            sqlStoredProcedureParams.Add("tenDonVi", unit.UnitName);
            return provider.ExecuteNonQuery("DONVITINH_proc_update", sqlStoredProcedureParams);
        }

        public int DeleteUnit(UnitData unit)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maDonVi", unit.UnitId);
            return provider.ExecuteNonQuery("DONVITINH_proc_delete", sqlStoredProcedureParams);
        }
    }
}
