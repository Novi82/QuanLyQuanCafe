using System;
using System.Collections.Generic;
using System.Data;
using QLQuanCafe.DTO;

namespace QLQuanCafe.DAO
{
    public class BillDataSource : DataSourceBase
    {
        /// <summary>
        /// Lấy ra bill chưa thanh toán cuối cùng của bàn.
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public BillData GetLastBill(TableData table)
        {
            BillData bill = new BillData();
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maBan", table.TableId);
            DataTable dt = provider.ExecuteReader("HOADON_proc_get_last_bill", sqlStoredProcedureParams);

            if (dt.Rows.Count == 1)
            {
                bill.BillId = dt.Rows[0]["MaHoaDon"].ToString();
                bill.Table = new TableData { TableId = dt.Rows[0]["MaBan"].ToString() };
                bill.TableLiquidate = new TableData { TableId = dt.Rows[0]["MaBanThanhToan"].ToString() };
                bill.Time = DateTime.Parse(dt.Rows[0]["ThoiGian"].ToString());
                bill.TotalMoney = Decimal.Parse(dt.Rows[0]["TongTien"].ToString());
            }

            return bill;
        }

        public int AddBill(BillData bill)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maHoaDon", bill.BillId);
            sqlStoredProcedureParams.Add("maBan", bill.Table.TableId);
            sqlStoredProcedureParams.Add("thoiGian", DateTime.Now);

            return provider.ExecuteNonQuery("HOADON_proc_insert", sqlStoredProcedureParams);
        }

        public int DeleteBill(BillData bill)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maHoaDon", bill.BillId);

            return provider.ExecuteNonQuery("HOADON_proc_delete", sqlStoredProcedureParams);
        }

        /// <summary>
        /// Chuyển hóa đơn khi chuyển bàn.
        /// </summary>
        /// <param name="maHoaDon">mã hóa đơn cần chuyển</param>
        /// <param name="maBan">mã bàn chuyển đến</param>
        /// <returns></returns>
        public int ChangeBill(string maHoaDon, string maBan)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maHoaDon", maHoaDon);
            sqlStoredProcedureParams.Add("maBan", maBan);

            return provider.ExecuteNonQuery("HOADON_proc_changeTable", sqlStoredProcedureParams);
        }

        /// <summary>
        /// Gộp hóa đơn khi gộp bàn.
        /// </summary>
        /// <param name="maHoaDon">mã hóa đơn cần gộp (của bàn thứ 1)</param>
        /// <param name="maBanThanhToan">>mã bàn thanh toán (mã bàn thứ 2)</param>
        /// <returns></returns>
        public int GroupBill(string maHoaDon, string maBanThanhToan)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maHoaDon", maHoaDon);
            sqlStoredProcedureParams.Add("maBanThanhToan", maBanThanhToan);

            return provider.ExecuteNonQuery("HOADON_proc_changePayTable", sqlStoredProcedureParams);
        }

        /// <summary>
        /// Tách hóa đơn khi tách bàn.
        /// </summary>
        /// <param name="bill"></param>
        /// <returns></returns>
        public int UnGroupBill(BillData bill)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maHoaDon", bill.BillId);

            return provider.ExecuteNonQuery("HOADON_proc_unGroupAll", sqlStoredProcedureParams);
        }

        /// <summary>
        /// Thanh toán hóa đơn.
        /// </summary>
        /// <param name="bill"></param>
        /// <returns></returns>
        public int PayBill(BillData bill)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maHoaDon", bill.BillId);

            return provider.ExecuteNonQuery("HOADON_proc_pay", sqlStoredProcedureParams);
        }

        /// <summary>
        /// Đánh dấu các món ăn lưu trong hóa đơn thành đã được chuẩn bị.
        /// </summary>
        /// <param name="bill"></param>
        /// <returns></returns>
        public int PrepareBill(BillData bill)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>
            {
                {"maHoaDon", bill.BillId}
            };

            return provider.ExecuteNonQuery("HOADON_proc_prepare", sqlStoredProcedureParams);
        }

        public List<BillData> FindBill(DateTime startDay, DateTime endDay, string tableId, string areaId)
        {
            List<BillData> listBill = new List<BillData>();
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("tuNgay", startDay);
            sqlStoredProcedureParams.Add("denNgay", endDay);
            sqlStoredProcedureParams.Add("maBan", "%" + tableId + "%");
            sqlStoredProcedureParams.Add("maKhuVuc", "%" + areaId + "%");

            DataTable dt = provider.ExecuteReader("HOADON_proc_search", sqlStoredProcedureParams);

            foreach (DataRow row in dt.Rows)
            {
                BillData bill = new BillData();
                bill.BillId = row["MaHoaDon"].ToString();
                bill.Table = new TableData
                {
                    TableId = row["MaBan"].ToString(),
                    TableName = row["TenBan"].ToString(),
                    Area = new AreaData
                    {
                        AreaId = row["MaKhuVuc"].ToString(),
                        AreaName = row["TenKhuVuc"].ToString()
                    }
                };
                bill.Time = DateTime.Parse(row["ThoiGian"].ToString());
                bill.TotalMoney = Decimal.Parse(row["TongTien"].ToString());

                listBill.Add(bill);
            }

            return listBill;
        }
    }

}
