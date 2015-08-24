using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using QLQuanCafe.BLL;
using QLQuanCafe.DTO;

// ReSharper disable All

namespace QLQuanCafe.GUI.UserControl
{
    public partial class KhuVuc_BanUC : System.Windows.Forms.UserControl
    {
        private AreaAndTableBll areaAndTableBll = LocatorBll.AreaAndTableVM;
        private HomePageBll homePageBll = LocatorBll.HomePageVM;
        private ListViewItem currentItem = new ListViewItem();
        public KhuVuc_BanUC()
        {
            InitializeComponent();
            
        }

        private void KhuVuc_BanUC_Load(object sender, EventArgs e)
        {

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
            else if ("ChuaDon".Equals(state))
            {
                // bàn dã thanh toán nhưng chưa dọn

            }
        }
        public void LoadKhuVuc()
        {
            stcKhuVuc.Tabs.Clear();
            List<AreaData> _list = areaAndTableBll.ListArea;
            foreach (AreaData area in _list)
            {
                SuperTabItem areaTabItem = new SuperTabItem();
                areaTabItem.Text = area.AreaName;

                SuperTabControlPanel panel = new SuperTabControlPanel();

                // list view init
                ListViewEx listview = new ListViewEx();
                listview.BackColor = Color.White;
                listview.Dock = DockStyle.Fill;
                listview.LargeImageList = tableImage;
                listview.SelectedIndexChanged += listview_SelectedIndexChanged;
                LocatorBll.AreaAndTableVM.SelectAreaCommand.Execute(area);

                List<TableData> listtable = LocatorBll.AreaAndTableVM.ListTable;
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
                panel.Dock = DockStyle.Fill;
                //                panel.Location = new System.Drawing.Point(0, 33);
                panel.Name = area.AreaId;
                panel.Size = new System.Drawing.Size(600, 800);
                //              panel.TabIndex = 0;

                stcKhuVuc.Controls.Add(panel);
                areaTabItem.AttachedControl = panel;

                stcKhuVuc.Tabs.Add(areaTabItem);

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
                        //                    lblGioDen.Text = DateTime.Now.ToShortTimeString();
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
                    lblGioDen.Text = DateTime.Now.ToShortTimeString();
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
            lblTongTien.Text = homePageBll.BillOfTableSelected.TotalMoney.ToString();
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
                    LoadKhuVuc();
                    LoadBillDetail();             
                }
            }
        }
        public ButtonX getBtnThanhToan()
        {
            return  btnThanhToan;
        }
    }
}
