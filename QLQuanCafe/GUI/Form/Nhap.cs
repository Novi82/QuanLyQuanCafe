using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QLQuanCafe.GUI.Form
{
    public partial class Nhap : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Nhap()
        {
            InitializeComponent();
        }

        private void Nhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeemanagementDataSet3.ctbaocaokho' table. You can move, or remove it, as needed.
            this.ctbaocaokhoTableAdapter.Fill(this.coffeemanagementDataSet3.ctbaocaokho);

            this.reportViewer1.RefreshReport();
        }
    }
}