using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QLQuanCafe.BLL;
using QLQuanCafe.Common;
using QLQuanCafe.DTO;

namespace QLQuanCafe.GUI.Form
{
    public partial class DoanhThuThang : DevComponents.DotNetBar.Metro.MetroForm
    {
        public DoanhThuThang()
        {
            InitializeComponent();
        }

        private void DoanhThuThang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeemanagementDataSet4.hoadon' table. You can move, or remove it, as needed.
            this.hoadonTableAdapter.Fill(this.coffeemanagementDataSet4.hoadon);
            this.reportViewer1.Refresh();
        }

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
    }
    }
