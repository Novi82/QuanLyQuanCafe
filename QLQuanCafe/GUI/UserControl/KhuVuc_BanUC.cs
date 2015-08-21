using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLQuanCafe.BLL;

namespace QLQuanCafe.GUI.UserControl
{
    public partial class KhuVuc_BanUC : System.Windows.Forms.UserControl
    {
        private AreaAndTableBll areaAndTableBll = LocatorBll.AreaAndTableVM;
        public KhuVuc_BanUC()
        {
            InitializeComponent();
        }

        private void KhuVuc_BanUC_Load(object sender, EventArgs e)
        {
          
        }

        public void LoadKhuVuc()
        {
            tabKhuVuc1.LoadArea(areaAndTableBll.ListArea);
        }
    }
}
