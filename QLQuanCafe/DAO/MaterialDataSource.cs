using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQuanCafe.DTO;
using System.Data;

namespace QLQuanCafe.DAO
{
    public class MaterialDataSource : DataSourceBase
    {
        public List<MaterialData> GetAllMaterial()
        {
            List<MaterialData> listMaterial = new List<MaterialData>();
            DataTable dt = provider.ExecuteReader("NGUYENLIEU_proc_load");

            foreach (DataRow row in dt.Rows)
            {
                MaterialData material = new MaterialData();
                material.MaterialId = row["MaNguyenLieu"].ToString();
                material.MaterialName = row["TenNguyenLieu"].ToString();
                material.Price = Decimal.Parse(row["GiaNhap"].ToString());
                material.Quantity = int.Parse(row["SoLuong"].ToString());
                material.Unit = new UnitData()
                {
                    UnitId = row["MaDonVi"].ToString(),
                    UnitName = row["TenDonVi"].ToString(),
                };

                listMaterial.Add(material);
            }

            return listMaterial;
        }

        public int AddMaterial(MaterialData material)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("MaNguyenLieu", material.MaterialId);
            sqlStoredProcedureParams.Add("TenNguyenLieu", material.MaterialName);
            sqlStoredProcedureParams.Add("MaDonVi", material.Unit.UnitId);
            sqlStoredProcedureParams.Add("giaNhap", material.Price);
            sqlStoredProcedureParams.Add("SoLuong", 0);
            return provider.ExecuteNonQuery("NGUYENLIEU_proc_insert", sqlStoredProcedureParams);
        }

        public int UpdateMaterial(MaterialData material)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("MaNguyenLieu", material.MaterialId);
            sqlStoredProcedureParams.Add("TenNguyenLieu", material.MaterialName);
            sqlStoredProcedureParams.Add("MaDonVi", material.Unit.UnitId);
            sqlStoredProcedureParams.Add("giaNhap", material.Price);
            sqlStoredProcedureParams.Add("SoLuong", material.Quantity);
            return provider.ExecuteNonQuery("NGUYENLIEU_proc_update", sqlStoredProcedureParams);
        }

        public int DeleteMaterial(MaterialData material)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maNguyenLieu", material.MaterialId);
            return provider.ExecuteNonQuery("NGUYENLIEU_proc_delete", sqlStoredProcedureParams);
        }

        public int ImportMaterial(MaterialData material)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maNguyenLieu", material.MaterialId);
            sqlStoredProcedureParams.Add("thoiGian", DateTime.Now);
            sqlStoredProcedureParams.Add("soLuong", material.Quantity);
            sqlStoredProcedureParams.Add("giaHienTai", material.Price);
            return provider.ExecuteNonQuery("XUATNHAPNGUYENLIEU_proc_nhap", sqlStoredProcedureParams);
        }

        public int ExportMaterial(MaterialData material)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maNguyenLieu", material.MaterialId);
            sqlStoredProcedureParams.Add("thoiGian", DateTime.Now);
            sqlStoredProcedureParams.Add("soLuong", material.Quantity);
            return provider.ExecuteNonQuery("XUATNHAPNGUYENLIEU_proc_xuat", sqlStoredProcedureParams);
        }

        public int UpdateInventory(MaterialData material)
        {
            Dictionary<string, object> sqlStoredProcedureParams = new Dictionary<string, object>();
            sqlStoredProcedureParams.Add("maNguyenLieu", material.MaterialId);
            sqlStoredProcedureParams.Add("thoiGian", DateTime.Now);
            sqlStoredProcedureParams.Add("soLuongThucTe", material.Quantity);
            return provider.ExecuteNonQuery("XUATNHAPNGUYENLIEU_proc_hieuchinh", sqlStoredProcedureParams);
        }
    }
}

