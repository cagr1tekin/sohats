namespace SOHATS
{
    partial class frmHastaIslem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDosyaNo = new System.Windows.Forms.Label();
            this.txtDosyaNo = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.lblHastaAdi = new System.Windows.Forms.Label();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.lblSevkTarihi = new System.Windows.Forms.Label();
            this.dtpSevkTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.lblOncekiIslemler = new System.Windows.Forms.Label();
            this.txtOncekiIslemler = new System.Windows.Forms.TextBox();
            this.btnGit = new System.Windows.Forms.Button();
            this.lblKurumAdi = new System.Windows.Forms.Label();
            this.txtKurumAdi = new System.Windows.Forms.TextBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnHastaBilgileri = new System.Windows.Forms.Button();
            this.lblPoliklinik = new System.Windows.Forms.Label();
            this.cmbPoliklinik = new System.Windows.Forms.ComboBox();
            this.lblSiraNo = new System.Windows.Forms.Label();
            this.txtSiraNo = new System.Windows.Forms.TextBox();
            this.lblYapilanIslem = new System.Windows.Forms.Label();
            this.cmbYapilanIslem = new System.Windows.Forms.ComboBox();
            this.lblDrKodu = new System.Windows.Forms.Label();
            this.cmbDrKodu = new System.Windows.Forms.ComboBox();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.nudMiktar = new System.Windows.Forms.NumericUpDown();
            this.lblBirimFiyat = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblGridBaslik = new System.Windows.Forms.Label();
            this.dgvIslemler = new System.Windows.Forms.DataGridView();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnSecSil = new System.Windows.Forms.Button();
            this.btnTaburcu = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnBaskiOnizleme = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIslemler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDosyaNo
            // 
            this.lblDosyaNo.AutoSize = true;
            this.lblDosyaNo.Location = new System.Drawing.Point(20, 20);
            this.lblDosyaNo.Name = "lblDosyaNo";
            this.lblDosyaNo.Size = new System.Drawing.Size(72, 16);
            this.lblDosyaNo.TabIndex = 0;
            this.lblDosyaNo.Text = "Dosya No:";
            // 
            // txtDosyaNo
            // 
            this.txtDosyaNo.Location = new System.Drawing.Point(100, 17);
            this.txtDosyaNo.Name = "txtDosyaNo";
            this.txtDosyaNo.Size = new System.Drawing.Size(100, 22);
            this.txtDosyaNo.TabIndex = 1;
            this.txtDosyaNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDosyaNo_KeyDown);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(210, 15);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(60, 26);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // lblHastaAdi
            // 
            this.lblHastaAdi.AutoSize = true;
            this.lblHastaAdi.Location = new System.Drawing.Point(20, 55);
            this.lblHastaAdi.Name = "lblHastaAdi";
            this.lblHastaAdi.Size = new System.Drawing.Size(70, 16);
            this.lblHastaAdi.TabIndex = 3;
            this.lblHastaAdi.Text = "Hasta Adı:";
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Location = new System.Drawing.Point(100, 52);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.ReadOnly = true;
            this.txtHastaAdi.Size = new System.Drawing.Size(150, 22);
            this.txtHastaAdi.TabIndex = 4;
            // 
            // lblSevkTarihi
            // 
            this.lblSevkTarihi.AutoSize = true;
            this.lblSevkTarihi.Location = new System.Drawing.Point(280, 20);
            this.lblSevkTarihi.Name = "lblSevkTarihi";
            this.lblSevkTarihi.Size = new System.Drawing.Size(80, 16);
            this.lblSevkTarihi.TabIndex = 5;
            this.lblSevkTarihi.Text = "Sevk Tarihi:";
            // 
            // dtpSevkTarihi
            // 
            this.dtpSevkTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSevkTarihi.Location = new System.Drawing.Point(370, 17);
            this.dtpSevkTarihi.Name = "dtpSevkTarihi";
            this.dtpSevkTarihi.Size = new System.Drawing.Size(120, 22);
            this.dtpSevkTarihi.TabIndex = 6;
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Location = new System.Drawing.Point(280, 55);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(52, 16);
            this.lblSoyadi.TabIndex = 7;
            this.lblSoyadi.Text = "Soyadı:";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(340, 52);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.ReadOnly = true;
            this.txtSoyadi.Size = new System.Drawing.Size(150, 22);
            this.txtSoyadi.TabIndex = 8;
            // 
            // lblOncekiIslemler
            // 
            this.lblOncekiIslemler.AutoSize = true;
            this.lblOncekiIslemler.Location = new System.Drawing.Point(520, 20);
            this.lblOncekiIslemler.Name = "lblOncekiIslemler";
            this.lblOncekiIslemler.Size = new System.Drawing.Size(110, 16);
            this.lblOncekiIslemler.TabIndex = 9;
            this.lblOncekiIslemler.Text = "Önceki İşlemler:";
            // 
            // txtOncekiIslemler
            // 
            this.txtOncekiIslemler.Location = new System.Drawing.Point(640, 17);
            this.txtOncekiIslemler.Name = "txtOncekiIslemler";
            this.txtOncekiIslemler.Size = new System.Drawing.Size(100, 22);
            this.txtOncekiIslemler.TabIndex = 10;
            // 
            // btnGit
            // 
            this.btnGit.Location = new System.Drawing.Point(750, 15);
            this.btnGit.Name = "btnGit";
            this.btnGit.Size = new System.Drawing.Size(50, 26);
            this.btnGit.TabIndex = 11;
            this.btnGit.Text = "Git";
            this.btnGit.UseVisualStyleBackColor = true;
            this.btnGit.Click += new System.EventHandler(this.btnGit_Click);
            // 
            // lblKurumAdi
            // 
            this.lblKurumAdi.AutoSize = true;
            this.lblKurumAdi.Location = new System.Drawing.Point(520, 55);
            this.lblKurumAdi.Name = "lblKurumAdi";
            this.lblKurumAdi.Size = new System.Drawing.Size(75, 16);
            this.lblKurumAdi.TabIndex = 12;
            this.lblKurumAdi.Text = "Kurum Adı:";
            // 
            // txtKurumAdi
            // 
            this.txtKurumAdi.Location = new System.Drawing.Point(610, 52);
            this.txtKurumAdi.Name = "txtKurumAdi";
            this.txtKurumAdi.ReadOnly = true;
            this.txtKurumAdi.Size = new System.Drawing.Size(150, 22);
            this.txtKurumAdi.TabIndex = 13;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(280, 90);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(280, 20);
            this.lblBaslik.TabIndex = 14;
            this.lblBaslik.Text = "Sağlık Ocağı Hasta Takip Sistemi";
            // 
            // btnHastaBilgileri
            // 
            this.btnHastaBilgileri.Location = new System.Drawing.Point(780, 50);
            this.btnHastaBilgileri.Name = "btnHastaBilgileri";
            this.btnHastaBilgileri.Size = new System.Drawing.Size(120, 30);
            this.btnHastaBilgileri.TabIndex = 15;
            this.btnHastaBilgileri.Text = "Hasta Bilgileri";
            this.btnHastaBilgileri.UseVisualStyleBackColor = true;
            this.btnHastaBilgileri.Click += new System.EventHandler(this.btnHastaBilgileri_Click);
            // 
            // lblPoliklinik
            // 
            this.lblPoliklinik.AutoSize = true;
            this.lblPoliklinik.Location = new System.Drawing.Point(20, 130);
            this.lblPoliklinik.Name = "lblPoliklinik";
            this.lblPoliklinik.Size = new System.Drawing.Size(65, 16);
            this.lblPoliklinik.TabIndex = 16;
            this.lblPoliklinik.Text = "Poliklinik:";
            // 
            // cmbPoliklinik
            // 
            this.cmbPoliklinik.FormattingEnabled = true;
            this.cmbPoliklinik.Location = new System.Drawing.Point(100, 127);
            this.cmbPoliklinik.Name = "cmbPoliklinik";
            this.cmbPoliklinik.Size = new System.Drawing.Size(150, 24);
            this.cmbPoliklinik.TabIndex = 17;
            // 
            // lblSiraNo
            // 
            this.lblSiraNo.AutoSize = true;
            this.lblSiraNo.Location = new System.Drawing.Point(280, 130);
            this.lblSiraNo.Name = "lblSiraNo";
            this.lblSiraNo.Size = new System.Drawing.Size(60, 16);
            this.lblSiraNo.TabIndex = 18;
            this.lblSiraNo.Text = "SIRA NO:";
            // 
            // txtSiraNo
            // 
            this.txtSiraNo.Location = new System.Drawing.Point(350, 127);
            this.txtSiraNo.Name = "txtSiraNo";
            this.txtSiraNo.Size = new System.Drawing.Size(80, 22);
            this.txtSiraNo.TabIndex = 19;
            // 
            // lblYapilanIslem
            // 
            this.lblYapilanIslem.AutoSize = true;
            this.lblYapilanIslem.Location = new System.Drawing.Point(450, 130);
            this.lblYapilanIslem.Name = "lblYapilanIslem";
            this.lblYapilanIslem.Size = new System.Drawing.Size(100, 16);
            this.lblYapilanIslem.TabIndex = 20;
            this.lblYapilanIslem.Text = "Yapılan İşlem:";
            // 
            // cmbYapilanIslem
            // 
            this.cmbYapilanIslem.FormattingEnabled = true;
            this.cmbYapilanIslem.Location = new System.Drawing.Point(560, 127);
            this.cmbYapilanIslem.Name = "cmbYapilanIslem";
            this.cmbYapilanIslem.Size = new System.Drawing.Size(150, 24);
            this.cmbYapilanIslem.TabIndex = 21;
            // 
            // lblDrKodu
            // 
            this.lblDrKodu.AutoSize = true;
            this.lblDrKodu.Location = new System.Drawing.Point(20, 165);
            this.lblDrKodu.Name = "lblDrKodu";
            this.lblDrKodu.Size = new System.Drawing.Size(70, 16);
            this.lblDrKodu.TabIndex = 22;
            this.lblDrKodu.Text = "Dr. Kodu:";
            // 
            // cmbDrKodu
            // 
            this.cmbDrKodu.FormattingEnabled = true;
            this.cmbDrKodu.Location = new System.Drawing.Point(100, 162);
            this.cmbDrKodu.Name = "cmbDrKodu";
            this.cmbDrKodu.Size = new System.Drawing.Size(150, 24);
            this.cmbDrKodu.TabIndex = 23;
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(280, 165);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(50, 16);
            this.lblMiktar.TabIndex = 24;
            this.lblMiktar.Text = "Miktar:";
            // 
            // nudMiktar
            // 
            this.nudMiktar.Location = new System.Drawing.Point(340, 163);
            this.nudMiktar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMiktar.Name = "nudMiktar";
            this.nudMiktar.Size = new System.Drawing.Size(80, 22);
            this.nudMiktar.TabIndex = 25;
            this.nudMiktar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.Location = new System.Drawing.Point(450, 165);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(75, 16);
            this.lblBirimFiyat.TabIndex = 26;
            this.lblBirimFiyat.Text = "Birim Fiyat:";
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(530, 162);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtBirimFiyat.TabIndex = 27;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(650, 160);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(80, 28);
            this.btnEkle.TabIndex = 28;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblGridBaslik
            // 
            this.lblGridBaslik.AutoSize = true;
            this.lblGridBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGridBaslik.Location = new System.Drawing.Point(20, 205);
            this.lblGridBaslik.Name = "lblGridBaslik";
            this.lblGridBaslik.Size = new System.Drawing.Size(220, 18);
            this.lblGridBaslik.TabIndex = 29;
            this.lblGridBaslik.Text = "Yapılan Tahlil ve İşlemler";
            // 
            // dgvIslemler
            // 
            this.dgvIslemler.AllowUserToAddRows = false;
            this.dgvIslemler.AllowUserToDeleteRows = false;
            this.dgvIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIslemler.Location = new System.Drawing.Point(20, 230);
            this.dgvIslemler.Name = "dgvIslemler";
            this.dgvIslemler.ReadOnly = true;
            this.dgvIslemler.RowHeadersWidth = 51;
            this.dgvIslemler.RowTemplate.Height = 24;
            this.dgvIslemler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIslemler.Size = new System.Drawing.Size(880, 250);
            this.dgvIslemler.TabIndex = 30;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(750, 495);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(60, 20);
            this.lblToplamTutar.TabIndex = 31;
            this.lblToplamTutar.Text = "0 YTL";
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(20, 530);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(100, 35);
            this.btnYeni.TabIndex = 32;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnSecSil
            // 
            this.btnSecSil.Location = new System.Drawing.Point(130, 530);
            this.btnSecSil.Name = "btnSecSil";
            this.btnSecSil.Size = new System.Drawing.Size(100, 35);
            this.btnSecSil.TabIndex = 33;
            this.btnSecSil.Text = "Seç - Sil";
            this.btnSecSil.UseVisualStyleBackColor = true;
            this.btnSecSil.Click += new System.EventHandler(this.btnSecSil_Click);
            // 
            // btnTaburcu
            // 
            this.btnTaburcu.Location = new System.Drawing.Point(240, 530);
            this.btnTaburcu.Name = "btnTaburcu";
            this.btnTaburcu.Size = new System.Drawing.Size(100, 35);
            this.btnTaburcu.TabIndex = 34;
            this.btnTaburcu.Text = "Taburcu";
            this.btnTaburcu.UseVisualStyleBackColor = true;
            this.btnTaburcu.Click += new System.EventHandler(this.btnTaburcu_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(350, 530);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(100, 35);
            this.btnYazdir.TabIndex = 35;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnBaskiOnizleme
            // 
            this.btnBaskiOnizleme.Location = new System.Drawing.Point(460, 530);
            this.btnBaskiOnizleme.Name = "btnBaskiOnizleme";
            this.btnBaskiOnizleme.Size = new System.Drawing.Size(120, 35);
            this.btnBaskiOnizleme.TabIndex = 36;
            this.btnBaskiOnizleme.Text = "Baskı Önizleme";
            this.btnBaskiOnizleme.UseVisualStyleBackColor = true;
            this.btnBaskiOnizleme.Click += new System.EventHandler(this.btnBaskiOnizleme_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(800, 530);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(100, 35);
            this.btnCikis.TabIndex = 37;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmHastaIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 580);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnBaskiOnizleme);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnTaburcu);
            this.Controls.Add(this.btnSecSil);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.dgvIslemler);
            this.Controls.Add(this.lblGridBaslik);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.lblBirimFiyat);
            this.Controls.Add(this.nudMiktar);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.cmbDrKodu);
            this.Controls.Add(this.lblDrKodu);
            this.Controls.Add(this.cmbYapilanIslem);
            this.Controls.Add(this.lblYapilanIslem);
            this.Controls.Add(this.txtSiraNo);
            this.Controls.Add(this.lblSiraNo);
            this.Controls.Add(this.cmbPoliklinik);
            this.Controls.Add(this.lblPoliklinik);
            this.Controls.Add(this.btnHastaBilgileri);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.txtKurumAdi);
            this.Controls.Add(this.lblKurumAdi);
            this.Controls.Add(this.btnGit);
            this.Controls.Add(this.txtOncekiIslemler);
            this.Controls.Add(this.lblOncekiIslemler);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.dtpSevkTarihi);
            this.Controls.Add(this.lblSevkTarihi);
            this.Controls.Add(this.txtHastaAdi);
            this.Controls.Add(this.lblHastaAdi);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtDosyaNo);
            this.Controls.Add(this.lblDosyaNo);
            this.Name = "frmHastaIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta İşlemleri";
            this.Load += new System.EventHandler(this.frmHastaIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIslemler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDosyaNo;
        private System.Windows.Forms.TextBox txtDosyaNo;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Label lblHastaAdi;
        private System.Windows.Forms.TextBox txtHastaAdi;
        private System.Windows.Forms.Label lblSevkTarihi;
        private System.Windows.Forms.DateTimePicker dtpSevkTarihi;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label lblOncekiIslemler;
        private System.Windows.Forms.TextBox txtOncekiIslemler;
        private System.Windows.Forms.Button btnGit;
        private System.Windows.Forms.Label lblKurumAdi;
        private System.Windows.Forms.TextBox txtKurumAdi;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnHastaBilgileri;
        private System.Windows.Forms.Label lblPoliklinik;
        private System.Windows.Forms.ComboBox cmbPoliklinik;
        private System.Windows.Forms.Label lblSiraNo;
        private System.Windows.Forms.TextBox txtSiraNo;
        private System.Windows.Forms.Label lblYapilanIslem;
        private System.Windows.Forms.ComboBox cmbYapilanIslem;
        private System.Windows.Forms.Label lblDrKodu;
        private System.Windows.Forms.ComboBox cmbDrKodu;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.NumericUpDown nudMiktar;
        private System.Windows.Forms.Label lblBirimFiyat;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblGridBaslik;
        private System.Windows.Forms.DataGridView dgvIslemler;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnSecSil;
        private System.Windows.Forms.Button btnTaburcu;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnBaskiOnizleme;
        private System.Windows.Forms.Button btnCikis;
    }
}
