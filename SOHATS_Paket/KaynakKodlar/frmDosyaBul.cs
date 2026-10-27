using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SOHATS
{
    public partial class frmDosyaBul : Form
    {
        // Seçilen dosya numarasını ana forma (veya çağıran forma) döndürmek için property
        public string SecilenDosyaNo { get; private set; }

        public frmDosyaBul()
        {
            InitializeComponent();
        }

        private void frmDosyaBul_Load(object sender, EventArgs e)
        {
            // Varsayılan olarak "Kimlik No" seçili olsun
            if (cmbAramaKriteri.Items.Count > 0)
            {
                cmbAramaKriteri.SelectedIndex = 0;
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (cmbAramaKriteri.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir arama kriteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kriter = txtAramaKriteri.Text.Trim();
            if (string.IsNullOrEmpty(kriter))
            {
                MessageBox.Show("Lütfen arama değeri giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string secilenKriter = cmbAramaKriteri.SelectedItem.ToString();
            string query = "";
            string whereClause = "";

            switch (secilenKriter)
            {
                case "Kimlik No":
                    whereClause = "tcKimlikNo LIKE @kriter";
                    break;
                case "Ad":
                    whereClause = "ad LIKE @kriter";
                    break;
                case "Soyad":
                    whereClause = "soyad LIKE @kriter";
                    break;
                case "Dosya No":
                    whereClause = "dosyano LIKE @kriter";
                    break;
                default:
                    whereClause = "tcKimlikNo LIKE @kriter OR ad LIKE @kriter OR soyad LIKE @kriter OR dosyano LIKE @kriter";
                    break;
            }

            query = "SELECT dosyano, ad, soyad, tcKimlikNo, kurumadi FROM hasta WHERE " + whereClause;

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@kriter", "%" + kriter + "%");
                    
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    dgvSonuclar.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Arama kriterinize uygun kayıt bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Arama Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // DataGridView'de bir satıra çift tıklandığında seçimi yapıp formu kapatalım
        private void dgvSonuclar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Seçilen satırdaki dosyaNo'yu al
                SecilenDosyaNo = dgvSonuclar.Rows[e.RowIndex].Cells["dosyano"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
