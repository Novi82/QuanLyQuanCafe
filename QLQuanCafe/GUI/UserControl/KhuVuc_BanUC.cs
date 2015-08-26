using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using QLQuanCafe.BLL;
using QLQuanCafe.DAO;
using QLQuanCafe.DTO;
using QLQuanCafe.GUI.Form;

// ReSharper disable All

namespace QLQuanCafe.GUI.UserControl
{
    public partial class KhuVuc_BanUC : System.Windows.Forms.UserControl
    {
        private AreaAndTableBll areaAndTableBll = LocatorBll.AreaAndTableBll;
        private HomePageBll homePageBll = LocatorBll.HomePageBll;
        private ListViewItem currentItem = new ListViewItem();
        public SuperTabItem currentTabItem { get; set; }
        public int supertTabItemSelectedIndex { get; set; }
        public SuperTabControlPanel currentSuperTabControlPanel { get; set; }
        public ListViewEx currentListViewEx { get; set; }
        public ListViewItem currentListViewItem { get; set; }
        public KhuVuc_BanUC()
        {
            InitializeComponent();
            homePageBll.OnUpdateView += delegate(object myObject, EventArgs args) { LoadKhuVuc(); };
            stcKhuVuc.SelectedTabIndex = 1;
        }

        private void KhuVuc_BanUC_Load(object sender, EventArgs e)
        {
            btnHuyMon.Enabled = true;
        }

        private void SwitchButton()
        {
            String state = (homePageBll.TableSelected != null) ? homePageBll.TableSelected.TableState : null;
            if ("Trong".Equals(state))
            {
                btnMoBan.Enabled = true;
                btnHuyBan.Enabled = false;
                btnDatBan.Enabled = true;
                btnHuyDatBan.Enabled = false;
                btnGoiMon.Enabled = false;
            }
            else if ("CoNguoi".Equals(state))
            {
                btnMoBan.Enabled = false;
                btnHuyBan.Enabled = true;
                btnDatBan.Enabled = false;
                btnHuyDatBan.Enabled = false;
                btnGoiMon.Enabled = true;
            }
            else if ("DaDat".Equals(state))
            {
                btnMoBan.Enabled = false;
                btnHuyBan.Enabled = false;
                btnDatBan.Enabled = false;
                btnHuyDatBan.Enabled = true;
                btnGoiMon.Enabled = false;
            }
        }
        public void LoadKhuVuc()
        {
            //saveCurrent();
            stcKhuVuc.Tabs.Clear();
            List<AreaData> _list = areaAndTableBll.ListArea;
            foreach (AreaData area in _list)
            {
                SuperTabItem areaTabItem = new SuperTabItem();
                areaTabItem.Text = area.AreaName;

                SuperTabControlPanel panel = new SuperTabControlPanel();

                // list view init
                ListViewEx listview = new ListViewEx();
                listview.Name = "listview";
                listview.BackColor = Color.White;
                listview.Dock = DockStyle.Fill;
                listview.LargeImageList = tableImage;
                listview.SelectedIndexChanged += listview_SelectedIndexChanged;
                LocatorBll.AreaAndTableBll.SelectAreaCommand.Execute(area);

                List<TableData> listtable = LocatorBll.AreaAndTableBll.ListTable;
                List<TableData> alltable = new List<TableData>();
                foreach (TableData tableData in listtable)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = tableData.TableName;
                    item.ImageKey = tableData.TableState;
                    item.Tag = tableData;
                    listview.Items.Add(item);

                    alltable.Add(tableData);

                }
                homePageBll.ListTable = alltable;
                // tab panel config
                panel.Controls.Add(listview);
                //panel.Dock = DockStyle.Fill;
                //                panel.Location = new System.Drawing.Point(0, 33);
                panel.Name = area.AreaId;
                panel.Size = new System.Drawing.Size(600, 800);
                //              panel.TabIndex = 0;

                stcKhuVuc.Controls.Add(panel);
                areaTabItem.AttachedControl = panel;

                stcKhuVuc.Tabs.Add(areaTabItem);
                //loadCurrent();
            }
        }

        private void saveCurrent()
        {
            currentTabItem = stcKhuVuc.SelectedTab;
            supertTabItemSelectedIndex = stcKhuVuc.SelectedTabIndex;
            currentSuperTabControlPanel = (SuperTabControlPanel) currentTabItem.AttachedControl ;
            currentListViewEx = (ListViewEx) currentSuperTabControlPanel.Controls["listview"];
            if (currentListViewEx!= null && currentListViewEx.SelectedItems.Count > 0)
            {
                currentListViewItem = currentListViewEx.SelectedItems[0];
            }
            else
            {
                currentListViewItem = null;
            }
        }

        private void loadCurrent()
        {

            //stcKhuVuc.SelectedTab =currentTabItem ;
            stcKhuVuc.SelectedTabIndex = supertTabItemSelectedIndex;
            //currentTabItem.AttachedControl = currentSuperTabControlPanel;
            //((ListViewEx)stcKhuVuc.SelectedTab.AttachedControl).
            //currentListViewEx = (ListViewEx)currentSuperTabControlPanel.Controls["listview"];
            //currentListViewItem = currentListViewEx.SelectedItems[0];
            if (currentListViewItem!=null)
            {
                 currentListViewItem.Selected = true;
            }
           
        }
        void listview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (homePageBll != null)
            {
                if (homePageBll.SelectTableCommand.CanExecute(null))
                {
                    ListViewEx listView = sender as ListViewEx;
                    if (listView.SelectedItems.Count > 0)
                    {
                        currentItem = listView.SelectedItems[0];
                        homePageBll.SelectTableCommand.Execute(listView.SelectedItems[0].Tag);
                        TableData currenttable = homePageBll.TableSelected;
                        updateInfo(currenttable);
                        lblGioDen.Text = homePageBll.BillOfTableSelected.Time.ToString();
                        SwitchButton();
                        LoadBillDetail();
                    }
                }
            }
        }

        private void updateInfo(TableData table)
        {
            lblTenBan.Text = table.TableName;
            string trangthai = "???";
            string TableState = table.TableState;
            if ("Trong".Equals(TableState))
            {
                trangthai = "Trống";
            }
            else if ("CoNguoi".Equals(TableState))
            {
                trangthai = "Có Người";
            }
            else if ("ChuaDon".Equals(TableState))
            {
                trangthai = "Chưa Dọn";
            }
            else if ("DaDat".Equals(TableState))
            {
                trangthai = "Đã Đặt Trước";
            }
            lblTrangThai.Text = trangthai;
            if (homePageBll.BillOfTableSelected != null && homePageBll.BillOfTableSelected.TableLiquidate != null)
            {
                TableData tableLiquidate = null;
                tableLiquidate = LocatorDataSource.TableDS.GetTable(homePageBll.BillOfTableSelected.TableLiquidate);
                if (tableLiquidate != null)
                {
                    lblBanThanhToan.Text = tableLiquidate.TableName;
                }

            }
            else
            {
                lblBanThanhToan.Text = String.Empty;
            }
        }
        private void btnMoBan_Click(object sender, EventArgs e)
        {
            TableData selectedTable = homePageBll.TableSelected;
            if (selectedTable != null)
            {
                if (homePageBll.OpenTableCommand.CanExecute(selectedTable))
                {
                    homePageBll.OpenTableCommand.Execute(selectedTable);
                    currentItem.ImageKey = homePageBll.TableSelected.TableState;
                    updateInfo(homePageBll.TableSelected);
                    lblGioDen.Text = DateTime.Now.ToString();
                    homePageBll.BillOfTableSelected.Time = DateTime.Now;
                    SwitchButton();
                }
            }

        }

        private void btnHuyBan_Click(object sender, EventArgs e)
        {
            TableData selectedTable = homePageBll.TableSelected;
            if (selectedTable != null)
            {
                if (homePageBll.CloseTableCommand.CanExecute(selectedTable))
                {
                    homePageBll.CloseTableCommand.Execute(selectedTable);
                    currentItem.ImageKey = homePageBll.TableSelected.TableState;
                    updateInfo(homePageBll.TableSelected);
                    lblGioDen.Text = string.Empty;
                    homePageBll.BillOfTableSelected.Time = null;
                    SwitchButton();
                }
            }
        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            TableData selectedTable = homePageBll.TableSelected;
            if (selectedTable != null)
            {
                if (homePageBll.OrderTableCommand.CanExecute(selectedTable))
                {
                    homePageBll.OrderTableCommand.Execute(selectedTable);
                    currentItem.ImageKey = homePageBll.TableSelected.TableState;
                    updateInfo(homePageBll.TableSelected);
                    lblGioDen.Text = string.Empty;
                    homePageBll.BillOfTableSelected.Time = null;
                    SwitchButton();
                }
            }
        }

        private void btnHuyDatBan_Click(object sender, EventArgs e)
        {
            TableData selectedTable = homePageBll.TableSelected;
            if (selectedTable != null)
            {
                if (homePageBll.CancelOrderTableCommand.CanExecute(selectedTable))
                {
                    homePageBll.CancelOrderTableCommand.Execute(selectedTable);
                    currentItem.ImageKey = homePageBll.TableSelected.TableState;
                    updateInfo(homePageBll.TableSelected);
                    lblGioDen.Text = string.Empty;
                    homePageBll.BillOfTableSelected.Time = null;
                    SwitchButton();
                }
            }
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            GoiMon goiMon = new GoiMon();
            goiMon.ShowDialog();
            LoadBillDetail();
        }

        private void dgvMonDaGoi_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridViewX dgv = sender as DataGridViewX;
            MenuItemData menuItemData = null;
            var rows = dgv.Rows;
            if (dgv != null)
            {
                foreach (DataGridViewRow row in rows)
                {
                    menuItemData = (row.Cells["menuItemDataGridViewTextBoxColumn"]).Value as MenuItemData;
                    if (menuItemData != null)
                    {
                        (row.Cells["DonGia"]).Value = menuItemData.Price;
                    }
                }
                //lblTongTien.Text = homePageBll.BillOfTableSelected.TotalMoney.ToString();
            }

        }

        private void LoadBillDetail()
        {
            dgvMonDaGoi.DataSource = homePageBll.BillDetaisOfTableSelected;
            var rows = dgvMonDaGoi.Rows;
            foreach (DataGridViewRow row in rows)
            {
                var data = row.DataBoundItem as BillDetailData;
                if (data.IsPrepare)
                {
                    row.DefaultCellStyle.BackColor = Color.CadetBlue;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
            var tongtien = homePageBll.BillOfTableSelected.TotalMoney;
            //lblTongTien.Text = String.Format("{0:0,0 vnđ}", tongtien);
            lblTongTien.Text = tongtien.ToString("#,### vnđ");
        }

        private void dgvMonDaGoi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMonDaGoi.SelectedRows.Count > 0)
            {
                if (homePageBll != null)
                {
                    if (homePageBll.SelectBillDetailCommand.CanExecute(null))
                    {
                        homePageBll.SelectBillDetailCommand.Execute(dgvMonDaGoi.SelectedRows[0].DataBoundItem);

                        dgvMonDaGoi.ClearSelection();
                    }
                    btnChuanBi.Enabled = (dgvMonDaGoi.Rows.Count > 0);
                }
            }
        }

        private void btnChuanBi_Click(object sender, EventArgs e)
        {
            if (dgvMonDaGoi.Rows.Count > 0)
            {
                if (homePageBll != null)
                {
                    if (homePageBll.PrepareBillDetailsCommand.CanExecute(null))
                    {
                        homePageBll.PrepareBillDetailsCommand.Execute(null);
                        LoadBillDetail();
                        dgvMonDaGoi.ClearSelection();
                    }
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (homePageBll != null && homePageBll.BillOfTableSelected != null)
            {
                if (homePageBll.PayBillCommand.CanExecute(null))
                {
                    homePageBll.PayBillCommand.Execute(null);
                    homePageBll.OpenTableCommand.Execute(null);
                    LoadKhuVuc();
                    LoadBillDetail();
                }
            }
        }
        public ButtonX getBtnThanhToan()
        {
            return btnThanhToan;
        }

        public LabelX getlblTongtien()
        {
            return lblTongTien;
        }
        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            if (homePageBll.TableSelected != null)
            {
                if (homePageBll.ChangeTableCommand.CanExecute(null))
                {
                    homePageBll.ChangeTableCommand.Execute(null);
                }

            }
        }

        private void btnGopBan_Click(object sender, EventArgs e)
        {
            if (homePageBll.TableSelected != null)
            {
                //if (homePageBll.GroupTableCommand.CanExecute(null))
                {
                    homePageBll.GroupTableCommand.Execute(null);

                }
            }
        }

        private void btnTachBan_Click(object sender, EventArgs e)
        {
            if (homePageBll.TableSelected != null)
            {
                if (homePageBll.UnGroupTableCommand.CanExecute(null))
                {
                    homePageBll.UnGroupTableCommand.Execute(null);
                    LoadKhuVuc();
                }
            }
        }

        private void btnHuyMon_Click(object sender, EventArgs e)
        {
            if (homePageBll.DeleteBillDetailCommand.CanExecute(null))
            {
                homePageBll.DeleteBillDetailCommand.Execute(null);
                LoadBillDetail();
                dgvMonDaGoi.ClearSelection();
            }
        }
    }
}
