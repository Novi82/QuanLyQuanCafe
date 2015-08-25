using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;

namespace QLQuanCafe.GUI.Form
{
    public partial class DonViTinh : MetroForm
    {
        private UnitBll bll = LocatorBll.UnitVM;

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
                if (LocatorBll.UnitVM.SelectUnitCommand.CanExecute(null))
                {
                    LocatorBll.UnitVM.SelectUnitCommand.Execute(dataGridViewX1.SelectedRows[0].DataBoundItem);
                }
            }
        }

        private void btnThemDvt_Click(object sender, EventArgs e)
        {
            if (LocatorBll.UnitVM.ShowAddUnitWindowCommand.CanExecute(null))
            {
                LocatorBll.UnitVM.ShowAddUnitWindowCommand.Execute(null);
                LoadDonViTinh();
            }
        }

        private void btnSuaDvt_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                if (LocatorBll.UnitVM.ShowEditUnitWindowCommand.CanExecute(dataGridViewX1.SelectedRows[0]))
                {
                    LocatorBll.UnitVM.ShowEditUnitWindowCommand.Execute(dataGridViewX1.SelectedRows[0]);
                    LoadDonViTinh();
                }
            }
        }

        private void btnXoaDvt_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                if (LocatorBll.UnitVM.DeleteUnitCommand.CanExecute(dataGridViewX1.SelectedRows[0]))
                {
                    LocatorBll.UnitVM.DeleteUnitCommand.Execute(dataGridViewX1.SelectedRows[0]);
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
    }
}
