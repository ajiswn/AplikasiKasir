namespace AplikasiKasir.GUI
{
    partial class Menu_Utama
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Utama));
            menuStrip = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            submenuLogin = new ToolStripMenuItem();
            submenuLogout = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            submenuKeluar = new ToolStripMenuItem();
            menuMasterData = new ToolStripMenuItem();
            submenuBarang = new ToolStripMenuItem();
            submenuPelanggan = new ToolStripMenuItem();
            menuTransaksi = new ToolStripMenuItem();
            submenuPenjualan = new ToolStripMenuItem();
            menuPengaturan = new ToolStripMenuItem();
            submenuUbahPassword = new ToolStripMenuItem();
            submenuTambahPengguna = new ToolStripMenuItem();
            menuTentang = new ToolStripMenuItem();
            submenuInfo = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            toolbarBarang = new ToolStripButton();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            laporanToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuFile, menuMasterData, menuTransaksi, menuPengaturan, menuTentang });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 3, 0, 3);
            menuStrip.Size = new Size(843, 30);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { submenuLogin, submenuLogout, toolStripMenuItem1, submenuKeluar });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(46, 24);
            menuFile.Text = "&File";
            // 
            // submenuLogin
            // 
            submenuLogin.Name = "submenuLogin";
            submenuLogin.ShortcutKeys = Keys.Control | Keys.L;
            submenuLogin.Size = new Size(243, 26);
            submenuLogin.Text = "&Login";
            submenuLogin.Click += submenuLogin_Click_1;
            // 
            // submenuLogout
            // 
            submenuLogout.Name = "submenuLogout";
            submenuLogout.Size = new Size(243, 26);
            submenuLogout.Text = "&Logout";
            submenuLogout.Click += submenuLogout_Click_1;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(240, 6);
            // 
            // submenuKeluar
            // 
            submenuKeluar.Name = "submenuKeluar";
            submenuKeluar.ShortcutKeys = Keys.Alt | Keys.F4;
            submenuKeluar.Size = new Size(243, 26);
            submenuKeluar.Text = "Keluar Aplikasi";
            submenuKeluar.Click += submenuKeluar_Click_1;
            // 
            // menuMasterData
            // 
            menuMasterData.DropDownItems.AddRange(new ToolStripItem[] { submenuBarang, submenuPelanggan });
            menuMasterData.Enabled = false;
            menuMasterData.Name = "menuMasterData";
            menuMasterData.Size = new Size(104, 24);
            menuMasterData.Text = "&Master Data";
            // 
            // submenuBarang
            // 
            submenuBarang.Name = "submenuBarang";
            submenuBarang.Size = new Size(161, 26);
            submenuBarang.Text = "&Barang";
            submenuBarang.Click += submenuBarang_Click_1;
            // 
            // submenuPelanggan
            // 
            submenuPelanggan.Name = "submenuPelanggan";
            submenuPelanggan.Size = new Size(161, 26);
            submenuPelanggan.Text = "&Pelanggan";
            // 
            // menuTransaksi
            // 
            menuTransaksi.DropDownItems.AddRange(new ToolStripItem[] { submenuPenjualan });
            menuTransaksi.Enabled = false;
            menuTransaksi.Name = "menuTransaksi";
            menuTransaksi.Size = new Size(82, 24);
            menuTransaksi.Text = "&Transaksi";
            // 
            // submenuPenjualan
            // 
            submenuPenjualan.Name = "submenuPenjualan";
            submenuPenjualan.Size = new Size(155, 26);
            submenuPenjualan.Text = "&Penjualan";
            // 
            // menuPengaturan
            // 
            menuPengaturan.DropDownItems.AddRange(new ToolStripItem[] { submenuUbahPassword, submenuTambahPengguna });
            menuPengaturan.Enabled = false;
            menuPengaturan.Name = "menuPengaturan";
            menuPengaturan.Size = new Size(97, 24);
            menuPengaturan.Text = "&Pengaturan";
            // 
            // submenuUbahPassword
            // 
            submenuUbahPassword.Name = "submenuUbahPassword";
            submenuUbahPassword.Size = new Size(213, 26);
            submenuUbahPassword.Text = "Ubah Password";
            // 
            // submenuTambahPengguna
            // 
            submenuTambahPengguna.Name = "submenuTambahPengguna";
            submenuTambahPengguna.Size = new Size(213, 26);
            submenuTambahPengguna.Text = "Tambah Pengguna";
            // 
            // menuTentang
            // 
            menuTentang.DropDownItems.AddRange(new ToolStripItem[] { submenuInfo });
            menuTentang.Name = "menuTentang";
            menuTentang.Size = new Size(76, 24);
            menuTentang.Text = "&Tentang";
            // 
            // submenuInfo
            // 
            submenuInfo.Name = "submenuInfo";
            submenuInfo.Size = new Size(118, 26);
            submenuInfo.Text = "Info";
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolbarBarang });
            toolStrip.Location = new Point(0, 30);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(843, 27);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "ToolStrip";
            // 
            // toolbarBarang
            // 
            toolbarBarang.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolbarBarang.Enabled = false;
            toolbarBarang.Image = (Image)resources.GetObject("toolbarBarang.Image");
            toolbarBarang.ImageTransparentColor = Color.Magenta;
            toolbarBarang.Name = "toolbarBarang";
            toolbarBarang.Size = new Size(29, 24);
            toolbarBarang.ToolTipText = "Data Barang";
            toolbarBarang.Click += toolbarBarang_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 671);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 19, 0);
            statusStrip.Size = new Size(843, 26);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(128, 20);
            toolStripStatusLabel.Text = "Created by Ajiswn";
            // 
            // laporanToolStripMenuItem
            // 
            laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            laporanToolStripMenuItem.Size = new Size(224, 26);
            laporanToolStripMenuItem.Text = "&Laporan";
            // 
            // Menu_Utama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(843, 697);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Menu_Utama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":: Aplikasi Kasir ::";
            WindowState = FormWindowState.Maximized;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        public ToolStripMenuItem menuFile;
        public ToolStripMenuItem menuMasterData;
        public ToolStripMenuItem submenuLogin;
        public ToolStripMenuItem submenuLogout;
        public ToolStripMenuItem menuTransaksi;
        public ToolStripMenuItem menuPengaturan;
        public ToolStripMenuItem menuTentang;
        private ToolStripSeparator toolStripMenuItem1;
        public ToolStripMenuItem submenuKeluar;
        public ToolStripMenuItem submenuBarang;
        public ToolStripMenuItem submenuPelanggan;
        public ToolStripMenuItem submenuPenjualan;
        public ToolStripMenuItem submenuUbahPassword;
        public ToolStripMenuItem submenuTambahPengguna;
        public ToolStripMenuItem submenuInfo;
        private ToolStripMenuItem laporanToolStripMenuItem;
        public ToolStripButton toolbarBarang;
    }
}



