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
using DevComponents.DotNetBar.Rendering;
using QLQuanCafe.DTO;
using QLQuanCafe.BLL;
namespace QLQuanCafe.GUI.UserControl
{
    public partial class TabKhuVuc : System.Windows.Forms.UserControl
    {
        private List<AreaData> listArea = new List<AreaData>();
        private HomePageBll homePageBll = LocatorBll.HomePageVM;
        public SuperTabControl TctKhuVuc
        {
            set { tctKhuVuc = value; }
            get { return tctKhuVuc; }
        }
        
  
        public TabKhuVuc()
        {
            InitializeComponent();
        }

        public TabKhuVuc(List<AreaData> list) : this()
        {
            listArea = list;
//            LoadArea();
        }

        public void LoadArea()
        {
//            LoadArea(listArea);
        }
        public void LoadArea(List<AreaData> _list)
        {
            tctKhuVuc.Tabs.Clear();
            foreach (AreaData area in _list)
            {
                SuperTabItem areaTabItem = new SuperTabItem();
                areaTabItem.Text = area.AreaName;

                SuperTabControlPanel panel = new SuperTabControlPanel();
                   

                // list view init
                ListViewEx listview = new ListViewEx();
                listview.BackColor = System.Drawing.Color.White;
                listview.Dock=DockStyle.Fill;
                listview.LargeImageList = tableImage;
                listview.SelectedIndexChanged += listview_SelectedIndexChanged;
                LocatorBll.AreaAndTableVM.SelectAreaCommand.Execute(area);
                
                List<TableData> listtable = LocatorBll.AreaAndTableVM.ListTable;

                foreach (TableData tableData in listtable)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = tableData.TableName;
                    item.ImageKey = "OpenTable";
                    item.Tag = tableData;
                    listview.Items.Add(item);
                   
                }

                // tab panel config
                panel.Controls.Add(listview);
                panel.Dock = System.Windows.Forms.DockStyle.Fill;
//                panel.Location = new System.Drawing.Point(0, 33);
                panel.Name = area.AreaId;
                panel.Size = new System.Drawing.Size(600, 800);
//              panel.TabIndex = 0;

                tctKhuVuc.Controls.Add(panel);       
                areaTabItem.AttachedControl = panel;

                tctKhuVuc.Tabs.Add(areaTabItem);
                

            }
        }

        void listview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (homePageBll != null)
            {
                if (homePageBll.SelectTableCommand.CanExecute(null))
                {
                    ListViewEx listView = sender as ListViewEx;
                    if(listView.SelectedItems.Count>0)
                        homePageBll.SelectTableCommand.Execute(listView.SelectedItems[0].Tag);

//                    ListViewMenuItem.SelectedItem = null;
                }
            }
        }

        private void TabKhuVuc_Load(object sender, EventArgs e)
        {
//            LoadArea(LocatorBll.AreaAndTableVM.ListArea);
        }



        
    }
}
