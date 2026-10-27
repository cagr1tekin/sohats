namespace SOHATS
{
    partial class frmPoliklinik
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
            System.Windows.Forms.Label lblPoliklinikAd;
            System.Windows.Forms.Label lblPoliklinikSecim;
            System.Windows.Forms.Label lblAciklama;
            this.cmbPoliklinik = new System.Windows.Forms.ComboBox();
            this.txtPoliklinikAd = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.chkGecerli = new System.Windows.Forms.CheckBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            lblPoliklinikSecim = new System.Windows.Forms.Label();
            lblPoliklinikAd = new System.Windows.Forms.Label();
            lblAciklama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPoliklinikSecim
            // 
            lblPoliklinikSecim.AutoSize = true;
            lblPoliklinikSecim.Location = new System.Drawing.Point(20, 20);
            lblPoliklinikSecim.Name = "lblPoliklinikSecim";
            lblPoliklinikSecim.Size = new System.Drawing.Size(88, 16);
            lblPoliklinikSecim.TabIndex = 0;
            lblPoliklinikSecim.Text = "Poliklinik Adı:";
            // 
            // cmbPoliklinik
            // 
            this.cmbPoliklinik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPoliklinik.FormattingEnabled = true;
            this.cmbPoliklinik.Location = new System.Drawing.Point(120, 17);
            this.cmbPoliklinik.Name = "cmbPoliklinik";
            this.cmbPoliklinik.Size = new System.Drawing.Size(180, 24);
            this.cmbPoliklinik.TabIndex = 0;
            this.cmbPoliklinik.SelectedIndexChanged += new System.EventHandler(this.cmbPoliklinik_SelectedIndexChanged);
            // 
            // lblPoliklinikAd
            // 
            lblPoliklinikAd.AutoSize = true;
            lblPoliklinikAd.Location = new System.Drawing.Point(20, 60);
            lblPoliklinikAd.Name = "lblPoliklinikAd";
            lblPoliklinikAd.Size = new System.Drawing.Size(88, 16);
            lblPoliklinikAd.TabIndex = 1;
            lblPoliklinikAd.Text = "Poliklinik Adı:";
            // 
            // txtPoliklinikAd
            // 
            this.txtPoliklinikAd.Location = new System.Drawing.Point(120, 57);
            this.txtPoliklinikAd.Name = "txtPoliklinikAd";
            this.txtPoliklinikAd.ReadOnly = true;
            this.txtPoliklinikAd.Size = new System.Drawing.Size(180, 22);
            this.txtPoliklinikAd.TabIndex = 1;
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.Location = new System.Drawing.Point(20, 120);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new System.Drawing.Size(66, 16);
            lblAciklama.TabIndex = 3;
            lblAciklama.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(23, 145);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(277, 100);
            this.txtAciklama.TabIndex = 3;
            // 
            // chkGecerli
            // 
            this.chkGecerli.AutoSize = true;
            this.chkGecerli.Location = new System.Drawing.Point(120, 90);
            this.chkGecerli.Name = "chkGecerli";
            this.chkGecerli.Size = new System.Drawing.Size(131, 20);
            this.chkGecerli.TabIndex = 2;
            this.chkGecerli.Text = "Geçerli / Geçersiz";
            this.chkGecerli.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(23, 260);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(85, 35);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(118, 260);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 35);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(215, 260);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(85, 35);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmPoliklinik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 315);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(lblAciklama);
            this.Controls.Add(lblPoliklinikAd);
            this.Controls.Add(lblPoliklinikSecim);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.chkGecerli);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtPoliklinikAd);
            this.Controls.Add(this.cmbPoliklinik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPoliklinik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poliklinik";
            this.Load += new System.EventHandler(this.frmPoliklinik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPoliklinik;
        private System.Windows.Forms.TextBox txtPoliklinikAd;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.CheckBox chkGecerli;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnCikis;
    }
}