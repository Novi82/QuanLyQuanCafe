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
    public partial class HoaDonUC : System.Windows.Forms.UserControl
    {
        public HoaDonUC()
        {
            InitializeComponent();
        }

        public void LoadHoaDonTrongNgay()
        {
            dgvHoaDon.DataSource = LocatorBll.HomePageVM.ListBillToday;
        }
    }
}
