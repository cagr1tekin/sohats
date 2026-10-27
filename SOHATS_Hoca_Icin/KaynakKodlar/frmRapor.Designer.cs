namespace SOHATS
{
    partial class frmRapor
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
            System.Windows.Forms.Label lblBaslangicTarih;
            System.Windows.Forms.Label lblBitisTarih;
            System.Windows.Forms.Label lblPoliklinik;
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.cmbPoliklinik = new System.Windows.Forms.ComboBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.dgvRapor = new System.Windows.Forms.DataGridView();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            lblBaslangicTarih = new System.Windows.Forms.Label();
            lblBitisTarih = new System.Windows.Forms.Label();
            lblPoliklinik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslangicTarih
            // 
            lblBaslangicTarih.AutoSize = true;
            lblBaslangicTarih.Location = new System.Drawing.Point(20, 23);
            lblBaslangicTarih.Name = "lblBaslangicTarih";
            lblBaslangicTarih.Size = new System.Drawing.Size(106, 16);
            lblBaslangicTarih.TabIndex = 6;
            lblBaslangicTarih.Text = "Başlangıç Tarihi:";
            // 
            // lblBitisTarih
            // 
            lblBitisTarih.AutoSize = true;
            lblBitisTarih.Location = new System.Drawing.Point(300, 23);
            lblBitisTarih.Name = "lblBitisTarih";
            lblBitisTarih.Size = new System.Drawing.Size(72, 16);
            lblBitisTarih.TabIndex = 7;
            lblBitisTarih.Text = "Bitiş Tarihi:";
            // 
            // lblPoliklinik
            // 
            lblPoliklinik.AutoSize = true;
            lblPoliklinik.Location = new System.Drawing.Point(20, 63);
            lblPoliklinik.Name = "lblPoliklinik";
            lblPoliklinik.Size = new System.Drawing.Size(65, 16);
            lblPoliklinik.TabIndex = 8;
            lblPoliklinik.Text = "Poliklinik:";
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslangic.Location = new System.Drawing.Point(130, 20);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(150, 22);
            this.dtpBaslangic.TabIndex = 0;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBitis.Location = new System.Drawing.Point(380, 20);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(150, 22);
            this.dtpBitis.TabIndex = 1;
            // 
            // cmbPoliklinik
            // 
            this.cmbPoliklinik.FormattingEnabled = true;
            this.cmbPoliklinik.Location = new System.Drawing.Point(130, 60);
            this.cmbPoliklinik.Name = "cmbPoliklinik";
            this.cmbPoliklinik.Size = new System.Drawing.Size(200, 24);
            this.cmbPoliklinik.TabIndex = 2;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(350, 58);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(90, 28);
            this.btnListele.TabIndex = 3;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(450, 58);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(90, 28);
            this.btnYazdir.TabIndex = 4;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // dgvRapor
            // 
            this.dgvRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapor.Location = new System.Drawing.Point(20, 110);
            this.dgvRapor.Name = "dgvRapor";
            this.dgvRapor.RowHeadersWidth = 51;
            this.dgvRapor.RowTemplate.Height = 24;
            this.dgvRapor.Size = new System.Drawing.Size(750, 300);
            this.dgvRapor.TabIndex = 5;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(550, 425);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(139, 25);
            this.lblToplamTutar.TabIndex = 6;
            this.lblToplamTutar.Text = "Toplam: 0.00";
            // 
            // frmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(lblPoliklinik);
            this.Controls.Add(lblBitisTarih);
            this.Controls.Add(lblBaslangicTarih);
            this.Controls.Add(this.dgvRapor);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.cmbPoliklinik);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Name = "frmRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.frmRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.ComboBox cmbPoliklinik;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.DataGridView dgvRapor;
        private System.Windows.Forms.Label lblToplamTutar;
    }
}
