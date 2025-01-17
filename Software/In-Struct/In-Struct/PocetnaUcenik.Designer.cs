namespace In_Struct
{
    partial class PocetnaUcenik
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
            this.btnOcisti = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.cmbKriterij = new System.Windows.Forms.ComboBox();
            this.cmbPodatak = new System.Windows.Forms.ComboBox();
            this.dgvPopisInstrukcija = new System.Windows.Forms.DataGridView();
            this.btnOdjavi = new System.Windows.Forms.Button();
            this.btnPopisPohadanih = new System.Windows.Forms.Button();
            this.btnOtkazivanje = new System.Windows.Forms.Button();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisInstrukcija)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOcisti
            // 
            this.btnOcisti.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnOcisti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcisti.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOcisti.Location = new System.Drawing.Point(501, 119);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(148, 76);
            this.btnOcisti.TabIndex = 22;
            this.btnOcisti.Text = "Očisti filter";
            this.btnOcisti.UseVisualStyleBackColor = false;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Podatak pretraživanja:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kriterij pretraživanja:";
            // 
            // btnDetalji
            // 
            this.btnDetalji.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDetalji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalji.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDetalji.Location = new System.Drawing.Point(514, 530);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(135, 59);
            this.btnDetalji.TabIndex = 19;
            this.btnDetalji.Text = "Detalji instrukcije";
            this.btnDetalji.UseVisualStyleBackColor = false;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // cmbKriterij
            // 
            this.cmbKriterij.FormattingEnabled = true;
            this.cmbKriterij.Location = new System.Drawing.Point(321, 119);
            this.cmbKriterij.Name = "cmbKriterij";
            this.cmbKriterij.Size = new System.Drawing.Size(161, 24);
            this.cmbKriterij.TabIndex = 18;
            this.cmbKriterij.SelectedIndexChanged += new System.EventHandler(this.cmbKriterij_SelectedIndexChanged);
            // 
            // cmbPodatak
            // 
            this.cmbPodatak.FormattingEnabled = true;
            this.cmbPodatak.Location = new System.Drawing.Point(321, 171);
            this.cmbPodatak.Name = "cmbPodatak";
            this.cmbPodatak.Size = new System.Drawing.Size(161, 24);
            this.cmbPodatak.TabIndex = 17;
            this.cmbPodatak.SelectedIndexChanged += new System.EventHandler(this.cmbPodatak_SelectedIndexChanged);
            // 
            // dgvPopisInstrukcija
            // 
            this.dgvPopisInstrukcija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisInstrukcija.Location = new System.Drawing.Point(22, 221);
            this.dgvPopisInstrukcija.Name = "dgvPopisInstrukcija";
            this.dgvPopisInstrukcija.RowHeadersWidth = 51;
            this.dgvPopisInstrukcija.RowTemplate.Height = 24;
            this.dgvPopisInstrukcija.Size = new System.Drawing.Size(627, 303);
            this.dgvPopisInstrukcija.TabIndex = 16;
            // 
            // btnOdjavi
            // 
            this.btnOdjavi.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnOdjavi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjavi.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdjavi.Location = new System.Drawing.Point(22, 530);
            this.btnOdjavi.Name = "btnOdjavi";
            this.btnOdjavi.Size = new System.Drawing.Size(120, 59);
            this.btnOdjavi.TabIndex = 23;
            this.btnOdjavi.Text = "Odjava";
            this.btnOdjavi.UseVisualStyleBackColor = false;
            this.btnOdjavi.Click += new System.EventHandler(this.btnOdjavi_Click);
            // 
            // btnPopisPohadanih
            // 
            this.btnPopisPohadanih.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPopisPohadanih.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPopisPohadanih.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPopisPohadanih.Location = new System.Drawing.Point(12, 105);
            this.btnPopisPohadanih.Name = "btnPopisPohadanih";
            this.btnPopisPohadanih.Size = new System.Drawing.Size(130, 50);
            this.btnPopisPohadanih.TabIndex = 24;
            this.btnPopisPohadanih.Text = "Popis pohađanih instrukcija";
            this.btnPopisPohadanih.UseVisualStyleBackColor = false;
            this.btnPopisPohadanih.Click += new System.EventHandler(this.btnPopisPohadanih_Click);
            // 
            // btnOtkazivanje
            // 
            this.btnOtkazivanje.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnOtkazivanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtkazivanje.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOtkazivanje.Location = new System.Drawing.Point(12, 166);
            this.btnOtkazivanje.Name = "btnOtkazivanje";
            this.btnOtkazivanje.Size = new System.Drawing.Size(130, 33);
            this.btnOtkazivanje.TabIndex = 25;
            this.btnOtkazivanje.Text = "Otkaži termin";
            this.btnOtkazivanje.UseVisualStyleBackColor = false;
            this.btnOtkazivanje.Click += new System.EventHandler(this.btnOtkazivanje_Click);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.Location = new System.Drawing.Point(271, 25);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(116, 32);
            this.lblPrezime.TabIndex = 28;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.Location = new System.Drawing.Point(200, 25);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(65, 32);
            this.lblIme.TabIndex = 27;
            this.lblIme.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "Dobrodošli, ";
            // 
            // PocetnaUcenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(669, 594);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOtkazivanje);
            this.Controls.Add(this.btnPopisPohadanih);
            this.Controls.Add(this.btnOdjavi);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.cmbKriterij);
            this.Controls.Add(this.cmbPodatak);
            this.Controls.Add(this.dgvPopisInstrukcija);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "PocetnaUcenik";
            this.Text = "Početna stranica učenika";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PocetnaUcenik_FormClosed);
            this.Load += new System.EventHandler(this.PopisInstrukcijaUcenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisInstrukcija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.ComboBox cmbKriterij;
        private System.Windows.Forms.ComboBox cmbPodatak;
        private System.Windows.Forms.DataGridView dgvPopisInstrukcija;
        private System.Windows.Forms.Button btnOdjavi;
        private System.Windows.Forms.Button btnPopisPohadanih;
        private System.Windows.Forms.Button btnOtkazivanje;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}