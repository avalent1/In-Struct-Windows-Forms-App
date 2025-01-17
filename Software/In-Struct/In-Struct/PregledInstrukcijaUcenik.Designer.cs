
namespace In_Struct
{
    partial class PregledInstrukcijaUcenik
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
            this.PopisOdradenihInstrukcijaDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ZatvoriBtn = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.DodajRecenzijuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PopisOdradenihInstrukcijaDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // PopisOdradenihInstrukcijaDgv
            // 
            this.PopisOdradenihInstrukcijaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PopisOdradenihInstrukcijaDgv.Location = new System.Drawing.Point(52, 72);
            this.PopisOdradenihInstrukcijaDgv.Name = "PopisOdradenihInstrukcijaDgv";
            this.PopisOdradenihInstrukcijaDgv.RowHeadersWidth = 51;
            this.PopisOdradenihInstrukcijaDgv.RowTemplate.Height = 24;
            this.PopisOdradenihInstrukcijaDgv.Size = new System.Drawing.Size(750, 303);
            this.PopisOdradenihInstrukcijaDgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.label1.Location = new System.Drawing.Point(48, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popis odrađenih instrukcija";
            // 
            // ZatvoriBtn
            // 
            this.ZatvoriBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ZatvoriBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.ZatvoriBtn.Location = new System.Drawing.Point(733, 401);
            this.ZatvoriBtn.Name = "ZatvoriBtn";
            this.ZatvoriBtn.Size = new System.Drawing.Size(111, 37);
            this.ZatvoriBtn.TabIndex = 2;
            this.ZatvoriBtn.Text = "Zatvori";
            this.ZatvoriBtn.UseVisualStyleBackColor = false;
            this.ZatvoriBtn.Click += new System.EventHandler(this.ZatvoriBtn_Click);
            // 
            // DodajRecenzijuBtn
            // 
            this.DodajRecenzijuBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.DodajRecenzijuBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.DodajRecenzijuBtn.Location = new System.Drawing.Point(610, 23);
            this.DodajRecenzijuBtn.Name = "DodajRecenzijuBtn";
            this.DodajRecenzijuBtn.Size = new System.Drawing.Size(234, 40);
            this.DodajRecenzijuBtn.TabIndex = 3;
            this.DodajRecenzijuBtn.Text = "Dodaj recenziju";
            this.DodajRecenzijuBtn.UseVisualStyleBackColor = false;
            this.DodajRecenzijuBtn.Click += new System.EventHandler(this.DodajRecenzijuBtn_Click);
            // 
            // PregledInstrukcijaUcenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.DodajRecenzijuBtn);
            this.Controls.Add(this.ZatvoriBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PopisOdradenihInstrukcijaDgv);
            this.Name = "PregledInstrukcijaUcenik";
            this.Text = "PregledInstrukcijaUcenik";
            this.Load += new System.EventHandler(this.PregledInstrukcijaUcenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PopisOdradenihInstrukcijaDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PopisOdradenihInstrukcijaDgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ZatvoriBtn;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button DodajRecenzijuBtn;
    }
}