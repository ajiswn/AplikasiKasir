﻿namespace AplikasiKasir.GUI
{
    partial class Form_Barang
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
            groupBox1 = new GroupBox();
            comboBoxSatuan = new ComboBox();
            label5 = new Label();
            textBoxStok = new TextBox();
            label4 = new Label();
            textBoxHargaBarang = new TextBox();
            label3 = new Label();
            textBoxNamaBarang = new TextBox();
            label2 = new Label();
            textBoxKodeBarang = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonHapus = new Button();
            buttonUbah = new Button();
            buttonSimpan = new Button();
            buttonBaru = new Button();
            groupBox3 = new GroupBox();
            dgvDataBarang = new DataGridView();
            kode_barang = new DataGridViewTextBoxColumn();
            nama_barang = new DataGridViewTextBoxColumn();
            harga_barang = new DataGridViewTextBoxColumn();
            stok = new DataGridViewTextBoxColumn();
            satuan = new DataGridViewTextBoxColumn();
            buttonCari = new Button();
            textBoxSearch = new TextBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataBarang).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxSatuan);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxStok);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxHargaBarang);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxNamaBarang);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxKodeBarang);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(20, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 320);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = ":: Form Barang ::";
            // 
            // comboBoxSatuan
            // 
            comboBoxSatuan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxSatuan.FormattingEnabled = true;
            comboBoxSatuan.Items.AddRange(new object[] { "pcs", "box" });
            comboBoxSatuan.Location = new Point(180, 250);
            comboBoxSatuan.Name = "comboBoxSatuan";
            comboBoxSatuan.Size = new Size(310, 36);
            comboBoxSatuan.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 250);
            label5.Name = "label5";
            label5.Size = new Size(74, 28);
            label5.TabIndex = 9;
            label5.Text = "Satuan";
            // 
            // textBoxStok
            // 
            textBoxStok.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBoxStok.Location = new Point(180, 200);
            textBoxStok.Name = "textBoxStok";
            textBoxStok.Size = new Size(310, 34);
            textBoxStok.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 200);
            label4.Name = "label4";
            label4.Size = new Size(52, 28);
            label4.TabIndex = 7;
            label4.Text = "Stok";
            // 
            // textBoxHargaBarang
            // 
            textBoxHargaBarang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBoxHargaBarang.Location = new Point(180, 150);
            textBoxHargaBarang.Name = "textBoxHargaBarang";
            textBoxHargaBarang.Size = new Size(310, 34);
            textBoxHargaBarang.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 150);
            label3.Name = "label3";
            label3.Size = new Size(135, 28);
            label3.TabIndex = 5;
            label3.Text = "Harga Barang";
            // 
            // textBoxNamaBarang
            // 
            textBoxNamaBarang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBoxNamaBarang.Location = new Point(180, 100);
            textBoxNamaBarang.Name = "textBoxNamaBarang";
            textBoxNamaBarang.Size = new Size(310, 34);
            textBoxNamaBarang.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 100);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 3;
            label2.Text = "Nama Barang";
            // 
            // textBoxKodeBarang
            // 
            textBoxKodeBarang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBoxKodeBarang.Location = new Point(180, 50);
            textBoxKodeBarang.Name = "textBoxKodeBarang";
            textBoxKodeBarang.Size = new Size(310, 34);
            textBoxKodeBarang.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 50);
            label1.Name = "label1";
            label1.Size = new Size(128, 28);
            label1.TabIndex = 1;
            label1.Text = "Kode Barang";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonHapus);
            groupBox2.Controls.Add(buttonUbah);
            groupBox2.Controls.Add(buttonSimpan);
            groupBox2.Controls.Add(buttonBaru);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(20, 400);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(520, 215);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = ":: Proses ::";
            // 
            // buttonHapus
            // 
            buttonHapus.Location = new Point(270, 130);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(225, 60);
            buttonHapus.TabIndex = 3;
            buttonHapus.Text = "Hapus";
            buttonHapus.UseVisualStyleBackColor = true;
            buttonHapus.Click += buttonHapus_Click;
            // 
            // buttonUbah
            // 
            buttonUbah.Location = new Point(25, 130);
            buttonUbah.Name = "buttonUbah";
            buttonUbah.Size = new Size(225, 60);
            buttonUbah.TabIndex = 2;
            buttonUbah.Text = "Ubah";
            buttonUbah.UseVisualStyleBackColor = true;
            buttonUbah.Click += buttonUbah_Click;
            // 
            // buttonSimpan
            // 
            buttonSimpan.Location = new Point(270, 50);
            buttonSimpan.Name = "buttonSimpan";
            buttonSimpan.Size = new Size(225, 60);
            buttonSimpan.TabIndex = 1;
            buttonSimpan.Text = "Simpan";
            buttonSimpan.UseVisualStyleBackColor = true;
            buttonSimpan.Click += buttonSimpan_Click;
            // 
            // buttonBaru
            // 
            buttonBaru.Location = new Point(25, 50);
            buttonBaru.Name = "buttonBaru";
            buttonBaru.Size = new Size(225, 60);
            buttonBaru.TabIndex = 0;
            buttonBaru.Text = "Baru";
            buttonBaru.UseVisualStyleBackColor = true;
            buttonBaru.Click += buttonBaru_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvDataBarang);
            groupBox3.Controls.Add(buttonCari);
            groupBox3.Controls.Add(textBoxSearch);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(580, 40);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(880, 575);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = ":: Data Barang ::";
            // 
            // dgvDataBarang
            // 
            dgvDataBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataBarang.Columns.AddRange(new DataGridViewColumn[] { kode_barang, nama_barang, harga_barang, stok, satuan });
            dgvDataBarang.Location = new Point(25, 100);
            dgvDataBarang.Name = "dgvDataBarang";
            dgvDataBarang.RowHeadersWidth = 51;
            dgvDataBarang.Size = new Size(830, 450);
            dgvDataBarang.TabIndex = 5;
            dgvDataBarang.CellContentClick += dgvDataBarang_CellContentClick;
            // 
            // kode_barang
            // 
            kode_barang.DataPropertyName = "kode";
            kode_barang.HeaderText = "Kode";
            kode_barang.MinimumWidth = 6;
            kode_barang.Name = "kode_barang";
            kode_barang.Width = 125;
            // 
            // nama_barang
            // 
            nama_barang.DataPropertyName = "nama";
            nama_barang.HeaderText = "Nama Barang";
            nama_barang.MinimumWidth = 6;
            nama_barang.Name = "nama_barang";
            nama_barang.Width = 280;
            // 
            // harga_barang
            // 
            harga_barang.DataPropertyName = "harga";
            harga_barang.HeaderText = "Harga";
            harga_barang.MinimumWidth = 6;
            harga_barang.Name = "harga_barang";
            harga_barang.Width = 125;
            // 
            // stok
            // 
            stok.DataPropertyName = "stok";
            stok.HeaderText = "Stok";
            stok.MinimumWidth = 6;
            stok.Name = "stok";
            stok.Width = 125;
            // 
            // satuan
            // 
            satuan.DataPropertyName = "satuan";
            satuan.HeaderText = "Satuan";
            satuan.MinimumWidth = 6;
            satuan.Name = "satuan";
            satuan.Width = 125;
            // 
            // buttonCari
            // 
            buttonCari.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCari.Location = new Point(608, 50);
            buttonCari.Name = "buttonCari";
            buttonCari.Size = new Size(83, 34);
            buttonCari.TabIndex = 4;
            buttonCari.Text = "Cari";
            buttonCari.TextAlign = ContentAlignment.TopCenter;
            buttonCari.UseVisualStyleBackColor = true;
            buttonCari.Click += buttonCari_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBoxSearch.Location = new Point(278, 50);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(310, 34);
            textBoxSearch.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 50);
            label6.Name = "label6";
            label6.Size = new Size(243, 28);
            label6.TabIndex = 3;
            label6.Text = "Cari Barang (Kode/Nama)";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(241, 366);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // Form_Barang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 653);
            Controls.Add(dateTimePicker1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form_Barang";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form_Barang";
            Load += Form_Barang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataBarang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBoxKodeBarang;
        private TextBox textBoxHargaBarang;
        private Label label3;
        private TextBox textBoxNamaBarang;
        private Label label2;
        private ComboBox comboBoxSatuan;
        private Label label5;
        private TextBox textBoxStok;
        private Label label4;
        private GroupBox groupBox2;
        private Button buttonBaru;
        private Button buttonHapus;
        private Button buttonUbah;
        private Button buttonSimpan;
        private GroupBox groupBox3;
        private Button buttonCari;
        private TextBox textBoxSearch;
        private Label label6;
        private DataGridView dgvDataBarang;
        private DataGridViewTextBoxColumn kode_barang;
        private DataGridViewTextBoxColumn nama_barang;
        private DataGridViewTextBoxColumn harga_barang;
        private DataGridViewTextBoxColumn stok;
        private DataGridViewTextBoxColumn satuan;
        private DateTimePicker dateTimePicker1;
    }
}