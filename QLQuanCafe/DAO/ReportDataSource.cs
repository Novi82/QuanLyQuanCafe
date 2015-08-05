using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLQuanCafe.DAO
{
    public class ReportDataSource : DataSourceBase
    {
        public DataTable GetInventory(int month, int year)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("thang", month);
            sqlStoredProcedureParams.Add("nam", year);
            return provider.ExecuteReader("BAOCAOKHO_proc_cal", sqlStoredProcedureParams);
        }
        public DataTable GetRevenue(int month, int year)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("thang", month);
            sqlStoredProcedureParams.Add("nam", year);
            return provider.ExecuteReader("BAOCAODOANHTHU_proc_cal", sqlStoredProcedureParams);
        }
        public DataTable GetFavouriteDish(int month, int year)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("thang", month);
            sqlStoredProcedureParams.Add("nam", year);
            return provider.ExecuteReader("BAOCAOMONANUATHICH_proc_cal", sqlStoredProcedureParams);
        }
        public List<DataTable> GetBill(string billID)
        {
            List<DataTable> billData = new List<DataTable>();
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maHoaDon", billID);
            Dictionary<string, object> sqlStoredProcedureParams2 = new Dictionary<string, object>();
            sqlStoredProcedureParams2.Add("maHD", billID);
            billData.Add(provider.ExecuteReader("HOADON_proc_load_CTHD", sqlStoredProcedureParams));
            billData.Add(provider.ExecuteReader("HOADON_proc_get_by_MaHD", sqlStoredProcedureParams2));
            return billData;
        }
    }
}

