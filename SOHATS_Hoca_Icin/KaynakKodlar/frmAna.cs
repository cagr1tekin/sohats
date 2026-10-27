using System;
using System.Windows.Forms;

namespace SOHATS
{
    public partial class frmAna : Form
    {
        // Giriş yapan kullanıcının yetkisini tutacak özellik
        public string KullaniciYetkisi { get; set; }

        public frmAna()
        {
            InitializeComponent();
        }

        private void frmAna_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yetki kontrolü yap
            if (KullaniciYetkisi != "admin")
            {
                if (referanslarToolStripMenuItem != null)
                {
                    referanslarToolStripMenuItem.Visible = false;
                }
            }
            
            this.Text = "SOHATS - Ana Menü (Giriş Yapan: " + KullaniciYetkisi + ")";
        }

        private void frmAna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void poliklinikTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPoliklinik frm = new frmPoliklinik();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kullanıcıTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullanici frm = new frmKullanici();
            frm.MdiParent = this;
            frm.Show();
        }

        private void hastaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHastaIslem frm = new frmHastaIslem();
            frm.MdiParent = this;
            frm.Show();
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRapor frm = new frmRapor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
