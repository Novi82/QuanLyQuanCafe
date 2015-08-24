using System;
using System.Windows.Forms;
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

            billBll.Load();

            dtiDenNgay.Value = DateTime.Today;
            dtiTuNgay.Value = DateTime.Today;
           
            LoadKhuVuc();
            LoadBan();

            billBll.ListBill = null;
            dgvHoaDon.DataSource = billBll.ListBill;
        }

        private void LoadKhuVuc()
        {
            cbxKhuVuc.DataSource = billBll.ListArea;
        }
        private void LoadBan()
        {
            cbxBan.DataSource = billBll.ListTable;
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void LoadHoaDon()
        {
            dgvHoaDon.DataSource = billBll.ListBill;
        }

        private void dgvHoaDon_RowsAdded(object sender, System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
        {
            var rows = dgvHoaDon.Rows;
            foreach (DataGridViewRow row in rows)
            {
                TableData tableData =(row.Cells["tableDataGridViewTextBoxColumn"]).Value as TableData;
                (row.Cells["areaDataGridViewTextBoxColumn"]).Value = tableData.Area;
            }
           
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            if (billBll.SearchBillCommand.CanExecute(null))
            {
                billBll.SearchBillCommand.Execute(null);
                dgvHoaDon.DataSource = billBll.ListBill;
            }

        }

        private void dtiTuNgay_ValueChanged(object sender, EventArgs e)
        {
            billBll.FromDate = dtiTuNgay.Value;
        }

        private void dtiDenNgay_ValueChanged(object sender, EventArgs e)
        {
            billBll.ToDate = dtiDenNgay.Value;
        }

        private void cbxKhuVuc_SelectedValueChanged(object sender, EventArgs e)
        {
            billBll.AreaSelected = cbxKhuVuc.SelectedValue as AreaData;
            LoadBan();
        }

        private void cbxBan_SelectedValueChanged(object sender, EventArgs e)
        {
            billBll.TableSelected = cbxBan.SelectedValue as TableData;
            cbxKhuVuc.SelectedIndex = cbxKhuVuc.FindString(billBll.AreaSelected.AreaName);
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            if (billBll.RefreshBillCommand.CanExecute(null))
            {
                billBll.RefreshBillCommand.Execute(null);
            }
            LoadBillSearch();
        }

        private void LoadBillSearch()
        {
            dtiTuNgay.Value = billBll.FromDate;
            dtiDenNgay.Value = billBll.ToDate;
            cbxKhuVuc.SelectedIndex = cbxKhuVuc.FindString(billBll.AreaSelected.AreaName);
            cbxBan.SelectedIndex = cbxBan.FindString(billBll.TableSelected.TableName);
        }
    }
}
