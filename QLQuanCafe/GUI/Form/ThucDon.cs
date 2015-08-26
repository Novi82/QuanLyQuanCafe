using System;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;

namespace QLQuanCafe.GUI.Form
{
    public partial class ThucDon : MetroForm
    {
        private readonly MenuCategoryAndMenuItemBll bll = LocatorBll.MenuCategoryAndMenuItemBll;

        public ThucDon()
        {
            InitializeComponent();
            LoadLoaiMonAn();
        }

        private void ThucDon_Load(object sender, EventArgs e)
        {

        }

        private void LoadLoaiMonAn()
        {
            bll.Load();
            dgvLoaiMonAn.DataSource = bll.ListMenuCategory;
        }

        private void LoadMonAn()
        {
            dgvMonAn.DataSource = bll.ListMenuItem;
        }

        private void dgvLoaiMonAn_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoaiMonAn.SelectedRows.Count > 0)
            {
                if (bll.SelectMenuCategoryCommand.CanExecute(null))
                {
                    bll.SelectMenuCategoryCommand.Execute(dgvLoaiMonAn.SelectedRows[0].DataBoundItem);
                    LoadMonAn();
                }
            }
        }

        private void dgvMonAn_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMonAn.SelectedRows.Count > 0)
            {
                if (bll.SelectMenuItemCommand.CanExecute(null))
                {
                    bll.SelectMenuItemCommand.Execute(dgvMonAn.SelectedRows[0].DataBoundItem);
                }
            }
        }
        private void BtnThemLoaiMonAn_Click(object sender, EventArgs e)
        {
            if (bll.ShowAddMenuCategoryWindowCommand.CanExecute(null))
            {
                bll.ShowAddMenuCategoryWindowCommand.Execute(null);
                LoadLoaiMonAn();
                dgvLoaiMonAn.Rows[dgvLoaiMonAn.Rows.Count - 1].Selected = true;
            }
        }

        private void btnSuaLoaiMonAn_Click(object sender, EventArgs e)
        {
            if (dgvLoaiMonAn.SelectedRows.Count > 0)
            {
                if (bll.ShowEditMenuCategoryWindowCommand.CanExecute(dgvLoaiMonAn.SelectedRows[0]))
                {
                    if (dgvLoaiMonAn.CurrentRow != null)
                    {
                        int index = dgvLoaiMonAn.CurrentRow.Index;
                        bll.ShowEditMenuCategoryWindowCommand.Execute(dgvLoaiMonAn.SelectedRows[0]);
                        LoadLoaiMonAn();
                        dgvLoaiMonAn.ClearSelection();
                        dgvLoaiMonAn.Rows[index].Selected = true;
                    }
                }
            }
        }

        private void btnXoaLoaiMonAn_Click(object sender, EventArgs e)
        {
            if (dgvLoaiMonAn.SelectedRows.Count > 0)
            {
                if (bll.DeleteMenuCategoryCommand.CanExecute(dgvLoaiMonAn.SelectedRows[0]))
                {
                    bll.DeleteMenuCategoryCommand.Execute(dgvLoaiMonAn.SelectedRows[0]);
                    LoadLoaiMonAn();
                }
            }
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            if (bll.ShowAddMenuItemWindowCommand.CanExecute(null))
            {
                bll.ShowAddMenuItemWindowCommand.Execute(null);
                LoadMonAn();
                dgvMonAn.Rows[dgvMonAn.Rows.Count - 1].Selected = true;
            }
        }

        private void btnSuaMonAn_Click(object sender, EventArgs e)
        {
            if (dgvMonAn.SelectedRows.Count > 0)
            {
                int index = dgvMonAn.CurrentRow.Index;
                if (bll.ShowEditMenuItemWindowCommand.CanExecute(dgvMonAn.SelectedRows[0]))
                {
                    bll.ShowEditMenuItemWindowCommand.Execute(dgvMonAn.SelectedRows[0]);
                }
                LoadMonAn();
                dgvMonAn.ClearSelection();
                dgvMonAn.Rows[index].Selected = true;
            }
        }

        private void btnXoaMonAn_Click(object sender, EventArgs e)
        {
            if (dgvMonAn.SelectedRows.Count > 0)
            {
                if (bll.DeleteMenuItemCommand.CanExecute(dgvMonAn.SelectedRows[0]))
                {
                    bll.DeleteMenuItemCommand.Execute(dgvMonAn.SelectedRows[0]);
                    LoadMonAn();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
