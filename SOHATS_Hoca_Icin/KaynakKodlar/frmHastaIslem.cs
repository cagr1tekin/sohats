using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SOHATS
{
    public partial class frmHastaIslem : Form
    {
        private string _dosyaNo = "";
        private PrintDocument printDocument;

        public frmHastaIslem()
        {
            InitializeComponent();
            printDocument = new PrintDocument();
            printDocument.PrintPage += Pd_PrintPage;
        }

        private void frmHastaIslem_Load(object sender, EventArgs e)
        {
            PoliklinikleriYukle();
            IslemleriYukle();
            DoktorKodlariniYukle();
            dtpSevkTarihi.Value = DateTime.Now;
            Temizle();
        }

        private void PoliklinikleriYukle()
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT poliklinikadi FROM poliklinik WHERE durum = 'Geçerli' ORDER BY poliklinikadi", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    cmbPoliklinik.Items.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        cmbPoliklinik.Items.Add(dr["poliklinikadi"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Poliklinikler yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void IslemleriYukle()
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT islemAdi, birimFiyat FROM islem ORDER BY islemAdi", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    cmbYapilanIslem.Items.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        cmbYapilanIslem.Items.Add(dr["islemAdi"].ToString());
                    }
                    
                    // İşlem seçildiğinde birim fiyatı otomatik doldur
                    cmbYapilanIslem.SelectedIndexChanged += CmbYapilanIslem_SelectedIndexChanged;
                }
                catch
                {
                    // Eğer islem tablosu yoksa varsayılan değerler
                    cmbYapilanIslem.Items.Add("Muayene");
                    cmbYapilanIslem.Items.Add("Kan Tahlili");
                    cmbYapilanIslem.Items.Add("Röntgen");
                    cmbYapilanIslem.Items.Add("EKG");
                    cmbYapilanIslem.SelectedIndexChanged += CmbYapilanIslem_SelectedIndexChanged;
                }
            }
        }

        private void CmbYapilanIslem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYapilanIslem.SelectedItem != null)
            {
                string islemAdi = cmbYapilanIslem.SelectedItem.ToString();
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("SELECT birimFiyat FROM islem WHERE islemAdi = @islem", conn);
                        cmd.Parameters.AddWithValue("@islem", islemAdi);
                        object result = cmd.ExecuteScalar();
                        
                        if (result != null && result != DBNull.Value)
                        {
                            txtBirimFiyat.Text = result.ToString();
                        }
                    }
                    catch
                    {
                        // Hata durumunda varsayılan fiyatlar
                        switch (islemAdi)
                        {
                            case "Muayene":
                                txtBirimFiyat.Text = "100";
                                break;
                            case "Kan Tahlili":
                                txtBirimFiyat.Text = "50";
                                break;
                            case "Röntgen":
                                txtBirimFiyat.Text = "75";
                                break;
                            case "EKG":
                                txtBirimFiyat.Text = "80";
                                break;
                        }
                    }
                }
            }
        }

        private void DoktorKodlariniYukle()
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT kodu, ad + ' ' + soyad AS adsoyad FROM kullanici WHERE yetki = 'admin' OR unvan LIKE '%Doktor%' ORDER BY ad", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    cmbDrKodu.Items.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        cmbDrKodu.Items.Add(dr["kodu"].ToString() + " - " + dr["adsoyad"].ToString());
                    }
                }
                catch
                {
                    // Hata durumunda boş bırak
                }
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            frmDosyaBul frm = new frmDosyaBul();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtDosyaNo.Text = frm.SecilenDosyaNo;
                HastaBilgileriniGetir(txtDosyaNo.Text);
                OncekiIslemleriGetir(txtDosyaNo.Text);
            }
        }

        private void txtDosyaNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HastaBilgileriniGetir(txtDosyaNo.Text);
                OncekiIslemleriGetir(txtDosyaNo.Text);
            }
        }

        private void HastaBilgileriniGetir(string dosyaNo)
        {
            if (string.IsNullOrEmpty(dosyaNo))
                return;

            _dosyaNo = dosyaNo;
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
                            txtHastaAdi.Text = dr["ad"] != DBNull.Value ? dr["ad"].ToString() : "";
                            txtSoyadi.Text = dr["soyad"] != DBNull.Value ? dr["soyad"].ToString() : "";
                            txtKurumAdi.Text = dr["kurumadi"] != DBNull.Value ? dr["kurumadi"].ToString() : "";
                        }
                        else
                        {
                            MessageBox.Show("Hasta bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TemizleHasta();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OncekiIslemleriGetir(string dosyaNo)
        {
            if (string.IsNullOrEmpty(dosyaNo))
                return;

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT 
                        poliklinik AS [POLİKLİNİK],
                        sira AS [SIRA NO],
                        saat AS [SAAT],
                        yapilanislem AS [YAPILAN İŞLEM],
                        drkod AS [DR.KODU],
                        miktar AS [MİKTAR],
                        birimfiyat AS [BİRİM FİYATI]
                        FROM sevk 
                        WHERE dosyano = @no AND taburcu = 'Hayır' 
                        ORDER BY sira";
                    
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@no", dosyaNo);
                    
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    dgvIslemler.DataSource = dt;
                    ToplamTutarHesapla(dt);
                    
                    // Sıra no belirle (Mevcut kayıt sayısı + 1)
                    if (dt.Rows.Count > 0)
                    {
                        int maxSira = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            if (row["SIRA NO"] != DBNull.Value && int.TryParse(row["SIRA NO"].ToString(), out int sira))
                            {
                                if (sira > maxSira) maxSira = sira;
                            }
                        }
                        txtSiraNo.Text = (maxSira + 1).ToString();
                    }
                    else
                    {
                        txtSiraNo.Text = "1";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İşlemler yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ToplamTutarHesapla(DataTable dt)
        {
            decimal toplam = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["MİKTAR"] != DBNull.Value && dr["BİRİM FİYATI"] != DBNull.Value)
                {
                    if (int.TryParse(dr["MİKTAR"].ToString(), out int miktar) &&
                        decimal.TryParse(dr["BİRİM FİYATI"].ToString(), out decimal birimFiyat))
                    {
                        toplam += miktar * birimFiyat;
                    }
                }
            }
            lblToplamTutar.Text = toplam.ToString("N2") + " YTL";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDosyaNo.Text))
            {
                MessageBox.Show("Lütfen önce hasta dosya numarasını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ÖNCE HASTA KONTROLÜ YAP
            string dosyaNo = txtDosyaNo.Text.Trim();
            bool hastaVarMi = false;
            
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM hasta WHERE dosyano = @no", conn);
                    checkCmd.Parameters.AddWithValue("@no", dosyaNo);
                    hastaVarMi = (int)checkCmd.ExecuteScalar() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hasta kontrolü yapılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!hastaVarMi)
            {
                DialogResult result = MessageBox.Show(
                    $"Dosya No '{dosyaNo}' ile kayıtlı hasta bulunamadı.\n\n" +
                    "Sevk eklemek için önce hasta kaydı oluşturulmalıdır.\n\n" +
                    "Devam etmek istiyor musunuz? (Sevk kaydedilir ancak hasta bilgileri görünmez)",
                    "Hasta Bulunamadı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return; // Sevk ekleme işlemini durdur
                }
                // Evet derse devam et, ama uyarı ver
            }

            if (string.IsNullOrEmpty(cmbPoliklinik.Text) || string.IsNullOrEmpty(cmbYapilanIslem.Text))
            {
                MessageBox.Show("Lütfen poliklinik ve yapılan işlemi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtBirimFiyat.Text) || !decimal.TryParse(txtBirimFiyat.Text, out decimal birimFiyat))
            {
                MessageBox.Show("Lütfen geçerli bir birim fiyat giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO sevk (sevktarihi, dosyano, poliklinik, saat, yapilanislem, drkod, miktar, birimfiyat, sira, toplamtutar, taburcu) 
                                   VALUES (@tarih, @dosya, @poly, @saat, @islem, @dr, @miktar, @fiyat, @sira, @toplam, @taburcu)";
                    
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tarih", dtpSevkTarihi.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@dosya", dosyaNo);
                    cmd.Parameters.AddWithValue("@poly", cmbPoliklinik.Text);
                    cmd.Parameters.AddWithValue("@saat", DateTime.Now.ToShortTimeString());
                    cmd.Parameters.AddWithValue("@islem", cmbYapilanIslem.Text);
                    
                    string drKod = "";
                    if (!string.IsNullOrEmpty(cmbDrKodu.Text))
                    {
                        // "KOD - AD SOYAD" formatından sadece kodu al
                        if (cmbDrKodu.Text.Contains(" - "))
                            drKod = cmbDrKodu.Text.Split(new[] { " - " }, StringSplitOptions.None)[0];
                        else
                            drKod = cmbDrKodu.Text;
                    }
                    cmd.Parameters.AddWithValue("@dr", drKod);
                    
                    int miktar = (int)nudMiktar.Value;
                    birimFiyat = decimal.Parse(txtBirimFiyat.Text);
                    decimal toplamTutar = miktar * birimFiyat;

                    cmd.Parameters.AddWithValue("@miktar", miktar.ToString());
                    cmd.Parameters.AddWithValue("@fiyat", birimFiyat.ToString());
                    cmd.Parameters.AddWithValue("@sira", txtSiraNo.Text);
                    cmd.Parameters.AddWithValue("@toplam", toplamTutar.ToString());
                    cmd.Parameters.AddWithValue("@taburcu", "Hayır");

                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("İşlem başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Listeyi yenile
                    OncekiIslemleriGetir(dosyaNo);
                    
                    // Eğer hasta yoksa, hasta bilgilerini de yükle (varsa)
                    if (!hastaVarMi)
                    {
                        HastaBilgileriniGetir(dosyaNo);
                    }
                    
                    // Formu temizle (sadece işlem alanları)
                    cmbPoliklinik.SelectedIndex = -1;
                    cmbYapilanIslem.SelectedIndex = -1;
                    cmbDrKodu.SelectedIndex = -1;
                    nudMiktar.Value = 1;
                    txtBirimFiyat.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ekleme Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTaburcu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDosyaNo.Text))
            {
                MessageBox.Show("Lütfen hasta dosya numarasını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult res = MessageBox.Show("Hastayı taburcu etmek istiyor musunuz?", "Taburcu Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE sevk SET taburcu = 'Evet' WHERE dosyano = @no AND taburcu = 'Hayır'";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@no", txtDosyaNo.Text);
                        cmd.ExecuteNonQuery();
                        
                        MessageBox.Show("Hasta taburcu edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                        dgvIslemler.DataSource = null;
                        lblToplamTutar.Text = "0 YTL";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void btnBaskiOnizleme_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = printDocument;
            ppd.ShowDialog();
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font baslikFont = new Font("Arial", 14, FontStyle.Bold);
            Font icerikFont = new Font("Arial", 10);
            Font toplamFont = new Font("Arial", 12, FontStyle.Bold);
            
            int y = 50;
            e.Graphics.DrawString("SOHATS - Hasta İşlem Fişi", baslikFont, Brushes.Black, 100, y);
            y += 40;
            
            e.Graphics.DrawString("Dosya No: " + txtDosyaNo.Text, icerikFont, Brushes.Black, 50, y);
            y += 25;
            e.Graphics.DrawString("Hasta Adı: " + txtHastaAdi.Text + " " + txtSoyadi.Text, icerikFont, Brushes.Black, 50, y);
            y += 25;
            e.Graphics.DrawString("Sevk Tarihi: " + dtpSevkTarihi.Value.ToShortDateString(), icerikFont, Brushes.Black, 50, y);
            y += 40;
            
            // Grid başlıkları
            e.Graphics.DrawString("POLİKLİNİK", icerikFont, Brushes.Black, 50, y);
            e.Graphics.DrawString("SIRA NO", icerikFont, Brushes.Black, 200, y);
            e.Graphics.DrawString("İŞLEM", icerikFont, Brushes.Black, 300, y);
            e.Graphics.DrawString("MİKTAR", icerikFont, Brushes.Black, 450, y);
            e.Graphics.DrawString("FİYAT", icerikFont, Brushes.Black, 550, y);
            y += 25;
            
            // Grid verileri
            if (dgvIslemler.DataSource != null)
            {
                DataTable dt = (DataTable)dgvIslemler.DataSource;
                foreach (DataRow row in dt.Rows)
                {
                    e.Graphics.DrawString(row["POLİKLİNİK"].ToString(), icerikFont, Brushes.Black, 50, y);
                    e.Graphics.DrawString(row["SIRA NO"].ToString(), icerikFont, Brushes.Black, 200, y);
                    e.Graphics.DrawString(row["YAPILAN İŞLEM"].ToString(), icerikFont, Brushes.Black, 300, y);
                    e.Graphics.DrawString(row["MİKTAR"].ToString(), icerikFont, Brushes.Black, 450, y);
                    e.Graphics.DrawString(row["BİRİM FİYATI"].ToString(), icerikFont, Brushes.Black, 550, y);
                    y += 20;
                }
            }
            
            y += 20;
            e.Graphics.DrawString("Toplam Tutar: " + lblToplamTutar.Text, toplamFont, Brushes.Black, 50, y);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            // Hasta Bilgileri formunu aç (yeni hasta ekleme)
            frmHastaBilgileri frm = new frmHastaBilgileri();
            if (frm.ShowDialog() == DialogResult.OK || frm.DialogResult == DialogResult.OK)
            {
                // Hasta eklendiyse, dosya no'yu al ve hasta bilgilerini yükle
                string yeniDosyaNo = frm.DosyaNo;
                if (!string.IsNullOrEmpty(yeniDosyaNo))
                {
                    txtDosyaNo.Text = yeniDosyaNo;
                    HastaBilgileriniGetir(yeniDosyaNo);
                    OncekiIslemleriGetir(yeniDosyaNo);
                }
            }
        }

        private void btnSecSil_Click(object sender, EventArgs e)
        {
            if (dgvIslemler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz işlemi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult res = MessageBox.Show("Seçili işlemi silmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                DataGridViewRow selectedRow = dgvIslemler.SelectedRows[0];
                string siraNo = selectedRow.Cells["SIRA NO"].Value?.ToString();
                string dosyaNo = txtDosyaNo.Text;

                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM sevk WHERE dosyano = @dosya AND sira = @sira";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@dosya", dosyaNo);
                        cmd.Parameters.AddWithValue("@sira", siraNo);
                        cmd.ExecuteNonQuery();
                        
                        MessageBox.Show("İşlem silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OncekiIslemleriGetir(dosyaNo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnGit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOncekiIslemler.Text))
            {
                MessageBox.Show("Lütfen bir sıra numarası giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Grid'de belirtilen sıra numarasına git
            foreach (DataGridViewRow row in dgvIslemler.Rows)
            {
                if (row.Cells["SIRA NO"].Value?.ToString() == txtOncekiIslemler.Text)
                {
                    row.Selected = true;
                    dgvIslemler.FirstDisplayedScrollingRowIndex = row.Index;
                    return;
                }
            }
            MessageBox.Show("Belirtilen sıra numarası bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnHastaBilgileri_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDosyaNo.Text))
            {
                MessageBox.Show("Lütfen önce hasta dosya numarasını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // Hasta Bilgileri formunu aç (mevcut hasta düzenleme)
            frmHastaBilgileri frm = new frmHastaBilgileri(txtDosyaNo.Text);
            if (frm.ShowDialog() == DialogResult.OK || frm.DialogResult == DialogResult.OK)
            {
                // Hasta güncellendiyse, bilgileri yeniden yükle
                HastaBilgileriniGetir(txtDosyaNo.Text);
                OncekiIslemleriGetir(txtDosyaNo.Text);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Temizle()
        {
            txtDosyaNo.Clear();
            TemizleHasta();
            dgvIslemler.DataSource = null;
            lblToplamTutar.Text = "0 YTL";
            dtpSevkTarihi.Value = DateTime.Now;
            txtSiraNo.Clear();
            txtOncekiIslemler.Clear();
        }

        private void TemizleHasta()
        {
            _dosyaNo = "";
            txtHastaAdi.Clear();
            txtSoyadi.Clear();
            txtKurumAdi.Clear();
            cmbPoliklinik.SelectedIndex = -1;
            cmbYapilanIslem.SelectedIndex = -1;
            cmbDrKodu.SelectedIndex = -1;
            nudMiktar.Value = 1;
            txtBirimFiyat.Clear();
        }
    }
}
