using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SOHATS
{
    public partial class frmKullanici : Form
    {
        private string _secilenKullaniciKodu = "";

        public frmKullanici()
        {
            InitializeComponent();
        }

        private void frmKullanici_Load(object sender, EventArgs e)
        {
            KullaniciKodlariniYukle();
            Temizle();
        }

        private void KullaniciKodlariniYukle()
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT kodu FROM kullanici ORDER BY kodu", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    cmbKullaniciKodu.Items.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        cmbKullaniciKodu.Items.Add(dr["kodu"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcı kodları yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbKullaniciKodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKullaniciKodu.SelectedItem != null)
            {
                _secilenKullaniciKodu = cmbKullaniciKodu.SelectedItem.ToString();
                KullaniciBilgileriniGetir(_secilenKullaniciKodu);
            }
            else if (!string.IsNullOrEmpty(cmbKullaniciKodu.Text))
            {
                // Kullanıcı manuel olarak kod yazdıysa
                _secilenKullaniciKodu = cmbKullaniciKodu.Text.Trim();
                // Eğer bu kod listede yoksa, yeni kullanıcı demektir
                if (!cmbKullaniciKodu.Items.Contains(_secilenKullaniciKodu))
                {
                    // Yeni kullanıcı, formu temizle
                    Temizle();
                    cmbKullaniciKodu.Text = _secilenKullaniciKodu;
                }
                else
                {
                    // Mevcut kullanıcı, bilgileri yükle
                    KullaniciBilgileriniGetir(_secilenKullaniciKodu);
                }
            }
        }

        private void KullaniciBilgileriniGetir(string kodu)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM kullanici WHERE kodu = @kodu";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kodu", kodu);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                txtTcKimlikNo.Text = dr["tcKimlikno"] != DBNull.Value ? dr["tcKimlikno"].ToString() : "";
                                txtDogumYeri.Text = dr["dogumyeri"] != DBNull.Value ? dr["dogumyeri"].ToString() : "";
                                txtBabaAdi.Text = dr["babadi"] != DBNull.Value ? dr["babadi"].ToString() : "";
                                txtAnneAdi.Text = dr["anneadi"] != DBNull.Value ? dr["anneadi"].ToString() : "";
                                txtTelefon.Text = ""; // tel kolonu yok, ceptel var
                                txtGSM.Text = dr["ceptel"] != DBNull.Value ? dr["ceptel"].ToString() : "";
                                
                                cmbUnvan.Text = dr["unvan"] != DBNull.Value ? dr["unvan"].ToString() : "";
                                txtAdi.Text = dr["ad"] != DBNull.Value ? dr["ad"].ToString() : "";
                                txtSoyadi.Text = dr["soyad"] != DBNull.Value ? dr["soyad"].ToString() : "";
                                txtMaas.Text = dr["maas"] != DBNull.Value ? dr["maas"].ToString() : "";
                                
                                if (dr["isebaslama"] != DBNull.Value)
                                    dtpIseBaslama.Value = Convert.ToDateTime(dr["isebaslama"]);
                                
                                if (dr["dogumtarihi"] != DBNull.Value)
                                    dtpDogumTarihi.Value = Convert.ToDateTime(dr["dogumtarihi"]);
                                
                                cmbCinsiyet.Text = dr["cinsiyet"] != DBNull.Value ? dr["cinsiyet"].ToString() : "";
                                cmbMedeniHal.Text = dr["medenihal"] != DBNull.Value ? dr["medenihal"].ToString() : "";
                                cmbKanGrubu.Text = dr["kangubu"] != DBNull.Value ? dr["kangubu"].ToString() : "";
                                
                                txtAdres.Text = dr["adres"] != DBNull.Value ? dr["adres"].ToString() : "";
                                txtKullaniciAdi.Text = dr["username"] != DBNull.Value ? dr["username"].ToString() : "";
                                txtSifre.Text = dr["sifre"] != DBNull.Value ? dr["sifre"].ToString() : "";
                                
                                // Yetki kontrolü
                                string yetki = dr["yetki"] != DBNull.Value ? dr["yetki"].ToString() : "";
                                chkYetkiliKullanici.Checked = (yetki == "admin");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcı bilgileri yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnYeniKullanici_Click(object sender, EventArgs e)
        {
            Temizle();
            // Yeni kullanıcı kodu üret ve combo box'a ekle
            string yeniKod = YeniKullaniciKoduUret();
            if (!cmbKullaniciKodu.Items.Contains(yeniKod))
            {
                cmbKullaniciKodu.Items.Add(yeniKod);
            }
            cmbKullaniciKodu.Text = yeniKod;
            _secilenKullaniciKodu = ""; // Yeni kullanıcı olduğunu belirt
            
            // Kullanıcıya bilgi ver
            MessageBox.Show($"Yeni kullanıcı kodu: {yeniKod}\n\nLütfen bilgileri doldurup 'Güncelle' butonuna basın.", "Yeni Kullanıcı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string YeniKullaniciKoduUret()
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    // Tüm kodları al ve sayısal olanların maksimumunu bul
                    SqlCommand cmd = new SqlCommand("SELECT kodu FROM kullanici", conn);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        int maxKod = 0;
                        while (dr.Read())
                        {
                            string kod = dr["kodu"].ToString();
                            // Sayısal olup olmadığını kontrol et
                            if (int.TryParse(kod, out int kodSayi))
                            {
                                if (kodSayi > maxKod)
                                    maxKod = kodSayi;
                            }
                        }
                        return (maxKod + 1).ToString();
                    }
                }
                catch
                {
                    // Hata durumunda timestamp kullan
                    return DateTime.Now.Ticks.ToString().Substring(0, 10);
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            cmbKullaniciKodu.SelectedIndex = -1;
            cmbKullaniciKodu.Text = "";
            _secilenKullaniciKodu = "";
            txtTcKimlikNo.Clear();
            txtDogumYeri.Clear();
            txtBabaAdi.Clear();
            txtAnneAdi.Clear();
            txtTelefon.Clear();
            txtGSM.Clear();
            cmbUnvan.SelectedIndex = -1;
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtMaas.Clear();
            dtpIseBaslama.Value = DateTime.Now;
            dtpDogumTarihi.Value = DateTime.Now;
            cmbCinsiyet.SelectedIndex = -1;
            cmbMedeniHal.SelectedIndex = -1;
            cmbKanGrubu.SelectedIndex = -1;
            chkYetkiliKullanici.Checked = false;
            txtAdres.Clear();
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbKullaniciKodu.Text))
            {
                MessageBox.Show("Lütfen bir kullanıcı kodu seçiniz veya giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Kullanıcı adı ve şifre zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kodu = cmbKullaniciKodu.Text.Trim();
            string yetki = chkYetkiliKullanici.Checked ? "admin" : "pers";

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    
                    // Önce kullanıcının var olup olmadığını kontrol et
                    bool kullaniciVarMi = false;
                    string checkQuery = "SELECT COUNT(*) FROM kullanici WHERE kodu = @kodu";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@kodu", kodu);
                        kullaniciVarMi = (int)checkCmd.ExecuteScalar() > 0;
                    }

                    if (kullaniciVarMi)
                    {
                        // Güncelle
                        string query = @"UPDATE kullanici SET 
                            ad = @ad, soyad = @soyad, sifre = @sifre, yetki = @yetki,
                            ceptel = @ceptel, adres = @adres, unvan = @unvan,
                            isebaslama = @isebaslama, maas = @maas,
                            dogumyeri = @dogumyeri, anneadi = @anneadi, babadi = @babadi,
                            cinsiyet = @cinsiyet, kangubu = @kangubu, medenihal = @medenihal,
                            dogumtarihi = @dogumtarihi, tcKimlikno = @tcKimlikno, username = @username
                            WHERE kodu = @kodu";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            ParametreleriEkle(cmd, kodu, yetki);
                            int affected = cmd.ExecuteNonQuery();
                            if (affected > 0)
                            {
                                MessageBox.Show("Kullanıcı başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                KullaniciKodlariniYukle();
                            }
                        }
                    }
                    else
                    {
                        // Yeni ekle
                        string query = @"INSERT INTO kullanici (kodu, ad, soyad, sifre, yetki, ceptel, adres, unvan,
                            isebaslama, maas, dogumyeri, anneadi, babadi, cinsiyet, kangubu, medenihal,
                            dogumtarihi, tcKimlikno, username)
                            VALUES (@kodu, @ad, @soyad, @sifre, @yetki, @ceptel, @adres, @unvan,
                            @isebaslama, @maas, @dogumyeri, @anneadi, @babadi, @cinsiyet, @kangubu, @medenihal,
                            @dogumtarihi, @tcKimlikno, @username)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            ParametreleriEkle(cmd, kodu, yetki);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Yeni kullanıcı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            KullaniciKodlariniYukle();
                            cmbKullaniciKodu.Text = kodu;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İşlem Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ParametreleriEkle(SqlCommand cmd, string kodu, string yetki)
        {
            cmd.Parameters.AddWithValue("@kodu", kodu);
            cmd.Parameters.AddWithValue("@ad", txtAdi.Text.Trim());
            cmd.Parameters.AddWithValue("@soyad", txtSoyadi.Text.Trim());
            cmd.Parameters.AddWithValue("@sifre", txtSifre.Text.Trim());
            cmd.Parameters.AddWithValue("@yetki", yetki);
            cmd.Parameters.AddWithValue("@ceptel", txtGSM.Text.Trim());
            cmd.Parameters.AddWithValue("@adres", txtAdres.Text.Trim());
            cmd.Parameters.AddWithValue("@unvan", cmbUnvan.Text);
            cmd.Parameters.AddWithValue("@isebaslama", dtpIseBaslama.Value);
            cmd.Parameters.AddWithValue("@maas", txtMaas.Text.Trim());
            cmd.Parameters.AddWithValue("@dogumyeri", txtDogumYeri.Text.Trim());
            cmd.Parameters.AddWithValue("@anneadi", txtAnneAdi.Text.Trim());
            cmd.Parameters.AddWithValue("@babadi", txtBabaAdi.Text.Trim());
            cmd.Parameters.AddWithValue("@cinsiyet", cmbCinsiyet.Text);
            cmd.Parameters.AddWithValue("@kangubu", cmbKanGrubu.Text);
            cmd.Parameters.AddWithValue("@medenihal", cmbMedeniHal.Text);
            cmd.Parameters.AddWithValue("@dogumtarihi", dtpDogumTarihi.Value);
            cmd.Parameters.AddWithValue("@tcKimlikno", txtTcKimlikNo.Text.Trim());
            cmd.Parameters.AddWithValue("@username", txtKullaniciAdi.Text.Trim());
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbKullaniciKodu.Text))
            {
                MessageBox.Show("Lütfen silinecek kullanıcı kodunu seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult res = MessageBox.Show("Bu kullanıcıyı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM kullanici WHERE kodu = @kodu";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@kodu", cmbKullaniciKodu.Text.Trim());
                            int affected = cmd.ExecuteNonQuery();
                            
                            if (affected > 0)
                            {
                                MessageBox.Show("Kullanıcı başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                KullaniciKodlariniYukle();
                                Temizle();
                            }
                            else
                            {
                                MessageBox.Show("Silme işlemi başarısız. Kullanıcı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
