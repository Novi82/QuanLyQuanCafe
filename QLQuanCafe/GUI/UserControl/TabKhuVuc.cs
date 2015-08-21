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
using QLQuanCafe.DTO;
using QLQuanCafe.BLL;
namespace QLQuanCafe.GUI.UserControl
{
    public partial class TabKhuVuc : System.Windows.Forms.UserControl
    {
        private List<AreaData> listArea = new List<AreaData>();
        public TabKhuVuc()
        {
            InitializeComponent();
        }

        public TabKhuVuc(List<AreaData> list) : this()
        {
            listArea = list;
            Load();
        }

        public void Load()
        {
            tctKhuVuc.Tabs.Clear();
            foreach (AreaData area in listArea)
            {
                SuperTabItem areaTabItem = new SuperTabItem();
                areaTabItem.Text = area.AreaName;
               
                tctKhuVuc.Tabs.Add(areaTabItem);


            }
        }
        public void Load(List<AreaData> _list)
        {
            tctKhuVuc.Tabs.Clear();
            foreach (AreaData area in _list)
            {
                SuperTabItem areaTabItem = new SuperTabItem();
                areaTabItem.Text = area.AreaName;

                tctKhuVuc.Tabs.Add(areaTabItem);


            }
        }
    }
}
