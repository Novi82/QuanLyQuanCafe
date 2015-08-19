using System;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;
using QLQuanCafe.DTO;

namespace QLQuanCafe.GUI.Form
{
    public partial class HoaDon : MetroForm
    {
        private BillBll billBll = LocatorBll.BillVM;
        private AreaAndTableBll areaAndTableBll = LocatorBll.AreaAndTableVM;
        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void LoadHoaDon()
        {
            dgvHoaDon.DataSource = billBll.ListBill;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHoaDon_RowsAdded(object sender, System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
        {
            TableData tableData = (dgvHoaDon.Rows[e.RowIndex].Cells["tableDataGridViewTextBoxColumn"]).Value as TableData;
            (dgvHoaDon.Rows[e.RowIndex].Cells["areaDataGridViewTextBoxColumn"]).Value = tableData.Area; 
        }
    }
}
