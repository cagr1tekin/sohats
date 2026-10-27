using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SOHATS
{
    public partial class frmRapor : Form
    {
        public frmRapor()
        {
            InitializeComponent();
        }

        private void frmRapor_Load(object sender, EventArgs e)
        {
            PoliklinikleriYukle();
            dtpBaslangic.Value = DateTime.Now.AddDays(-30);
            dtpBitis.Value = DateTime.Now;
        }

        private void PoliklinikleriYukle()
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT poliklinikadi FROM poliklinik", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    cmbPoliklinik.Items.Clear();
                    cmbPoliklinik.Items.Add("Tümü");
                    foreach (DataRow dr in dt.Rows)
                    {
                        cmbPoliklinik.Items.Add(dr["poliklinikadi"].ToString());
                    }
                    cmbPoliklinik.SelectedIndex = 0;
                }
                catch { }
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string baslangic = dtpBaslangic.Value.ToString("yyyy-MM-dd");
            string bitis = dtpBitis.Value.ToString("yyyy-MM-dd");
            string poliklinik = cmbPoliklinik.Text;

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT s.sevktarihi AS [Tarih], s.dosyano AS [Dosya No], 
                               h.ad + ' ' + h.soyad AS [Hasta Adı], 
                               s.poliklinik AS [Poliklinik], 
                               s.yapilanislem AS [İşlem], 
                               s.toplamtutar AS [Tutar]
                        FROM sevk s
                        LEFT JOIN hasta h ON s.dosyano = h.dosyano
                        WHERE s.sevktarihi BETWEEN @baslangic AND @bitis";

                    if (poliklinik != "Tümü")
                    {
                        query += " AND s.poliklinik = @poliklinik";
                    }
                    
                    query += " ORDER BY s.sevktarihi DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@baslangic", baslangic);
                    da.SelectCommand.Parameters.AddWithValue("@bitis", bitis);
                    if (poliklinik != "Tümü")
                    {
                        da.SelectCommand.Parameters.AddWithValue("@poliklinik", poliklinik);
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    dgvRapor.DataSource = dt;
                    
                    // Toplam hesapla
                    decimal toplam = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["Tutar"] != DBNull.Value && !string.IsNullOrEmpty(dr["Tutar"].ToString()))
                        {
                            decimal tutar = 0;
                            if (decimal.TryParse(dr["Tutar"].ToString(), out tutar))
                            {
                                toplam += tutar;
                            }
                        }
                    }
                    lblToplamTutar.Text = "Toplam: " + toplam.ToString("N2") + " TL";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Rapor Hatası: " + ex.Message);
                }
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += Pd_PrintPage;
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font baslikFont = new Font("Arial", 14, FontStyle.Bold);
            Font icerikFont = new Font("Arial", 10);
            
            e.Graphics.DrawString("SOHATS - Gelir Raporu", baslikFont, Brushes.Black, 100, 50);
            e.Graphics.DrawString("Tarih Aralığı: " + dtpBaslangic.Value.ToShortDateString() + " - " + dtpBitis.Value.ToShortDateString(), 
                                  icerikFont, Brushes.Black, 50, 100);
            e.Graphics.DrawString("Poliklinik: " + cmbPoliklinik.Text, icerikFont, Brushes.Black, 50, 120);
            e.Graphics.DrawString(lblToplamTutar.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 150);
        }
    }
}
