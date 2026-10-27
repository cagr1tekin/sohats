namespace SOHATS
{
    partial class frmDosyaBul
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
            System.Windows.Forms.Label lblArama;
            this.cmbAramaKriteri = new System.Windows.Forms.ComboBox();
            this.txtAramaKriteri = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.dgvSonuclar = new System.Windows.Forms.DataGridView();
            lblArama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuclar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArama
            // 
            lblArama.AutoSize = true;
            lblArama.Location = new System.Drawing.Point(12, 15);
            lblArama.Name = "lblArama";
            lblArama.Size = new System.Drawing.Size(95, 16);
            lblArama.TabIndex = 4;
            lblArama.Text = "Arama Kriteri:";
            // 
            // cmbAramaKriteri
            // 
            this.cmbAramaKriteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAramaKriteri.FormattingEnabled = true;
            this.cmbAramaKriteri.Items.AddRange(new object[] {
            "Kimlik No",
            "Ad",
            "Soyad",
            "Dosya No"});
            this.cmbAramaKriteri.Location = new System.Drawing.Point(113, 12);
            this.cmbAramaKriteri.Name = "cmbAramaKriteri";
            this.cmbAramaKriteri.Size = new System.Drawing.Size(120, 24);
            this.cmbAramaKriteri.TabIndex = 0;
            // 
            // txtAramaKriteri
            // 
            this.txtAramaKriteri.Location = new System.Drawing.Point(239, 12);
            this.txtAramaKriteri.Name = "txtAramaKriteri";
            this.txtAramaKriteri.Size = new System.Drawing.Size(200, 22);
            this.txtAramaKriteri.TabIndex = 1;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(445, 10);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 26);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // dgvSonuclar
            // 
            this.dgvSonuclar.AllowUserToAddRows = false;
            this.dgvSonuclar.AllowUserToDeleteRows = false;
            this.dgvSonuclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSonuclar.Location = new System.Drawing.Point(12, 45);
            this.dgvSonuclar.Name = "dgvSonuclar";
            this.dgvSonuclar.ReadOnly = true;
            this.dgvSonuclar.RowHeadersWidth = 51;
            this.dgvSonuclar.RowTemplate.Height = 24;
            this.dgvSonuclar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSonuclar.Size = new System.Drawing.Size(508, 350);
            this.dgvSonuclar.TabIndex = 3;
            this.dgvSonuclar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSonuclar_CellDoubleClick);
            // 
            // frmDosyaBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 407);
            this.Controls.Add(lblArama);
            this.Controls.Add(this.dgvSonuclar);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtAramaKriteri);
            this.Controls.Add(this.cmbAramaKriteri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDosyaBul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "< Dosya Bul >";
            this.Load += new System.EventHandler(this.frmDosyaBul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAramaKriteri;
        private System.Windows.Forms.TextBox txtAramaKriteri;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.DataGridView dgvSonuclar;
    }
}