using System;
using System.Collections.Generic;
using System.Data;
using QLQuanCafe.DTO;

namespace QLQuanCafe.DAO
{
    public class BillDetailDataSource : DataSourceBase
    {
        /// <summary>
        /// Lấy ra tất cả chi tiết hóa đơn của một hóa đơn.
        /// </summary>
        /// <param name="bill"></param>
        /// <returns></returns>
        public List<BillDetailData> GetAllBillDetail(BillData bill)
        {
            List<BillDetailData> listBillDetail = new List<BillDetailData>();
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maHoaDon", bill.BillId);
            DataTable dt = provider.ExecuteReader("HOADON_proc_load_CTHD", sqlStoredProcedureParams);

            foreach (DataRow row in dt.Rows)
            {
                BillDetailData billDetail = new BillDetailData();
                billDetail.BillDetaiId = row["MaCTHoaDon"].ToString();
                billDetail.BillId = row["MaHoaDon"].ToString();
                billDetail.MenuItem = new MenuItemData
                {
                    MenuItemId = row["MaMonAn"].ToString(),
                    MenuItemName = row["TenMonAn"].ToString(),
                    Unit = new UnitData
                    {
                        UnitId = row["MaDonVi"].ToString(),
                        UnitName = row["TenDonVi"].ToString()
                    },
                    Price = Decimal.Parse(row["DonGia"].ToString())
                };
                billDetail.Quantity = int.Parse(row["SoLuong"].ToString());
                billDetail.IsPrepare = bool.Parse(row["DaChuanBi"].ToString());

                listBillDetail.Add(billDetail);
            }

            return listBillDetail;
        }

        /// <summary>
        /// Thêm mới một chi tiết hóa đơn.
        /// </summary>
        /// <param name="billDetail"></param>
        /// <returns></returns>
        public int AddBillDetail(BillDetailData billDetail)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maCTHoaDon", billDetail.BillDetaiId);
            sqlStoredProcedureParams.Add("maHoaDon", billDetail.BillId);
            sqlStoredProcedureParams.Add("maMonAn", billDetail.MenuItem.MenuItemId);
            sqlStoredProcedureParams.Add("soLuong", billDetail.Quantity);
            sqlStoredProcedureParams.Add("ghiChu", billDetail.Note);

            return provider.ExecuteNonQuery("CTHOADON_proc_insert", sqlStoredProcedureParams);
        }

        /// <summary>
        /// Update chi tiết hóa đơn (số lượng, ghi chú) khi có thay đổi.
        /// </summary>
        /// <param name="billDetail"></param>
        /// <returns></returns>
        public int UpdateBillDetail(BillDetailData billDetail)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maCTHoaDon", billDetail.BillDetaiId);
            sqlStoredProcedureParams.Add("soLuong", billDetail.Quantity);
            sqlStoredProcedureParams.Add("ghiChu", billDetail.Note);

            return provider.ExecuteNonQuery("CTHOADON_proc_update", sqlStoredProcedureParams);
        }

        /// <summary>
        /// Xóa đi chi tiết hóa đơn đó. Khi người dùng bỏ 1 món ăn ra khỏi hóa đơn.
        /// </summary>
        /// <param name="billDetail"></param>
        /// <returns></returns>
        public int DeleteBillDetail(BillDetailData billDetail)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maCTHoaDon", billDetail.BillDetaiId);

            return provider.ExecuteNonQuery("CTHOADON_proc_delete", sqlStoredProcedureParams);
        }
    }
}
