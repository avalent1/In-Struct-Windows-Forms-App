namespace In_Struct
{
    partial class _2FaktorAutent
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
            this.label1 = new System.Windows.Forms.Label();
            this.KodBtn = new System.Windows.Forms.TextBox();
            this.PotvrdiBtn = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.label1.Location = new System.Drawing.Point(98, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(914, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poslana je poruka sa kodom za prijavu na Vašu e-mail adresu. Molimo upišite kod k" +
    "oji se nalazi u poruci.";
            // 
            // KodBtn
            // 
            this.KodBtn.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.KodBtn.Location = new System.Drawing.Point(438, 150);
            this.KodBtn.Name = "KodBtn";
            this.KodBtn.Size = new System.Drawing.Size(227, 28);
            this.KodBtn.TabIndex = 1;
            this.KodBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KodBtn_KeyDown);
            // 
            // PotvrdiBtn
            // 
            this.PotvrdiBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PotvrdiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.PotvrdiBtn.Location = new System.Drawing.Point(825, 187);
            this.PotvrdiBtn.Name = "PotvrdiBtn";
            this.PotvrdiBtn.Size = new System.Drawing.Size(101, 38);
            this.PotvrdiBtn.TabIndex = 2;
            this.PotvrdiBtn.Text = "Potvrdi";
            this.PotvrdiBtn.UseVisualStyleBackColor = false;
            this.PotvrdiBtn.Click += new System.EventHandler(this.PotvrdiBtn_Click);
            // 
            // _2FaktorAutent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1077, 237);
            this.Controls.Add(this.PotvrdiBtn);
            this.Controls.Add(this.KodBtn);
            this.Controls.Add(this.label1);
            this.Name = "_2FaktorAutent";
            this.Text = "2FaktorAutentifikacija";
            this.Load += new System.EventHandler(this._2FaktorAutent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KodBtn;
        private System.Windows.Forms.Button PotvrdiBtn;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}