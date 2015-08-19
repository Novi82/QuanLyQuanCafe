using System;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;

namespace QLQuanCafe.GUI.Form
{
    public partial class ThongTinNguyenLieu : MetroForm
    {
        private MaterialBll bll = LocatorBll.MaterialVM;
        public ThongTinNguyenLieu()
        {
            InitializeComponent();
        }

        private void ThongTinNguyenLieu_Load(object sender, EventArgs e)
        {
            LoadNguyenLieu();
        }

        private void LoadNguyenLieu()
        {
            dgvNguyenLieu.DataSource = bll.ListMaterial;
        }
        private void dgvNguyenLieu_SelectionChanged(object sender, EventArgs e)
        {
            if (bll.SelectMaterialCommand.CanExecute(null) && dgvNguyenLieu.SelectedRows.Count > 0)
            {
                bll.SelectMaterialCommand.Execute(dgvNguyenLieu.SelectedRows[0]);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemNguyenLieu_Click(object sender, EventArgs e)
        {
            bll.ShowAddMaterialWindowCommand.Execute(null);
            LoadNguyenLieu();
        }

        private void btnSuaNguyenLieu_Click(object sender, EventArgs e)
        {
            if (dgvNguyenLieu.SelectedRows.Count > 0)
            {
                if (bll.ShowEditMaterialWindowCommand.CanExecute(dgvNguyenLieu.SelectedRows[0]))
                {
                    bll.ShowEditMaterialWindowCommand.Execute(dgvNguyenLieu.SelectedRows[0]);
                    LoadNguyenLieu();
                }
            }
        }

        private void btnXoaNguyenLieu_Click(object sender, EventArgs e)
        {
            if (dgvNguyenLieu.SelectedRows.Count > 0)
            {
                if (bll.DeleteMaterialCommand.CanExecute(dgvNguyenLieu.SelectedRows[0]))
                {
                    bll.DeleteMaterialCommand.Execute(dgvNguyenLieu.SelectedRows[0]);
                    LoadNguyenLieu();
                }
            }
        }
    }
}
