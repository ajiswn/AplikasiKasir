using AplikasiKasir.Kelas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiKasir.GUI
{
    public partial class Form_Barang : Form
    {
        private enum Status { Insert, Update }
        private Status currentStatus;

        private void resetTombol()
        {
            textBoxKodeBarang.Enabled = false;
            textBoxNamaBarang.Enabled = false;
            textBoxHargaBarang.Enabled = false;
            textBoxStok.Enabled = false;
            comboBoxSatuan.Enabled = false;
            buttonSimpan.Enabled = false;
            buttonHapus.Enabled = false;
            buttonUbah.Enabled = false;

            textBoxKodeBarang.Text = string.Empty;
            textBoxNamaBarang.Text = string.Empty;
            textBoxHargaBarang.Text = string.Empty;
            textBoxStok.Text = string.Empty;
            comboBoxSatuan.Text = string.Empty;
            textBoxSearch.Text = string.Empty;
        }
        public Form_Barang()
        {
            InitializeComponent();
            resetTombol();
            loadBarang();
        }

        private void Form_Barang_Load(object sender, EventArgs e)
        {
            loadBarang();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (currentStatus == Status.Insert)
            {
                Barangs barangInsert = new Barangs(textBoxKodeBarang.Text, textBoxNamaBarang.Text,
                    Convert.ToInt32(textBoxHargaBarang.Text), Convert.ToInt16(textBoxStok.Text), comboBoxSatuan.Text);
                if (barangInsert.insert() == 1)
                {
                    MessageBox.Show("Insert barang " + textBoxNamaBarang.Text + " berhasil");
                }
                else
                {
                    MessageBox.Show("Insert barang " + textBoxNamaBarang.Text + " gagal");
                }
            }
            else if (currentStatus == Status.Update)
            {
                Barangs barangUpdate = new Barangs(textBoxKodeBarang.Text, textBoxNamaBarang.Text,
                    Convert.ToInt32(textBoxHargaBarang.Text), Convert.ToInt16(textBoxStok.Text), comboBoxSatuan.Text);
                if (barangUpdate.update() == 1)
                {
                    MessageBox.Show("Update barang " + textBoxNamaBarang.Text + " berhasil");
                }
                else
                {
                    MessageBox.Show("Update barang " + textBoxNamaBarang.Text + " gagal");
                }
            }
            loadBarang();
            resetTombol();
        }

        //button Baru
        private void buttonBaru_Click(object sender, EventArgs e)
        {
            resetTombol();
            textBoxKodeBarang.Enabled = true;
            textBoxNamaBarang.Enabled = true;
            textBoxHargaBarang.Enabled = true;
            textBoxStok.Enabled = true;
            comboBoxSatuan.Enabled = true;

            buttonSimpan.Enabled = true;
            currentStatus = Status.Insert;
        }

        private void loadBarang()
        {
            DataTable dt = new DataTable();
            dt = Barangs.SelectAll();
            dgvDataBarang.AutoGenerateColumns = false;
            dgvDataBarang.DataSource = dt;
            dgvDataBarang.Show();
        }

        private void dgvDataBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            resetTombol();
            if (dgvDataBarang.Rows[e.RowIndex].Cells[0].Value != null)
            {
                textBoxKodeBarang.Text = dgvDataBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxNamaBarang.Text = dgvDataBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxHargaBarang.Text = dgvDataBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxStok.Text = dgvDataBarang.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboBoxSatuan.Text = dgvDataBarang.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
 
            buttonUbah.Enabled = true;
            buttonHapus.Enabled = true;
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            textBoxNamaBarang.Enabled = true;
            textBoxHargaBarang.Enabled = true;
            textBoxStok.Enabled = true;
            comboBoxSatuan.Enabled = true;
            buttonSimpan.Enabled = true;
            currentStatus = Status.Update;
            buttonHapus.Enabled = false;
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Barangs.search(textBoxSearch.Text);
            dgvDataBarang.AutoGenerateColumns = false;
            dgvDataBarang.DataSource = dt;
            dgvDataBarang.Show();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin ingin menghapus barang " + textBoxNamaBarang.Text + "?", "Konfirmasi Hapus", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Barangs barang = new Barangs(textBoxKodeBarang.Text, "", 0, 0, "");
                if (barang.delete(textBoxKodeBarang.Text) == 1)
                {
                    MessageBox.Show("Hapus barang " + textBoxNamaBarang.Text + " berhasil");
                }
                else
                {
                    MessageBox.Show("Hapus barang " + textBoxNamaBarang.Text + " gagal");
                }
                loadBarang();
                resetTombol();
            }
        }
    }
}
