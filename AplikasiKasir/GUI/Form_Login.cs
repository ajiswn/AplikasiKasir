using AplikasiKasir.Kelas;
using AplikasiKasir.GUI;
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
    public partial class Form_Login : Form
    {
        private Menu_Utama mainForm;

        public Form_Login()
        {
            InitializeComponent();
        }
        public Form_Login(Menu_Utama callingForm)
        {
            mainForm = callingForm;
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //1. mengecek apakah username dan password benar
            //jika benar, tampil pesan login berhasil, aktifkan menu dan tutup form login
            Users user = new Users(textBox_username.Text, textBox_password.Text);
            if (user.getUser())
            {
                MessageBox.Show("Login berhasil");
                mainForm.loginProcess();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login gagal");
                textBox_username.Text = string.Empty;
                textBox_password.Text = string.Empty;
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
