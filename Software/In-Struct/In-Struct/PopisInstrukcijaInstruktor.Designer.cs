
namespace In_Struct
{
    partial class PopisInstrukcijaInstruktor
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
            this.btnNazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisInstrukcija)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOcisti
            // 
            this.btnOcisti.Location = new System.Drawing.Point(584, 15);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(72, 55);
            this.btnOcisti.TabIndex = 15;
            this.btnOcisti.Text = "Očisti filter";
            this.btnOcisti.UseVisualStyleBackColor = true;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Podatak pretraživanja:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kriterij pretraživanja:";
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(515, 384);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(141, 49);
            this.btnDetalji.TabIndex = 12;
            this.btnDetalji.Text = "Detalji instrukcije";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // cmbKriterij
            // 
            this.cmbKriterij.FormattingEnabled = true;
            this.cmbKriterij.Location = new System.Drawing.Point(174, 32);
            this.cmbKriterij.Name = "cmbKriterij";
            this.cmbKriterij.Size = new System.Drawing.Size(121, 24);
            this.cmbKriterij.TabIndex = 11;
            this.cmbKriterij.SelectedIndexChanged += new System.EventHandler(this.cmbKriterij_SelectedIndexChanged);
            // 
            // cmbPodatak
            // 
            this.cmbPodatak.FormattingEnabled = true;
            this.cmbPodatak.Location = new System.Drawing.Point(457, 31);
            this.cmbPodatak.Name = "cmbPodatak";
            this.cmbPodatak.Size = new System.Drawing.Size(121, 24);
            this.cmbPodatak.TabIndex = 10;
            this.cmbPodatak.SelectedIndexChanged += new System.EventHandler(this.cmbPodatak_SelectedIndexChanged);
            // 
            // dgvPopisInstrukcija
            // 
            this.dgvPopisInstrukcija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisInstrukcija.Location = new System.Drawing.Point(29, 75);
            this.dgvPopisInstrukcija.Name = "dgvPopisInstrukcija";
            this.dgvPopisInstrukcija.RowHeadersWidth = 51;
            this.dgvPopisInstrukcija.RowTemplate.Height = 24;
            this.dgvPopisInstrukcija.Size = new System.Drawing.Size(627, 303);
            this.dgvPopisInstrukcija.TabIndex = 9;
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(29, 384);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(114, 49);
            this.btnNazad.TabIndex = 8;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnOdjavi_Click);
            // 
            // PopisInstrukcijaInstruktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(694, 452);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.cmbKriterij);
            this.Controls.Add(this.cmbPodatak);
            this.Controls.Add(this.dgvPopisInstrukcija);
            this.Controls.Add(this.btnNazad);
            this.Name = "PopisInstrukcijaInstruktor";
            this.Text = "PopisInstrukcijaInstruktor";
            this.Load += new System.EventHandler(this.PopisInstrukcijaInstruktor_Load);
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
        private System.Windows.Forms.Button btnNazad;
    }
}