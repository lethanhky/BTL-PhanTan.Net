namespace GUI
{
    partial class frmMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelParent = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TrangChuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LapHoaDonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLNVMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLSPMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TKMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.PanelParent);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 404);
            this.panel1.TabIndex = 0;
            // 
            // PanelParent
            // 
            this.PanelParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelParent.Location = new System.Drawing.Point(0, 36);
            this.PanelParent.Name = "PanelParent";
            this.PanelParent.Size = new System.Drawing.Size(750, 368);
            this.PanelParent.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 36);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 27);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrangChuMenuItem,
            this.LapHoaDonMenuItem,
            this.QLNVMenuItem,
            this.QLSPMenuItem,
            this.TKMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "MenuTrip";
            // 
            // TrangChuMenuItem
            // 
            this.TrangChuMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.TrangChuMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrangChuMenuItem.ForeColor = System.Drawing.Color.Black;
            this.TrangChuMenuItem.Name = "TrangChuMenuItem";
            this.TrangChuMenuItem.Size = new System.Drawing.Size(91, 24);
            this.TrangChuMenuItem.Text = "Trang Chủ";
            this.TrangChuMenuItem.Click += new System.EventHandler(this.TrangChuMenuItem_Click);
            // 
            // LapHoaDonMenuItem
            // 
            this.LapHoaDonMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.LapHoaDonMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LapHoaDonMenuItem.ForeColor = System.Drawing.Color.Black;
            this.LapHoaDonMenuItem.Name = "LapHoaDonMenuItem";
            this.LapHoaDonMenuItem.Size = new System.Drawing.Size(110, 24);
            this.LapHoaDonMenuItem.Text = "Lập Hoá Đơn";
            this.LapHoaDonMenuItem.Click += new System.EventHandler(this.LapHoaDonMenuItem_Click);
            // 
            // QLNVMenuItem
            // 
            this.QLNVMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.QLNVMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLNVMenuItem.ForeColor = System.Drawing.Color.Black;
            this.QLNVMenuItem.Name = "QLNVMenuItem";
            this.QLNVMenuItem.Size = new System.Drawing.Size(154, 24);
            this.QLNVMenuItem.Text = "Quản Lý Nhân Viên";
            this.QLNVMenuItem.Click += new System.EventHandler(this.QLNVMenuItem_Click);
            // 
            // QLSPMenuItem
            // 
            this.QLSPMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.QLSPMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLSPMenuItem.ForeColor = System.Drawing.Color.Black;
            this.QLSPMenuItem.Name = "QLSPMenuItem";
            this.QLSPMenuItem.Size = new System.Drawing.Size(149, 24);
            this.QLSPMenuItem.Text = "Quản Lý Sản Phẩm";
            this.QLSPMenuItem.Click += new System.EventHandler(this.QLSPMenuItem_Click);
            // 
            // TKMenuItem
            // 
            this.TKMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.TKMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TKMenuItem.ForeColor = System.Drawing.Color.Black;
            this.TKMenuItem.Name = "TKMenuItem";
            this.TKMenuItem.Size = new System.Drawing.Size(86, 24);
            this.TKMenuItem.Text = "Thống Kê";
            this.TKMenuItem.Click += new System.EventHandler(this.TKMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 404);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Điện Thoại Di Động";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelParent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem TrangChuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LapHoaDonMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLNVMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLSPMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TKMenuItem;
    }
}

