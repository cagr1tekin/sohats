namespace SOHATS
{
    partial class frmHastaBilgileri
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblDosyaNo = new System.Windows.Forms.Label();
            this.txtDosyaNo = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblDogumYeri = new System.Windows.Forms.Label();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.lblBabaAd = new System.Windows.Forms.Label();
            this.txtBabaAd = new System.Windows.Forms.TextBox();
            this.lblAnneAd = new System.Windows.Forms.Label();
            this.txtAnneAd = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblKurumSicilNo = new System.Windows.Forms.Label();
            this.txtKurumSicilNo = new System.Windows.Forms.TextBox();
            this.lblKurumAd = new System.Windows.Forms.Label();
            this.txtKurumAd = new System.Windows.Forms.TextBox();
            this.lblTcKimlikNo = new System.Windows.Forms.Label();
            this.txtTcKimlikNo = new System.Windows.Forms.TextBox();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.lblMedeniHal = new System.Windows.Forms.Label();
            this.cmbMedeniHal = new System.Windows.Forms.ComboBox();
            this.lblKanGrubu = new System.Windows.Forms.Label();
            this.cmbKanGrubu = new System.Windows.Forms.ComboBox();
            this.lblYakinTelefon = new System.Windows.Forms.Label();
            this.txtYakinTelefon = new System.Windows.Forms.TextBox();
            this.lblYakinKurumSicilNo = new System.Windows.Forms.Label();
            this.txtYakinKurumSicilNo = new System.Windows.Forms.TextBox();
            this.lblYakinKurumAd = new System.Windows.Forms.Label();
            this.txtYakinKurumAd = new System.Windows.Forms.TextBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(20, 15);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(160, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "< Hasta Bilgileri >";
            // 
            // lblDosyaNo
            // 
            this.lblDosyaNo.AutoSize = true;
            this.lblDosyaNo.Location = new System.Drawing.Point(20, 55);
            this.lblDosyaNo.Name = "lblDosyaNo";
            this.lblDosyaNo.Size = new System.Drawing.Size(72, 16);
            this.lblDosyaNo.TabIndex = 1;
            this.lblDosyaNo.Text = "Dosya No:";
            // 
            // txtDosyaNo
            // 
            this.txtDosyaNo.Location = new System.Drawing.Point(100, 52);
            this.txtDosyaNo.Name = "txtDosyaNo";
            this.txtDosyaNo.Size = new System.Drawing.Size(120, 22);
            this.txtDosyaNo.TabIndex = 2;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(20, 90);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(30, 16);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Ad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(100, 87);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 22);
            this.txtAd.TabIndex = 4;
            // 
            // lblDogumYeri
            // 
            this.lblDogumYeri.AutoSize = true;
            this.lblDogumYeri.Location = new System.Drawing.Point(20, 125);
            this.lblDogumYeri.Name = "lblDogumYeri";
            this.lblDogumYeri.Size = new System.Drawing.Size(80, 16);
            this.lblDogumYeri.TabIndex = 5;
            this.lblDogumYeri.Text = "Doğum Yeri:";
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(100, 122);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(200, 22);
            this.txtDogumYeri.TabIndex = 6;
            // 
            // lblBabaAd
            // 
            this.lblBabaAd.AutoSize = true;
            this.lblBabaAd.Location = new System.Drawing.Point(20, 160);
            this.lblBabaAd.Name = "lblBabaAd";
            this.lblBabaAd.Size = new System.Drawing.Size(68, 16);
            this.lblBabaAd.TabIndex = 7;
            this.lblBabaAd.Text = "Baba Ad:";
            // 
            // txtBabaAd
            // 
            this.txtBabaAd.Location = new System.Drawing.Point(100, 157);
            this.txtBabaAd.Name = "txtBabaAd";
            this.txtBabaAd.Size = new System.Drawing.Size(200, 22);
            this.txtBabaAd.TabIndex = 8;
            // 
            // lblAnneAd
            // 
            this.lblAnneAd.AutoSize = true;
            this.lblAnneAd.Location = new System.Drawing.Point(20, 195);
            this.lblAnneAd.Name = "lblAnneAd";
            this.lblAnneAd.Size = new System.Drawing.Size(70, 16);
            this.lblAnneAd.TabIndex = 9;
            this.lblAnneAd.Text = "Anne Ad:";
            // 
            // txtAnneAd
            // 
            this.txtAnneAd.Location = new System.Drawing.Point(100, 192);
            this.txtAnneAd.Name = "txtAnneAd";
            this.txtAnneAd.Size = new System.Drawing.Size(200, 22);
            this.txtAnneAd.TabIndex = 10;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(20, 230);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(47, 16);
            this.lblAdres.TabIndex = 11;
            this.lblAdres.Text = "Adres:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(100, 227);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAdres.Size = new System.Drawing.Size(200, 60);
            this.txtAdres.TabIndex = 12;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(20, 300);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(75, 16);
            this.lblTelefon.TabIndex = 13;
            this.lblTelefon.Text = "Telefon No:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(100, 297);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 22);
            this.txtTelefon.TabIndex = 14;
            // 
            // lblKurumSicilNo
            // 
            this.lblKurumSicilNo.AutoSize = true;
            this.lblKurumSicilNo.Location = new System.Drawing.Point(20, 335);
            this.lblKurumSicilNo.Name = "lblKurumSicilNo";
            this.lblKurumSicilNo.Size = new System.Drawing.Size(105, 16);
            this.lblKurumSicilNo.TabIndex = 15;
            this.lblKurumSicilNo.Text = "Kurum Sicil No:";
            // 
            // txtKurumSicilNo
            // 
            this.txtKurumSicilNo.Location = new System.Drawing.Point(130, 332);
            this.txtKurumSicilNo.Name = "txtKurumSicilNo";
            this.txtKurumSicilNo.Size = new System.Drawing.Size(170, 22);
            this.txtKurumSicilNo.TabIndex = 16;
            // 
            // lblKurumAd
            // 
            this.lblKurumAd.AutoSize = true;
            this.lblKurumAd.Location = new System.Drawing.Point(20, 370);
            this.lblKurumAd.Name = "lblKurumAd";
            this.lblKurumAd.Size = new System.Drawing.Size(75, 16);
            this.lblKurumAd.TabIndex = 17;
            this.lblKurumAd.Text = "Kurum Ad:";
            // 
            // txtKurumAd
            // 
            this.txtKurumAd.Location = new System.Drawing.Point(100, 367);
            this.txtKurumAd.Name = "txtKurumAd";
            this.txtKurumAd.Size = new System.Drawing.Size(200, 22);
            this.txtKurumAd.TabIndex = 18;
            // 
            // lblTcKimlikNo
            // 
            this.lblTcKimlikNo.AutoSize = true;
            this.lblTcKimlikNo.Location = new System.Drawing.Point(350, 55);
            this.lblTcKimlikNo.Name = "lblTcKimlikNo";
            this.lblTcKimlikNo.Size = new System.Drawing.Size(130, 16);
            this.lblTcKimlikNo.TabIndex = 19;
            this.lblTcKimlikNo.Text = "T.C. Kimlik Numarası:";
            // 
            // txtTcKimlikNo
            // 
            this.txtTcKimlikNo.Location = new System.Drawing.Point(490, 52);
            this.txtTcKimlikNo.MaxLength = 11;
            this.txtTcKimlikNo.Name = "txtTcKimlikNo";
            this.txtTcKimlikNo.Size = new System.Drawing.Size(200, 22);
            this.txtTcKimlikNo.TabIndex = 20;
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Location = new System.Drawing.Point(350, 90);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(52, 16);
            this.lblSoyadi.TabIndex = 21;
            this.lblSoyadi.Text = "Soyadı:";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(410, 87);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(200, 22);
            this.txtSoyadi.TabIndex = 22;
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(350, 125);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(90, 16);
            this.lblDogumTarihi.TabIndex = 23;
            this.lblDogumTarihi.Text = "Doğum Tarihi:";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(450, 122);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(240, 22);
            this.dtpDogumTarihi.TabIndex = 24;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(350, 160);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(62, 16);
            this.lblCinsiyet.TabIndex = 25;
            this.lblCinsiyet.Text = "Cinsiyeti:";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(420, 157);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(150, 24);
            this.cmbCinsiyet.TabIndex = 26;
            // 
            // lblMedeniHal
            // 
            this.lblMedeniHal.AutoSize = true;
            this.lblMedeniHal.Location = new System.Drawing.Point(350, 195);
            this.lblMedeniHal.Name = "lblMedeniHal";
            this.lblMedeniHal.Size = new System.Drawing.Size(78, 16);
            this.lblMedeniHal.TabIndex = 27;
            this.lblMedeniHal.Text = "Medeni Hali:";
            // 
            // cmbMedeniHal
            // 
            this.cmbMedeniHal.FormattingEnabled = true;
            this.cmbMedeniHal.Items.AddRange(new object[] {
            "Bekar",
            "Evli",
            "Dul",
            "Boşanmış"});
            this.cmbMedeniHal.Location = new System.Drawing.Point(440, 192);
            this.cmbMedeniHal.Name = "cmbMedeniHal";
            this.cmbMedeniHal.Size = new System.Drawing.Size(150, 24);
            this.cmbMedeniHal.TabIndex = 28;
            // 
            // lblKanGrubu
            // 
            this.lblKanGrubu.AutoSize = true;
            this.lblKanGrubu.Location = new System.Drawing.Point(350, 230);
            this.lblKanGrubu.Name = "lblKanGrubu";
            this.lblKanGrubu.Size = new System.Drawing.Size(75, 16);
            this.lblKanGrubu.TabIndex = 29;
            this.lblKanGrubu.Text = "Kan Grubu:";
            // 
            // cmbKanGrubu
            // 
            this.cmbKanGrubu.FormattingEnabled = true;
            this.cmbKanGrubu.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "0+",
            "0-"});
            this.cmbKanGrubu.Location = new System.Drawing.Point(440, 227);
            this.cmbKanGrubu.Name = "cmbKanGrubu";
            this.cmbKanGrubu.Size = new System.Drawing.Size(150, 24);
            this.cmbKanGrubu.TabIndex = 30;
            // 
            // lblYakinTelefon
            // 
            this.lblYakinTelefon.AutoSize = true;
            this.lblYakinTelefon.Location = new System.Drawing.Point(350, 265);
            this.lblYakinTelefon.Name = "lblYakinTelefon";
            this.lblYakinTelefon.Size = new System.Drawing.Size(120, 16);
            this.lblYakinTelefon.TabIndex = 31;
            this.lblYakinTelefon.Text = "Yakınının Telefonu:";
            // 
            // txtYakinTelefon
            // 
            this.txtYakinTelefon.Location = new System.Drawing.Point(480, 262);
            this.txtYakinTelefon.Name = "txtYakinTelefon";
            this.txtYakinTelefon.Size = new System.Drawing.Size(200, 22);
            this.txtYakinTelefon.TabIndex = 32;
            // 
            // lblYakinKurumSicilNo
            // 
            this.lblYakinKurumSicilNo.AutoSize = true;
            this.lblYakinKurumSicilNo.Location = new System.Drawing.Point(350, 300);
            this.lblYakinKurumSicilNo.Name = "lblYakinKurumSicilNo";
            this.lblYakinKurumSicilNo.Size = new System.Drawing.Size(140, 16);
            this.lblYakinKurumSicilNo.TabIndex = 33;
            this.lblYakinKurumSicilNo.Text = "Kurum Sicil No:";
            // 
            // txtYakinKurumSicilNo
            // 
            this.txtYakinKurumSicilNo.Location = new System.Drawing.Point(500, 297);
            this.txtYakinKurumSicilNo.Name = "txtYakinKurumSicilNo";
            this.txtYakinKurumSicilNo.Size = new System.Drawing.Size(180, 22);
            this.txtYakinKurumSicilNo.TabIndex = 34;
            // 
            // lblYakinKurumAd
            // 
            this.lblYakinKurumAd.AutoSize = true;
            this.lblYakinKurumAd.Location = new System.Drawing.Point(350, 335);
            this.lblYakinKurumAd.Name = "lblYakinKurumAd";
            this.lblYakinKurumAd.Size = new System.Drawing.Size(75, 16);
            this.lblYakinKurumAd.TabIndex = 35;
            this.lblYakinKurumAd.Text = "Kurum Ad:";
            // 
            // txtYakinKurumAd
            // 
            this.txtYakinKurumAd.Location = new System.Drawing.Point(440, 332);
            this.txtYakinKurumAd.Name = "txtYakinKurumAd";
            this.txtYakinKurumAd.Size = new System.Drawing.Size(200, 22);
            this.txtYakinKurumAd.TabIndex = 36;
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(20, 420);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(100, 35);
            this.btnYeni.TabIndex = 37;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(130, 420);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 35);
            this.btnKaydet.TabIndex = 38;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(590, 420);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(100, 35);
            this.btnCikis.TabIndex = 39;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmHastaBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.txtYakinKurumAd);
            this.Controls.Add(this.lblYakinKurumAd);
            this.Controls.Add(this.txtYakinKurumSicilNo);
            this.Controls.Add(this.lblYakinKurumSicilNo);
            this.Controls.Add(this.txtYakinTelefon);
            this.Controls.Add(this.lblYakinTelefon);
            this.Controls.Add(this.cmbKanGrubu);
            this.Controls.Add(this.lblKanGrubu);
            this.Controls.Add(this.cmbMedeniHal);
            this.Controls.Add(this.lblMedeniHal);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.txtTcKimlikNo);
            this.Controls.Add(this.lblTcKimlikNo);
            this.Controls.Add(this.txtKurumAd);
            this.Controls.Add(this.lblKurumAd);
            this.Controls.Add(this.txtKurumSicilNo);
            this.Controls.Add(this.lblKurumSicilNo);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.txtAnneAd);
            this.Controls.Add(this.lblAnneAd);
            this.Controls.Add(this.txtBabaAd);
            this.Controls.Add(this.lblBabaAd);
            this.Controls.Add(this.txtDogumYeri);
            this.Controls.Add(this.lblDogumYeri);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtDosyaNo);
            this.Controls.Add(this.lblDosyaNo);
            this.Controls.Add(this.lblBaslik);
            this.Name = "frmHastaBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Bilgileri";
            this.Load += new System.EventHandler(this.frmHastaBilgileri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblDosyaNo;
        private System.Windows.Forms.TextBox txtDosyaNo;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblDogumYeri;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.Label lblBabaAd;
        private System.Windows.Forms.TextBox txtBabaAd;
        private System.Windows.Forms.Label lblAnneAd;
        private System.Windows.Forms.TextBox txtAnneAd;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblKurumSicilNo;
        private System.Windows.Forms.TextBox txtKurumSicilNo;
        private System.Windows.Forms.Label lblKurumAd;
        private System.Windows.Forms.TextBox txtKurumAd;
        private System.Windows.Forms.Label lblTcKimlikNo;
        private System.Windows.Forms.TextBox txtTcKimlikNo;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label lblMedeniHal;
        private System.Windows.Forms.ComboBox cmbMedeniHal;
        private System.Windows.Forms.Label lblKanGrubu;
        private System.Windows.Forms.ComboBox cmbKanGrubu;
        private System.Windows.Forms.Label lblYakinTelefon;
        private System.Windows.Forms.TextBox txtYakinTelefon;
        private System.Windows.Forms.Label lblYakinKurumSicilNo;
        private System.Windows.Forms.TextBox txtYakinKurumSicilNo;
        private System.Windows.Forms.Label lblYakinKurumAd;
        private System.Windows.Forms.TextBox txtYakinKurumAd;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnCikis;
    }
}

