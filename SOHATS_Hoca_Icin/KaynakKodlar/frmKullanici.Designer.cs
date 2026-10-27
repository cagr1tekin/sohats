namespace SOHATS
{
    partial class frmKullanici
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
            this.lblKullaniciKodu = new System.Windows.Forms.Label();
            this.cmbKullaniciKodu = new System.Windows.Forms.ComboBox();
            this.lblTcKimlikNo = new System.Windows.Forms.Label();
            this.txtTcKimlikNo = new System.Windows.Forms.TextBox();
            this.lblDogumYeri = new System.Windows.Forms.Label();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.lblBabaAdi = new System.Windows.Forms.Label();
            this.txtBabaAdi = new System.Windows.Forms.TextBox();
            this.lblAnneAdi = new System.Windows.Forms.Label();
            this.txtAnneAdi = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblGSM = new System.Windows.Forms.Label();
            this.txtGSM = new System.Windows.Forms.TextBox();
            this.lblUnvan = new System.Windows.Forms.Label();
            this.cmbUnvan = new System.Windows.Forms.ComboBox();
            this.lblAdi = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.lblMaas = new System.Windows.Forms.Label();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.lblIseBaslama = new System.Windows.Forms.Label();
            this.dtpIseBaslama = new System.Windows.Forms.DateTimePicker();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.lblMedeniHal = new System.Windows.Forms.Label();
            this.cmbMedeniHal = new System.Windows.Forms.ComboBox();
            this.lblKanGrubu = new System.Windows.Forms.Label();
            this.cmbKanGrubu = new System.Windows.Forms.ComboBox();
            this.chkYetkiliKullanici = new System.Windows.Forms.CheckBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnYeniKullanici = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKullaniciKodu
            // 
            this.lblKullaniciKodu.AutoSize = true;
            this.lblKullaniciKodu.Location = new System.Drawing.Point(20, 20);
            this.lblKullaniciKodu.Name = "lblKullaniciKodu";
            this.lblKullaniciKodu.Size = new System.Drawing.Size(95, 16);
            this.lblKullaniciKodu.TabIndex = 0;
            this.lblKullaniciKodu.Text = "Kullanıcı Kodu:";
            // 
            // cmbKullaniciKodu
            // 
            this.cmbKullaniciKodu.FormattingEnabled = true;
            this.cmbKullaniciKodu.Location = new System.Drawing.Point(120, 17);
            this.cmbKullaniciKodu.Name = "cmbKullaniciKodu";
            this.cmbKullaniciKodu.Size = new System.Drawing.Size(150, 24);
            this.cmbKullaniciKodu.TabIndex = 1;
            this.cmbKullaniciKodu.SelectedIndexChanged += new System.EventHandler(this.cmbKullaniciKodu_SelectedIndexChanged);
            // 
            // lblTcKimlikNo
            // 
            this.lblTcKimlikNo.AutoSize = true;
            this.lblTcKimlikNo.Location = new System.Drawing.Point(20, 55);
            this.lblTcKimlikNo.Name = "lblTcKimlikNo";
            this.lblTcKimlikNo.Size = new System.Drawing.Size(130, 16);
            this.lblTcKimlikNo.TabIndex = 2;
            this.lblTcKimlikNo.Text = "T.C. Kimlik Numarası:";
            // 
            // txtTcKimlikNo
            // 
            this.txtTcKimlikNo.Location = new System.Drawing.Point(155, 52);
            this.txtTcKimlikNo.MaxLength = 11;
            this.txtTcKimlikNo.Name = "txtTcKimlikNo";
            this.txtTcKimlikNo.Size = new System.Drawing.Size(150, 22);
            this.txtTcKimlikNo.TabIndex = 3;
            // 
            // lblDogumYeri
            // 
            this.lblDogumYeri.AutoSize = true;
            this.lblDogumYeri.Location = new System.Drawing.Point(20, 90);
            this.lblDogumYeri.Name = "lblDogumYeri";
            this.lblDogumYeri.Size = new System.Drawing.Size(80, 16);
            this.lblDogumYeri.TabIndex = 4;
            this.lblDogumYeri.Text = "Doğum Yeri:";
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(120, 87);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(150, 22);
            this.txtDogumYeri.TabIndex = 5;
            // 
            // lblBabaAdi
            // 
            this.lblBabaAdi.AutoSize = true;
            this.lblBabaAdi.Location = new System.Drawing.Point(20, 125);
            this.lblBabaAdi.Name = "lblBabaAdi";
            this.lblBabaAdi.Size = new System.Drawing.Size(68, 16);
            this.lblBabaAdi.TabIndex = 6;
            this.lblBabaAdi.Text = "Baba Adı:";
            // 
            // txtBabaAdi
            // 
            this.txtBabaAdi.Location = new System.Drawing.Point(120, 122);
            this.txtBabaAdi.Name = "txtBabaAdi";
            this.txtBabaAdi.Size = new System.Drawing.Size(150, 22);
            this.txtBabaAdi.TabIndex = 7;
            // 
            // lblAnneAdi
            // 
            this.lblAnneAdi.AutoSize = true;
            this.lblAnneAdi.Location = new System.Drawing.Point(20, 160);
            this.lblAnneAdi.Name = "lblAnneAdi";
            this.lblAnneAdi.Size = new System.Drawing.Size(70, 16);
            this.lblAnneAdi.TabIndex = 8;
            this.lblAnneAdi.Text = "Anne Adı:";
            // 
            // txtAnneAdi
            // 
            this.txtAnneAdi.Location = new System.Drawing.Point(120, 157);
            this.txtAnneAdi.Name = "txtAnneAdi";
            this.txtAnneAdi.Size = new System.Drawing.Size(150, 22);
            this.txtAnneAdi.TabIndex = 9;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(20, 195);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(66, 16);
            this.lblTelefon.TabIndex = 10;
            this.lblTelefon.Text = "Telefon No:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(120, 192);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(150, 22);
            this.txtTelefon.TabIndex = 11;
            // 
            // lblGSM
            // 
            this.lblGSM.AutoSize = true;
            this.lblGSM.Location = new System.Drawing.Point(20, 230);
            this.lblGSM.Name = "lblGSM";
            this.lblGSM.Size = new System.Drawing.Size(40, 16);
            this.lblGSM.TabIndex = 12;
            this.lblGSM.Text = "GSM:";
            // 
            // txtGSM
            // 
            this.txtGSM.Location = new System.Drawing.Point(120, 227);
            this.txtGSM.Name = "txtGSM";
            this.txtGSM.Size = new System.Drawing.Size(150, 22);
            this.txtGSM.TabIndex = 13;
            // 
            // lblUnvan
            // 
            this.lblUnvan.AutoSize = true;
            this.lblUnvan.Location = new System.Drawing.Point(320, 20);
            this.lblUnvan.Name = "lblUnvan";
            this.lblUnvan.Size = new System.Drawing.Size(48, 16);
            this.lblUnvan.TabIndex = 14;
            this.lblUnvan.Text = "Unvan:";
            // 
            // cmbUnvan
            // 
            this.cmbUnvan.FormattingEnabled = true;
            this.cmbUnvan.Items.AddRange(new object[] {
            "Sağlık Personel",
            "Doktor",
            "Hemşire",
            "Sekreter",
            "Yönetici"});
            this.cmbUnvan.Location = new System.Drawing.Point(380, 17);
            this.cmbUnvan.Name = "cmbUnvan";
            this.cmbUnvan.Size = new System.Drawing.Size(150, 24);
            this.cmbUnvan.TabIndex = 15;
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(320, 55);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(30, 16);
            this.lblAdi.TabIndex = 16;
            this.lblAdi.Text = "Adı:";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(380, 52);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(150, 22);
            this.txtAdi.TabIndex = 17;
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Location = new System.Drawing.Point(320, 90);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(52, 16);
            this.lblSoyadi.TabIndex = 18;
            this.lblSoyadi.Text = "Soyadı:";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(380, 87);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(150, 22);
            this.txtSoyadi.TabIndex = 19;
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Location = new System.Drawing.Point(320, 125);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(43, 16);
            this.lblMaas.TabIndex = 20;
            this.lblMaas.Text = "Maaş:";
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(380, 122);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(150, 22);
            this.txtMaas.TabIndex = 21;
            // 
            // lblIseBaslama
            // 
            this.lblIseBaslama.AutoSize = true;
            this.lblIseBaslama.Location = new System.Drawing.Point(320, 160);
            this.lblIseBaslama.Name = "lblIseBaslama";
            this.lblIseBaslama.Size = new System.Drawing.Size(88, 16);
            this.lblIseBaslama.TabIndex = 22;
            this.lblIseBaslama.Text = "İşe Başlama:";
            // 
            // dtpIseBaslama
            // 
            this.dtpIseBaslama.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIseBaslama.Location = new System.Drawing.Point(420, 157);
            this.dtpIseBaslama.Name = "dtpIseBaslama";
            this.dtpIseBaslama.Size = new System.Drawing.Size(110, 22);
            this.dtpIseBaslama.TabIndex = 23;
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(320, 195);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(90, 16);
            this.lblDogumTarihi.TabIndex = 24;
            this.lblDogumTarihi.Text = "Doğum Tarihi:";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(420, 192);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(110, 22);
            this.dtpDogumTarihi.TabIndex = 25;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(320, 230);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(62, 16);
            this.lblCinsiyet.TabIndex = 26;
            this.lblCinsiyet.Text = "Cinsiyeti:";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(380, 227);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(150, 24);
            this.cmbCinsiyet.TabIndex = 27;
            // 
            // lblMedeniHal
            // 
            this.lblMedeniHal.AutoSize = true;
            this.lblMedeniHal.Location = new System.Drawing.Point(320, 265);
            this.lblMedeniHal.Name = "lblMedeniHal";
            this.lblMedeniHal.Size = new System.Drawing.Size(78, 16);
            this.lblMedeniHal.TabIndex = 28;
            this.lblMedeniHal.Text = "Medeni Hal:";
            // 
            // cmbMedeniHal
            // 
            this.cmbMedeniHal.FormattingEnabled = true;
            this.cmbMedeniHal.Items.AddRange(new object[] {
            "Bekar",
            "Evli",
            "Dul",
            "Boşanmış"});
            this.cmbMedeniHal.Location = new System.Drawing.Point(380, 262);
            this.cmbMedeniHal.Name = "cmbMedeniHal";
            this.cmbMedeniHal.Size = new System.Drawing.Size(150, 24);
            this.cmbMedeniHal.TabIndex = 29;
            // 
            // lblKanGrubu
            // 
            this.lblKanGrubu.AutoSize = true;
            this.lblKanGrubu.Location = new System.Drawing.Point(320, 300);
            this.lblKanGrubu.Name = "lblKanGrubu";
            this.lblKanGrubu.Size = new System.Drawing.Size(75, 16);
            this.lblKanGrubu.TabIndex = 30;
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
            this.cmbKanGrubu.Location = new System.Drawing.Point(380, 297);
            this.cmbKanGrubu.Name = "cmbKanGrubu";
            this.cmbKanGrubu.Size = new System.Drawing.Size(150, 24);
            this.cmbKanGrubu.TabIndex = 31;
            // 
            // chkYetkiliKullanici
            // 
            this.chkYetkiliKullanici.AutoSize = true;
            this.chkYetkiliKullanici.Location = new System.Drawing.Point(320, 335);
            this.chkYetkiliKullanici.Name = "chkYetkiliKullanici";
            this.chkYetkiliKullanici.Size = new System.Drawing.Size(130, 20);
            this.chkYetkiliKullanici.TabIndex = 32;
            this.chkYetkiliKullanici.Text = "yetkili kullanıcı";
            this.chkYetkiliKullanici.UseVisualStyleBackColor = true;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(20, 265);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(47, 16);
            this.lblAdres.TabIndex = 33;
            this.lblAdres.Text = "Adres:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(20, 285);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAdres.Size = new System.Drawing.Size(250, 70);
            this.txtAdres.TabIndex = 34;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(20, 370);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(82, 16);
            this.lblKullaniciAdi.TabIndex = 35;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(120, 367);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(150, 22);
            this.txtKullaniciAdi.TabIndex = 36;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(20, 405);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(37, 16);
            this.lblSifre.TabIndex = 37;
            this.lblSifre.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(120, 402);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(150, 22);
            this.txtSifre.TabIndex = 38;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(320, 365);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(80, 30);
            this.btnTemizle.TabIndex = 39;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(410, 365);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(80, 30);
            this.btnGuncelle.TabIndex = 40;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(500, 365);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(80, 30);
            this.btnSil.TabIndex = 41;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(590, 365);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(80, 30);
            this.btnCikis.TabIndex = 42;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnYeniKullanici
            // 
            this.btnYeniKullanici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnYeniKullanici.ForeColor = System.Drawing.Color.White;
            this.btnYeniKullanici.Location = new System.Drawing.Point(20, 440);
            this.btnYeniKullanici.Name = "btnYeniKullanici";
            this.btnYeniKullanici.Size = new System.Drawing.Size(150, 35);
            this.btnYeniKullanici.TabIndex = 43;
            this.btnYeniKullanici.Text = "Yeni Kullanıcı Ekle";
            this.btnYeniKullanici.UseVisualStyleBackColor = false;
            this.btnYeniKullanici.Click += new System.EventHandler(this.btnYeniKullanici_Click);
            // 
            // frmKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 490);
            this.Controls.Add(this.btnYeniKullanici);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.chkYetkiliKullanici);
            this.Controls.Add(this.cmbKanGrubu);
            this.Controls.Add(this.lblKanGrubu);
            this.Controls.Add(this.cmbMedeniHal);
            this.Controls.Add(this.lblMedeniHal);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.dtpIseBaslama);
            this.Controls.Add(this.lblIseBaslama);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.cmbUnvan);
            this.Controls.Add(this.lblUnvan);
            this.Controls.Add(this.txtGSM);
            this.Controls.Add(this.lblGSM);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtAnneAdi);
            this.Controls.Add(this.lblAnneAdi);
            this.Controls.Add(this.txtBabaAdi);
            this.Controls.Add(this.lblBabaAdi);
            this.Controls.Add(this.txtDogumYeri);
            this.Controls.Add(this.lblDogumYeri);
            this.Controls.Add(this.txtTcKimlikNo);
            this.Controls.Add(this.lblTcKimlikNo);
            this.Controls.Add(this.cmbKullaniciKodu);
            this.Controls.Add(this.lblKullaniciKodu);
            this.Name = "frmKullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOHATS - Kullanıcı Tanıtma";
            this.Load += new System.EventHandler(this.frmKullanici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullaniciKodu;
        private System.Windows.Forms.ComboBox cmbKullaniciKodu;
        private System.Windows.Forms.Label lblTcKimlikNo;
        private System.Windows.Forms.TextBox txtTcKimlikNo;
        private System.Windows.Forms.Label lblDogumYeri;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.Label lblBabaAdi;
        private System.Windows.Forms.TextBox txtBabaAdi;
        private System.Windows.Forms.Label lblAnneAdi;
        private System.Windows.Forms.TextBox txtAnneAdi;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblGSM;
        private System.Windows.Forms.TextBox txtGSM;
        private System.Windows.Forms.Label lblUnvan;
        private System.Windows.Forms.ComboBox cmbUnvan;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label lblIseBaslama;
        private System.Windows.Forms.DateTimePicker dtpIseBaslama;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label lblMedeniHal;
        private System.Windows.Forms.ComboBox cmbMedeniHal;
        private System.Windows.Forms.Label lblKanGrubu;
        private System.Windows.Forms.ComboBox cmbKanGrubu;
        private System.Windows.Forms.CheckBox chkYetkiliKullanici;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnYeniKullanici;
    }
}
