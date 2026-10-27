using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SOHATS
{
    public partial class frmHastaBilgileri : Form
    {
        private string _mevcutDosyaNo = "";
        private bool _yeniHasta = false;
        
        public string DosyaNo { get { return txtDosyaNo.Text.Trim(); } }

        public frmHastaBilgileri()
        {
            InitializeComponent();
        }

        public frmHastaBilgileri(string dosyaNo) : this()
        {
            _mevcutDosyaNo = dosyaNo;
            _yeniHasta = false;
        }

        private void frmHastaBilgileri_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_mevcutDosyaNo))
            {
                HastaBilgileriniYukle(_mevcutDosyaNo);
            }
            else
            {
                _yeniHasta = true;
                YeniDosyaNoUret();
            }
        }

        private void YeniDosyaNoUret()
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    // Tüm dosya numaralarını al ve sayısal olanların maksimumunu bul
                    SqlCommand cmd = new SqlCommand("SELECT dosyano FROM hasta", conn);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        int maxDosyaNo = 0;
                        while (dr.Read())
                        {
                            string dosyaNo = dr["dosyano"].ToString();
                            // Sayısal olup olmadığını kontrol et
                            if (int.TryParse(dosyaNo, out int dosyaNoSayi))
                            {
                                if (dosyaNoSayi > maxDosyaNo)
                                    maxDosyaNo = dosyaNoSayi;
                            }
                        }
                        txtDosyaNo.Text = (maxDosyaNo + 1).ToString("D5"); // 00001, 00002 formatında
                    }
                }
                catch
                {
                    // Hata durumunda varsayılan değer
                    txtDosyaNo.Text = "00001";
                }
            }
        }

        private void HastaBilgileriniYukle(string dosyaNo)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM hasta WHERE dosyano = @no", conn);
                    cmd.Parameters.AddWithValue("@no", dosyaNo);
                    
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtDosyaNo.Text = dr["dosyano"] != DBNull.Value ? dr["dosyano"].ToString() : "";
                            txtTcKimlikNo.Text = dr["tcKimlikNo"] != DBNull.Value ? dr["tcKimlikNo"].ToString() : "";
                            txtAd.Text = dr["ad"] != DBNull.Value ? dr["ad"].ToString() : "";
                            txtSoyadi.Text = dr["soyad"] != DBNull.Value ? dr["soyad"].ToString() : "";
                            txtDogumYeri.Text = dr["dogumyeri"] != DBNull.Value ? dr["dogumyeri"].ToString() : "";
                            
                            if (dr["dogumtarihi"] != DBNull.Value)
                                dtpDogumTarihi.Value = Convert.ToDateTime(dr["dogumtarihi"]);
                            
                            txtBabaAd.Text = dr["babadi"] != DBNull.Value ? dr["babadi"].ToString() : "";
                            txtAnneAd.Text = dr["anneadi"] != DBNull.Value ? dr["anneadi"].ToString() : "";
                            cmbCinsiyet.Text = dr["cinsiyet"] != DBNull.Value ? dr["cinsiyet"].ToString() : "";
                            cmbMedeniHal.Text = dr["medenihal"] != DBNull.Value ? dr["medenihal"].ToString() : "";
                            cmbKanGrubu.Text = dr["kangubu"] != DBNull.Value ? dr["kangubu"].ToString() : "";
                            txtAdres.Text = dr["adres"] != DBNull.Value ? dr["adres"].ToString() : "";
                            txtTelefon.Text = dr["tel"] != DBNull.Value ? dr["tel"].ToString() : "";
                            txtKurumSicilNo.Text = dr["kurumsicilno"] != DBNull.Value ? dr["kurumsicilno"].ToString() : "";
                            txtKurumAd.Text = dr["kurumadi"] != DBNull.Value ? dr["kurumadi"].ToString() : "";
                            txtYakinTelefon.Text = dr["yakintel"] != DBNull.Value ? dr["yakintel"].ToString() : "";
                            txtYakinKurumSicilNo.Text = dr["yakinkurumsicilno"] != DBNull.Value ? dr["yakinkurumsicilno"].ToString() : "";
                            txtYakinKurumAd.Text = dr["yakinkurumadi"] != DBNull.Value ? dr["yakinkurumadi"].ToString() : "";
                            
                            _yeniHasta = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hasta bilgileri yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Temizle();
            _yeniHasta = true;
            _mevcutDosyaNo = "";
            YeniDosyaNoUret();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Validasyon
            if (string.IsNullOrEmpty(txtDosyaNo.Text))
            {
                MessageBox.Show("Dosya No zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDosyaNo.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtTcKimlikNo.Text))
            {
                MessageBox.Show("T.C. Kimlik Numarası zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTcKimlikNo.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyadi.Text))
            {
                MessageBox.Show("Ad ve Soyad zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tcKimlikNo = txtTcKimlikNo.Text.Trim();
            string dosyaNo = txtDosyaNo.Text.Trim();

            // TC Kimlik No kontrolü (10 karakter olmalı)
            if (tcKimlikNo.Length > 10)
            {
                tcKimlikNo = tcKimlikNo.Substring(0, 10);
            }

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    
                    // Önce hasta var mı kontrol et
                    bool hastaVarMi = false;
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM hasta WHERE tcKimlikNo = @tc", conn);
                    checkCmd.Parameters.AddWithValue("@tc", tcKimlikNo);
                    hastaVarMi = (int)checkCmd.ExecuteScalar() > 0;

                    if (hastaVarMi && _yeniHasta)
                    {
                        // TC ile hasta var, yeni hasta eklenemez
                        SqlCommand dosyaCmd = new SqlCommand("SELECT dosyano, ad, soyad FROM hasta WHERE tcKimlikNo = @tc", conn);
                        dosyaCmd.Parameters.AddWithValue("@tc", tcKimlikNo);
                        using (SqlDataReader dr = dosyaCmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                string mevcutDosyaNo = dr["dosyano"].ToString();
                                string mevcutAd = dr["ad"].ToString();
                                string mevcutSoyad = dr["soyad"].ToString();
                                
                                MessageBox.Show(
                                    $"Bu T.C. Kimlik Numarası ile kayıtlı hasta bulundu!\n\n" +
                                    $"Dosya No: {mevcutDosyaNo}\n" +
                                    $"Ad Soyad: {mevcutAd} {mevcutSoyad}\n\n" +
                                    $"Aynı T.C. Kimlik No ile yeni hasta eklenemez. Lütfen mevcut hastayı düzenleyin.",
                                    "Uyarı",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    if (hastaVarMi && !_yeniHasta)
                    {
                        // Güncelle
                        string query = @"UPDATE hasta SET 
                            dosyano = @dosya, ad = @ad, soyad = @soyad, dogumyeri = @dogumyeri,
                            dogumtarihi = @dogumtarihi, babadi = @babadi, anneadi = @anneadi,
                            cinsiyet = @cinsiyet, kangubu = @kangubu, medenihal = @medenihal,
                            adres = @adres, tel = @tel, kurumsicilno = @kurumsicilno, kurumadi = @kurumadi,
                            yakintel = @yakintel, yakinkurumsicilno = @yakinkurumsicilno, yakinkurumadi = @yakinkurumadi
                            WHERE tcKimlikNo = @tc";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        ParametreleriEkle(cmd, tcKimlikNo, dosyaNo);
                        cmd.Parameters.AddWithValue("@tc", tcKimlikNo);
                        
                        int affected = cmd.ExecuteNonQuery();
                        if (affected > 0)
                        {
                            MessageBox.Show("Hasta bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _yeniHasta = false;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        // Yeni ekle
                        string query = @"INSERT INTO hasta (tcKimlikNo, dosyano, ad, soyad, dogumyeri, dogumtarihi, babadi, anneadi,
                            cinsiyet, kangubu, medenihal, adres, tel, kurumsicilno, kurumadi,
                            yakintel, yakinkurumsicilno, yakinkurumadi)
                            VALUES (@tc, @dosya, @ad, @soyad, @dogumyeri, @dogumtarihi, @babadi, @anneadi,
                            @cinsiyet, @kangubu, @medenihal, @adres, @tel, @kurumsicilno, @kurumadi,
                            @yakintel, @yakinkurumsicilno, @yakinkurumadi)";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        ParametreleriEkle(cmd, tcKimlikNo, dosyaNo);
                        cmd.Parameters.AddWithValue("@tc", tcKimlikNo);
                        
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Yeni hasta başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _yeniHasta = false;
                            _mevcutDosyaNo = dosyaNo;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Hasta eklenemedi. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    string hataMesaji = "Veritabanı Hatası: " + sqlEx.Message;
                    if (sqlEx.Number == 2627) // Primary key violation
                    {
                        hataMesaji += "\n\nBu T.C. Kimlik Numarası zaten kayıtlı!";
                    }
                    else if (sqlEx.Number == 515) // NULL value
                    {
                        hataMesaji += "\n\nZorunlu alanlar boş bırakılamaz!";
                    }
                    MessageBox.Show(hataMesaji, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt Hatası: " + ex.Message + "\n\nDetay: " + ex.StackTrace, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ParametreleriEkle(SqlCommand cmd, string tcKimlikNo, string dosyaNo)
        {
            cmd.Parameters.AddWithValue("@dosya", string.IsNullOrEmpty(dosyaNo) ? (object)DBNull.Value : dosyaNo);
            cmd.Parameters.AddWithValue("@ad", string.IsNullOrEmpty(txtAd.Text.Trim()) ? (object)DBNull.Value : txtAd.Text.Trim());
            cmd.Parameters.AddWithValue("@soyad", string.IsNullOrEmpty(txtSoyadi.Text.Trim()) ? (object)DBNull.Value : txtSoyadi.Text.Trim());
            cmd.Parameters.AddWithValue("@dogumyeri", string.IsNullOrEmpty(txtDogumYeri.Text.Trim()) ? (object)DBNull.Value : txtDogumYeri.Text.Trim());
            cmd.Parameters.AddWithValue("@dogumtarihi", dtpDogumTarihi.Value);
            cmd.Parameters.AddWithValue("@babadi", string.IsNullOrEmpty(txtBabaAd.Text.Trim()) ? (object)DBNull.Value : txtBabaAd.Text.Trim());
            cmd.Parameters.AddWithValue("@anneadi", string.IsNullOrEmpty(txtAnneAd.Text.Trim()) ? (object)DBNull.Value : txtAnneAd.Text.Trim());
            cmd.Parameters.AddWithValue("@cinsiyet", string.IsNullOrEmpty(cmbCinsiyet.Text) ? (object)DBNull.Value : cmbCinsiyet.Text);
            cmd.Parameters.AddWithValue("@kangubu", string.IsNullOrEmpty(cmbKanGrubu.Text) ? (object)DBNull.Value : cmbKanGrubu.Text);
            cmd.Parameters.AddWithValue("@medenihal", string.IsNullOrEmpty(cmbMedeniHal.Text) ? (object)DBNull.Value : cmbMedeniHal.Text);
            cmd.Parameters.AddWithValue("@adres", string.IsNullOrEmpty(txtAdres.Text.Trim()) ? (object)DBNull.Value : txtAdres.Text.Trim());
            cmd.Parameters.AddWithValue("@tel", string.IsNullOrEmpty(txtTelefon.Text.Trim()) ? (object)DBNull.Value : txtTelefon.Text.Trim());
            cmd.Parameters.AddWithValue("@kurumsicilno", string.IsNullOrEmpty(txtKurumSicilNo.Text.Trim()) ? (object)DBNull.Value : txtKurumSicilNo.Text.Trim());
            cmd.Parameters.AddWithValue("@kurumadi", string.IsNullOrEmpty(txtKurumAd.Text.Trim()) ? (object)DBNull.Value : txtKurumAd.Text.Trim());
            cmd.Parameters.AddWithValue("@yakintel", string.IsNullOrEmpty(txtYakinTelefon.Text.Trim()) ? (object)DBNull.Value : txtYakinTelefon.Text.Trim());
            cmd.Parameters.AddWithValue("@yakinkurumsicilno", string.IsNullOrEmpty(txtYakinKurumSicilNo.Text.Trim()) ? (object)DBNull.Value : txtYakinKurumSicilNo.Text.Trim());
            cmd.Parameters.AddWithValue("@yakinkurumadi", string.IsNullOrEmpty(txtYakinKurumAd.Text.Trim()) ? (object)DBNull.Value : txtYakinKurumAd.Text.Trim());
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Temizle()
        {
            txtDosyaNo.Clear();
            txtTcKimlikNo.Clear();
            txtAd.Clear();
            txtSoyadi.Clear();
            txtDogumYeri.Clear();
            dtpDogumTarihi.Value = DateTime.Now;
            txtBabaAd.Clear();
            txtAnneAd.Clear();
            cmbCinsiyet.SelectedIndex = -1;
            cmbMedeniHal.SelectedIndex = -1;
            cmbKanGrubu.SelectedIndex = -1;
            txtAdres.Clear();
            txtTelefon.Clear();
            txtKurumSicilNo.Clear();
            txtKurumAd.Clear();
            txtYakinTelefon.Clear();
            txtYakinKurumSicilNo.Clear();
            txtYakinKurumAd.Clear();
        }

    }
}

