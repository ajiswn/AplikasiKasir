using AplikasiKasir.GUI;
using System.Windows.Forms;

namespace AplikasiKasir.GUI
{
    public partial class Menu_Utama : Form
    {
        private int childFormNumber = 0;
        Form_Login frmLogin;
        Form_Barang frmBarang;

        protected override void OnResize(EventArgs e)
        {
            CenterForms();
            base.OnResize(e);
        }
        private void CenterForms()
        {
            foreach (var form in MdiChildren) //This will center all of the Child Forms
            {
                form.Left = (ClientRectangle.Width - form.Width) / 2;
                form.Top = (ClientRectangle.Height - form.Height) / 2;
            }
        }

        void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin = null;
        }

        void frmBarang_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmBarang = null;
        }

        bool _loginState;

        public Menu_Utama()
        {
            InitializeComponent();
            _loginState = false;
            toolStripStatusLabel.Text = "Not Login";
            submenuLogout.Enabled = false;
        }
        public void enableMenuMasterData()
        {
            menuMasterData.Enabled = true;
        }

        private void submenuLogin_Click_1(object sender, EventArgs e)
        {
            //menampilkan form login
            if (frmLogin == null)
            {
                //1. membuat objek dari form login
                frmLogin = new Form_Login(this);
                //2. mengkaitkan objek form login dengan MDI parent
                frmLogin.MdiParent = this;
                frmLogin.StartPosition = FormStartPosition.CenterParent;
                frmLogin.FormClosed += new FormClosedEventHandler(frmLogin_FormClosed);
                //3. menampilkan form login
                frmLogin.Show();
            }
            else
            {
                frmLogin.Activate();
            }
        }

        private void submenuLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                logoutProcess();
            }
        }

        private void logoutProcess()
        {
            _loginState = false;
            toolStripStatusLabel.Text = "Not Login";
            menuMasterData.Enabled = false;
            menuPengaturan.Enabled = false;
            menuTransaksi.Enabled = false;
            submenuLogin.Enabled = true;
            submenuLogout.Enabled = false;
            toolbarBarang.Enabled = false;
        }
        public void loginProcess()
        {
            _loginState = true;
            toolStripStatusLabel.Text = "Login";
            menuMasterData.Enabled = true;
            menuPengaturan.Enabled = true;
            menuTransaksi.Enabled = true;
            submenuLogout.Enabled = true;
            submenuLogin.Enabled = false;
            toolbarBarang.Enabled = true;
        }

        private void submenuKeluar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar Aplikasi", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void submenuBarang_Click_1(object sender, EventArgs e)
        {
            //menampilkan form barang
            if (frmBarang == null)
            {
                //1. membuat objek dari form barang
                frmBarang = new Form_Barang();
                //2. mengkaitkan objek form barang dengan MDI parent
                frmBarang.MdiParent = this;
                frmBarang.FormClosed += new FormClosedEventHandler(frmBarang_FormClosed);
                //3. menampilkan form login
                frmBarang.Show();
            }
            else
            {
                frmBarang.Activate();
            }
        }

        private void toolbarBarang_Click(object sender, EventArgs e)
        {
            //menampilkan form barang
            if (frmBarang == null)
            {
                //1. membuat objek dari form barang
                frmBarang = new Form_Barang();
                //2. mengkaitkan objek form barang dengan MDI parent
                frmBarang.MdiParent = this;
                frmBarang.FormClosed += new FormClosedEventHandler(frmBarang_FormClosed);
                //3. menampilkan form login
                frmBarang.Show();
            }
            else
            {
                frmBarang.Activate();
            }
        }
    }
}
