using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using QLQuanCafe.BLL;
using QLQuanCafe.DTO;

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
                btnDatBan.Text = "Đặt Bàn";
            }
            else if ("CoNguoi".Equals(state))
            {
                btnMoBan.Enabled = false;
                btnHuyBan.Enabled = true;
                btnDatBan.Enabled = false;
                btnDatBan.Text = "Đặt Bàn";
            }
            else if ("DaDat".Equals(state))
            {
                btnMoBan.Enabled = false;
                btnHuyBan.Enabled = false;
                btnDatBan.Enabled = true;
                btnDatBan.Text = "Hủy Đặt";
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
                listview.BackColor = System.Drawing.Color.White;
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
                panel.Dock = System.Windows.Forms.DockStyle.Fill;
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
    }
}
