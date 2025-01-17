
namespace In_Struct
{
    partial class PocetnaInstruktor
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
            this.dgvZakazaneInstrukcije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrikaziSve = new System.Windows.Forms.Button();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.odabraniDatum = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKalendar = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnIzdajRacun = new System.Windows.Forms.Button();
            this.btnRecenzije = new System.Windows.Forms.Button();
            this.btnPregledOdradenih = new System.Windows.Forms.Button();
            this.btnKreirajOglas = new System.Windows.Forms.Button();
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakazaneInstrukcije)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZakazaneInstrukcije
            // 
            this.dgvZakazaneInstrukcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZakazaneInstrukcije.Location = new System.Drawing.Point(443, 94);
            this.dgvZakazaneInstrukcije.Name = "dgvZakazaneInstrukcije";
            this.dgvZakazaneInstrukcije.RowHeadersWidth = 51;
            this.dgvZakazaneInstrukcije.RowTemplate.Height = 24;
            this.dgvZakazaneInstrukcije.Size = new System.Drawing.Size(813, 251);
            this.dgvZakazaneInstrukcije.TabIndex = 0;
            this.dgvZakazaneInstrukcije.SelectionChanged += new System.EventHandler(this.dgvZakazaneInstrukcije_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dobrodošli, ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrikaziSve);
            this.groupBox1.Controls.Add(this.btnOdaberi);
            this.groupBox1.Controls.Add(this.odabraniDatum);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(31, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 142);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prikaz instrukcija";
            // 
            // btnPrikaziSve
            // 
            this.btnPrikaziSve.AutoSize = true;
            this.btnPrikaziSve.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrikaziSve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrikaziSve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikaziSve.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrikaziSve.Location = new System.Drawing.Point(213, 86);
            this.btnPrikaziSve.Name = "btnPrikaziSve";
            this.btnPrikaziSve.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrikaziSve.Size = new System.Drawing.Size(123, 50);
            this.btnPrikaziSve.TabIndex = 2;
            this.btnPrikaziSve.Text = "Prikaži sve";
            this.btnPrikaziSve.UseVisualStyleBackColor = false;
            this.btnPrikaziSve.Click += new System.EventHandler(this.btnPrikaziSve_Click);
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.AutoSize = true;
            this.btnOdaberi.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnOdaberi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdaberi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdaberi.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdaberi.Location = new System.Drawing.Point(85, 86);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOdaberi.Size = new System.Drawing.Size(122, 50);
            this.btnOdaberi.TabIndex = 1;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = false;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // odabraniDatum
            // 
            this.odabraniDatum.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odabraniDatum.Location = new System.Drawing.Point(17, 41);
            this.odabraniDatum.Name = "odabraniDatum";
            this.odabraniDatum.Size = new System.Drawing.Size(322, 26);
            this.odabraniDatum.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKalendar);
            this.groupBox2.Controls.Add(this.btnOdjava);
            this.groupBox2.Controls.Add(this.btnIzdajRacun);
            this.groupBox2.Controls.Add(this.btnRecenzije);
            this.groupBox2.Controls.Add(this.btnPregledOdradenih);
            this.groupBox2.Controls.Add(this.btnKreirajOglas);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(31, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 423);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Moj meni";
            // 
            // btnKalendar
            // 
            this.btnKalendar.AutoSize = true;
            this.btnKalendar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnKalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKalendar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKalendar.Location = new System.Drawing.Point(19, 101);
            this.btnKalendar.Name = "btnKalendar";
            this.btnKalendar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnKalendar.Size = new System.Drawing.Size(322, 43);
            this.btnKalendar.TabIndex = 6;
            this.btnKalendar.Text = "Kalendarski prikaz instrukcija";
            this.btnKalendar.UseVisualStyleBackColor = false;
            this.btnKalendar.Click += new System.EventHandler(this.btnKalendar_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.AutoSize = true;
            this.btnOdjava.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnOdjava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdjava.Location = new System.Drawing.Point(19, 349);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOdjava.Size = new System.Drawing.Size(320, 42);
            this.btnOdjava.TabIndex = 4;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnIzdajRacun
            // 
            this.btnIzdajRacun.AutoSize = true;
            this.btnIzdajRacun.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnIzdajRacun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzdajRacun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzdajRacun.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzdajRacun.Location = new System.Drawing.Point(17, 282);
            this.btnIzdajRacun.Name = "btnIzdajRacun";
            this.btnIzdajRacun.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIzdajRacun.Size = new System.Drawing.Size(322, 43);
            this.btnIzdajRacun.TabIndex = 3;
            this.btnIzdajRacun.Text = "Izdaj račun";
            this.btnIzdajRacun.UseVisualStyleBackColor = false;
            this.btnIzdajRacun.Click += new System.EventHandler(this.btnIzdajRacun_Click);
            // 
            // btnRecenzije
            // 
            this.btnRecenzije.AutoSize = true;
            this.btnRecenzije.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRecenzije.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecenzije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecenzije.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRecenzije.Location = new System.Drawing.Point(19, 221);
            this.btnRecenzije.Name = "btnRecenzije";
            this.btnRecenzije.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRecenzije.Size = new System.Drawing.Size(322, 43);
            this.btnRecenzije.TabIndex = 2;
            this.btnRecenzije.Text = "Pregled mojih recenzija";
            this.btnRecenzije.UseVisualStyleBackColor = false;
            this.btnRecenzije.Click += new System.EventHandler(this.btnRecenzije_Click);
            // 
            // btnPregledOdradenih
            // 
            this.btnPregledOdradenih.AutoSize = true;
            this.btnPregledOdradenih.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPregledOdradenih.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPregledOdradenih.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregledOdradenih.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPregledOdradenih.Location = new System.Drawing.Point(19, 160);
            this.btnPregledOdradenih.Name = "btnPregledOdradenih";
            this.btnPregledOdradenih.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPregledOdradenih.Size = new System.Drawing.Size(322, 43);
            this.btnPregledOdradenih.TabIndex = 1;
            this.btnPregledOdradenih.Text = "Pregled odrađenih instrukcija";
            this.btnPregledOdradenih.UseVisualStyleBackColor = false;
            this.btnPregledOdradenih.Click += new System.EventHandler(this.btnPregledOdradenih_Click);
            // 
            // btnKreirajOglas
            // 
            this.btnKreirajOglas.AutoSize = true;
            this.btnKreirajOglas.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnKreirajOglas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKreirajOglas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKreirajOglas.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKreirajOglas.Location = new System.Drawing.Point(19, 42);
            this.btnKreirajOglas.Name = "btnKreirajOglas";
            this.btnKreirajOglas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnKreirajOglas.Size = new System.Drawing.Size(322, 43);
            this.btnKreirajOglas.TabIndex = 0;
            this.btnKreirajOglas.Text = "Kreiraj oglas";
            this.btnKreirajOglas.UseVisualStyleBackColor = false;
            this.btnKreirajOglas.Click += new System.EventHandler(this.btnKreirajOglas_Click);
            // 
            // dgvTermini
            // 
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Location = new System.Drawing.Point(443, 382);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.RowHeadersWidth = 51;
            this.dgvTermini.RowTemplate.Height = 24;
            this.dgvTermini.Size = new System.Drawing.Size(813, 251);
            this.dgvTermini.TabIndex = 5;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.Location = new System.Drawing.Point(209, 31);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(65, 32);
            this.lblIme.TabIndex = 6;
            this.lblIme.Text = "Ime";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.Location = new System.Drawing.Point(301, 31);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(116, 32);
            this.lblPrezime.TabIndex = 7;
            this.lblPrezime.Text = "Prezime";
            // 
            // PocetnaInstruktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1313, 696);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.dgvTermini);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvZakazaneInstrukcije);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PocetnaInstruktor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početna stranica instruktora";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PocetnaInstruktor_FormClosed);
            this.Load += new System.EventHandler(this.PocetnaInstruktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakazaneInstrukcije)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZakazaneInstrukcije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.DateTimePicker odabraniDatum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnIzdajRacun;
        private System.Windows.Forms.Button btnRecenzije;
        private System.Windows.Forms.Button btnPregledOdradenih;
        private System.Windows.Forms.Button btnKreirajOglas;
        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.Button btnPrikaziSve;
        private System.Windows.Forms.Button btnKalendar;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}