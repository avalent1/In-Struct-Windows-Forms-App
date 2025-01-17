
namespace In_Struct
{
    partial class PopisInstrukcijaNereg
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
            this.btnPocetna = new System.Windows.Forms.Button();
            this.dgvPopisInstrukcija = new System.Windows.Forms.DataGridView();
            this.cmbPodatak = new System.Windows.Forms.ComboBox();
            this.cmbKriterij = new System.Windows.Forms.ComboBox();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisInstrukcija)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPocetna
            // 
            this.btnPocetna.Location = new System.Drawing.Point(12, 27);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(111, 44);
            this.btnPocetna.TabIndex = 0;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.UseVisualStyleBackColor = true;
            this.btnPocetna.Click += new System.EventHandler(this.btnPocetna_Click);
            // 
            // dgvPopisInstrukcija
            // 
            this.dgvPopisInstrukcija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisInstrukcija.Location = new System.Drawing.Point(173, 80);
            this.dgvPopisInstrukcija.Name = "dgvPopisInstrukcija";
            this.dgvPopisInstrukcija.RowHeadersWidth = 51;
            this.dgvPopisInstrukcija.RowTemplate.Height = 24;
            this.dgvPopisInstrukcija.Size = new System.Drawing.Size(627, 303);
            this.dgvPopisInstrukcija.TabIndex = 1;
            // 
            // cmbPodatak
            // 
            this.cmbPodatak.FormattingEnabled = true;
            this.cmbPodatak.Location = new System.Drawing.Point(598, 36);
            this.cmbPodatak.Name = "cmbPodatak";
            this.cmbPodatak.Size = new System.Drawing.Size(121, 24);
            this.cmbPodatak.TabIndex = 2;
            this.cmbPodatak.SelectedIndexChanged += new System.EventHandler(this.cmbPodatak_SelectedIndexChanged);
            // 
            // cmbKriterij
            // 
            this.cmbKriterij.FormattingEnabled = true;
            this.cmbKriterij.Location = new System.Drawing.Point(318, 36);
            this.cmbKriterij.Name = "cmbKriterij";
            this.cmbKriterij.Size = new System.Drawing.Size(121, 24);
            this.cmbKriterij.TabIndex = 3;
            this.cmbKriterij.SelectedIndexChanged += new System.EventHandler(this.cmbKriterij_SelectedIndexChanged);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(665, 406);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(135, 32);
            this.btnDetalji.TabIndex = 4;
            this.btnDetalji.Text = "Detalji instrukcije";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kriterij pretraživanja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Podatak pretraživanja:";
            // 
            // btnOcisti
            // 
            this.btnOcisti.Location = new System.Drawing.Point(725, 25);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(75, 44);
            this.btnOcisti.TabIndex = 7;
            this.btnOcisti.Text = "Očisti filter";
            this.btnOcisti.UseVisualStyleBackColor = true;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // PopisInstrukcijaNereg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.cmbKriterij);
            this.Controls.Add(this.cmbPodatak);
            this.Controls.Add(this.dgvPopisInstrukcija);
            this.Controls.Add(this.btnPocetna);
            this.Name = "PopisInstrukcijaNereg";
            this.Text = "PopisInstrukcijaFrm";
            this.Load += new System.EventHandler(this.PopisInstrukcijaNereg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisInstrukcija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.DataGridView dgvPopisInstrukcija;
        private System.Windows.Forms.ComboBox cmbPodatak;
        private System.Windows.Forms.ComboBox cmbKriterij;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}