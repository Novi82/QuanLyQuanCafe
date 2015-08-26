using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;

namespace QLQuanCafe.GUI.Form
{
    public partial class DonViTinh : MetroForm
    {
        private UnitBll bll = LocatorBll.UnitBll;

        public DonViTinh()
        {
            InitializeComponent();
        }

        private void DanhSachDonViTinh_Load(object sender, EventArgs e)
        {
            LoadDonViTinh();
        }

        public void LoadDonViTinh()
        {
            dataGridViewX1.DataSource = bll.ListUnit;
        }

        private void dataGridViewX1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                if (LocatorBll.UnitBll.SelectUnitCommand.CanExecute(null))
                {
                    LocatorBll.UnitBll.SelectUnitCommand.Execute(dataGridViewX1.SelectedRows[0].DataBoundItem);
                }
            }
        }

        private void btnThemDvt_Click(object sender, EventArgs e)
        {
            if (LocatorBll.UnitBll.ShowAddUnitWindowCommand.CanExecute(null))
            {
                LocatorBll.UnitBll.ShowAddUnitWindowCommand.Execute(null);
                LoadDonViTinh();
                dataGridViewX1.Rows[dataGridViewX1.Rows.Count - 1].Selected = true;
            }
        }

        private void btnSuaDvt_Click(object sender, EventArgs e)
        {
           
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                if (LocatorBll.UnitBll.ShowEditUnitWindowCommand.CanExecute(dataGridViewX1.SelectedRows[0]))
                {
                    if (dataGridViewX1.CurrentRow != null)
                    {
                        int index = dataGridViewX1.CurrentRow.Index;
                        LocatorBll.UnitBll.ShowEditUnitWindowCommand.Execute(dataGridViewX1.SelectedRows[0]);
                        LoadDonViTinh();
                        dataGridViewX1.ClearSelection();
                        dataGridViewX1.Rows[index].Selected = true;
                    }
                }
            }

        }

        private void btnXoaDvt_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                if (LocatorBll.UnitBll.DeleteUnitCommand.CanExecute(dataGridViewX1.SelectedRows[0]))
                {
                    LocatorBll.UnitBll.DeleteUnitCommand.Execute(dataGridViewX1.SelectedRows[0]);
                    LoadDonViTinh();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //this.Close();
            MessageBox.Show(dataGridViewX1.Columns[0].SortMode.ToString()
                + "\n" + dataGridViewX1.SortOrder
                );
            
        }

        private void dataGridViewX1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //dataGridViewX1.Rows[e.RowIndex].Selected = true;
        }
    }
}
