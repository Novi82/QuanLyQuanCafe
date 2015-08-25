using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuanCafe.GUI.Dialog
{
    public partial class ThongTin : DevComponents.DotNetBar.Metro.MetroForm
    {
        public ThongTin()
        {
            InitializeComponent();
        }

        public ThongTin(String message):this()
        {
            
            lblMessage.Text = message.Trim();

        }
        private void labelX1_Click(object sender, EventArgs e)
        {

        }
    }
}
