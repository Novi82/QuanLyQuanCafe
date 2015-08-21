namespace QLQuanCafe.GUI.UserControl
{
    partial class TabKhuVuc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tctKhuVuc = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.listViewEx1 = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            ((System.ComponentModel.ISupportInitialize)(this.tctKhuVuc)).BeginInit();
            this.tctKhuVuc.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctKhuVuc
            // 
            this.tctKhuVuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tctKhuVuc.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.tctKhuVuc.ControlBox.MenuBox.Name = "";
            this.tctKhuVuc.ControlBox.Name = "";
            this.tctKhuVuc.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tctKhuVuc.ControlBox.MenuBox,
            this.tctKhuVuc.ControlBox.CloseBox});
            this.tctKhuVuc.Controls.Add(this.superTabControlPanel1);
            this.tctKhuVuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctKhuVuc.ForeColor = System.Drawing.Color.Black;
            this.tctKhuVuc.Location = new System.Drawing.Point(0, 0);
            this.tctKhuVuc.Name = "tctKhuVuc";
            this.tctKhuVuc.ReorderTabsEnabled = true;
            this.tctKhuVuc.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tctKhuVuc.SelectedTabIndex = 2;
            this.tctKhuVuc.ShowFocusRectangle = true;
            this.tctKhuVuc.Size = new System.Drawing.Size(348, 434);
            this.tctKhuVuc.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tctKhuVuc.TabIndex = 29;
            this.tctKhuVuc.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1});
            this.tctKhuVuc.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.OfficeMobile2014;
            this.tctKhuVuc.Text = "superTabControl1";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.listViewEx1);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 33);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(348, 401);
            this.superTabControlPanel1.TabIndex = 0;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // listViewEx1
            // 
            this.listViewEx1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.listViewEx1.Border.Class = "ListViewBorder";
            this.listViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listViewEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.listViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewEx1.ForeColor = System.Drawing.Color.Black;
            this.listViewEx1.Location = new System.Drawing.Point(0, 0);
            this.listViewEx1.Name = "listViewEx1";
            this.listViewEx1.Size = new System.Drawing.Size(348, 401);
            this.listViewEx1.TabIndex = 0;
            this.listViewEx1.UseCompatibleStateImageBehavior = false;
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "superTabItem1";
            // 
            // TabKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tctKhuVuc);
            this.Name = "TabKhuVuc";
            this.Size = new System.Drawing.Size(348, 434);
            ((System.ComponentModel.ISupportInitialize)(this.tctKhuVuc)).EndInit();
            this.tctKhuVuc.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabControl tctKhuVuc;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.Controls.ListViewEx listViewEx1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
    }
}
