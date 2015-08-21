using System;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;

namespace QLQuanCafe.GUI.Form
{
    public partial class Kho : MetroForm
    {
        private MaterialBll materialBll = LocatorBll.MaterialVM;
        private UnitBll UnitBll = LocatorBll.UnitVM;
        public Kho()
        {
            InitializeComponent();
        }

        private void Kho_Load(object sender, EventArgs e)
        {
            LoadNguyenLieu();
        }

        private void LoadNguyenLieu()
        {
            dgvKho.DataSource = materialBll.ListMaterial;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            materialBll.ShowAddMaterialWindowCommand.Execute(null);
            LoadNguyenLieu();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (dgvKho.SelectedRows.Count > 0)
            {
                if (materialBll.ShowImportMaterialWindowCommand.CanExecute(dgvKho.SelectedRows[0]))
                {
                    materialBll.ShowImportMaterialWindowCommand.Execute(dgvKho.SelectedRows[0]);
                    LoadNguyenLieu();
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (dgvKho.SelectedRows.Count > 0)
            {
                if (materialBll.ShowExportMaterialWindowCommand.CanExecute(dgvKho.SelectedRows[0]))
                {
                    materialBll.ShowExportMaterialWindowCommand.Execute(dgvKho.SelectedRows[0]);
                    LoadNguyenLieu();
                }
            }
        }

        private void btnHieuChinh_Click(object sender, EventArgs e)
        {
            if (dgvKho.SelectedRows.Count > 0)
            {
                if (materialBll.ShowUpdateInventoryWindowCommand.CanExecute(dgvKho.SelectedRows[0]))
                {
                    materialBll.ShowUpdateInventoryWindowCommand.Execute(dgvKho.SelectedRows[0]);
                    LoadNguyenLieu();
                }
            }
        }

        private void dgvKho_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKho.SelectedRows.Count > 0)
            {
                if (materialBll.SelectMaterialCommand.CanExecute(null))
                {
                    materialBll.SelectMaterialCommand.Execute(dgvKho.SelectedRows[0].DataBoundItem);

//                    dgvKho.Selecteditem = null;
//                    dgvKho.ClearSelection();
                }
            }
        }
    }
}
