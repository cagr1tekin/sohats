using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SOHATS
{
    public partial class frmPoliklinik : Form
    {
        public frmPoliklinik()
        {
            InitializeComponent();
        }

        private void frmPoliklinik_Load(object sender, EventArgs e)
        {
            PoliklinikleriYukle();
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void PoliklinikleriYukle()
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT poliklinikadi FROM poliklinik ORDER BY poliklinikadi", conn);
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
                    MessageBox.Show("Poliklinik listesi yüklenemedi: " + ex.Message);
                }
            }
        }

        private void cmbPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPoliklinik.SelectedIndex >= 0)
            {
                string seciliPoliklinik = cmbPoliklinik.SelectedItem.ToString();
                PoliklinikBilgisiGetir(seciliPoliklinik);
            }
        }

        private void PoliklinikBilgisiGetir(string poliklinikAd)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM poliklinik WHERE poliklinikadi = @ad";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", poliklinikAd);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                txtPoliklinikAd.Text = dr["poliklinikadi"].ToString();
                                txtAciklama.Text = dr["aciklama"].ToString();
                                string durum = dr["durum"].ToString();
                                chkGecerli.Checked = (durum == "Geçerli");
                                
                                btnGuncelle.Enabled = true;
                                btnSil.Enabled = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPoliklinikAd.Text))
            {
                MessageBox.Show("Lütfen bir poliklinik seçiniz.");
                return;
            }

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE poliklinik SET durum = @durum, aciklama = @aciklama WHERE poliklinikadi = @ad";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", txtPoliklinikAd.Text.Trim());
                        cmd.Parameters.AddWithValue("@durum", chkGecerli.Checked ? "Geçerli" : "Geçersiz");
                        cmd.Parameters.AddWithValue("@aciklama", txtAciklama.Text.Trim());
                        
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Poliklinik güncellendi.");
                        PoliklinikleriYukle();
                        Temizle();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme Hatası: " + ex.Message);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPoliklinikAd.Text))
            {
                MessageBox.Show("Lütfen bir poliklinik seçiniz.");
                return;
            }

            DialogResult res = MessageBox.Show("Bu polikliniği silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM poliklinik WHERE poliklinikadi = @ad";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ad", txtPoliklinikAd.Text.Trim());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Poliklinik silindi.");
                            PoliklinikleriYukle();
                            Temizle();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme Hatası: " + ex.Message);
                    }
                }
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Temizle()
        {
            cmbPoliklinik.SelectedIndex = -1;
            txtPoliklinikAd.Clear();
            txtAciklama.Clear();
            chkGecerli.Checked = false;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }
    }
}
