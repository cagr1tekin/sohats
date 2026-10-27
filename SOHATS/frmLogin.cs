using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SOHATS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        // "Giriş" butonu tıklama olayı
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kAd = txtKullaniciAd.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(kAd) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    // SQL Injection'a karşı parametreli sorgu kullanıyoruz
                    string query = "SELECT yetki FROM kullanici WHERE username = @kAd AND sifre = @sifre";
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kAd", kAd);
                        cmd.Parameters.AddWithValue("@sifre", sifre);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string yetki = result.ToString();
                            
                            // Giriş başarılı, Ana Formu aç
                            frmAna anaForm = new frmAna();
                            anaForm.KullaniciYetkisi = yetki; // Yetkiyi ana forma gönderiyoruz
                            anaForm.Show();
                            
                            // Login formunu gizle
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // "Temizle" butonu tıklama olayı
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKullaniciAd.Clear();
            txtSifre.Clear();
            txtKullaniciAd.Focus();
        }

        // "Çıkış" butonu tıklama olayı
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
