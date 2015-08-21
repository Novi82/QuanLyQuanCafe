using System;
using DevComponents.DotNetBar.Metro;
using QLQuanCafe.BLL;

namespace QLQuanCafe.GUI.Form
{
    public partial class QuanLyKhuVuc_Ban : MetroForm
    {
        private readonly AreaAndTableBll bll;
        public QuanLyKhuVuc_Ban()
        {
            InitializeComponent();
            bll = LocatorBll.AreaAndTableVM;
            LoadArea();
//            LoadTable();
        }

        private void QuanLyKhuVuc_Ban_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewX1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                if (bll.SelectAreaCommand.CanExecute(null))
                {
                    bll.SelectAreaCommand.Execute(dataGridViewX1.SelectedRows[0].DataBoundItem);
                    LoadTable();
                }
            }
        }

        private void dataGridViewX2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewX2.SelectedRows.Count > 0)
            {
                if (bll.SelectTableCommand.CanExecute(null))
                {
                    bll.SelectTableCommand.Execute(dataGridViewX2.SelectedRows[0].DataBoundItem);
                }
            }
        }

        private void LoadArea()
        {
            bll.Load();
            dataGridViewX1.DataSource = bll.ListArea;
        }

        private void LoadTable()
        {
            dataGridViewX2.DataSource = bll.ListTable;
        }

        private void btnThemKhuVuc_Click(object sender, EventArgs e)
        {
            if (bll.ShowAddAreaWindowCommand.CanExecute(null))
            {
                bll.ShowAddAreaWindowCommand.Execute(null);
                LoadArea();
            }
        }

        private void btnSuaKv_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                if (bll.ShowEditAreaWindowCommand.CanExecute(dataGridViewX1.SelectedRows[0]))
                {
                    bll.ShowEditAreaWindowCommand.Execute(dataGridViewX1.SelectedRows[0]);
                    LoadArea();
                }
            }
        }

        private void btnXoaKv_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                if (bll.DeleteAreaCommand.CanExecute(dataGridViewX1.SelectedRows[0]))
                {
                    bll.DeleteAreaCommand.Execute(dataGridViewX1.SelectedRows[0]);
                    LoadArea();
                }
            }
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            if (bll.ShowAddTableWindowCommand.CanExecute(null))
            {
                bll.ShowAddTableWindowCommand.Execute(null);
                LoadTable();
            }
        }

        private void btnSuaBan_Click(object sender, EventArgs e)
        {
            if (dataGridViewX2.SelectedRows.Count > 0)
            {
                if (bll.ShowEditTableWindowCommand.CanExecute(dataGridViewX2.SelectedRows[0]))
                {
                    bll.ShowEditTableWindowCommand.Execute(dataGridViewX2.SelectedRows[0]);
                    LoadTable();
                }
            }
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            if (dataGridViewX2.SelectedRows.Count > 0)
            {
                if (bll.DeleteTableCommand.CanExecute(dataGridViewX2.SelectedRows[0]))
                {
                    bll.DeleteTableCommand.Execute(dataGridViewX2.SelectedRows[0]);
                    LoadTable();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
