namespace In_Struct
{
    partial class UpitOglas
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
            this.daBtn = new System.Windows.Forms.RadioButton();
            this.neBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.odaberiBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // daBtn
            // 
            this.daBtn.AutoSize = true;
            this.daBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.daBtn.Location = new System.Drawing.Point(360, 103);
            this.daBtn.Name = "daBtn";
            this.daBtn.Size = new System.Drawing.Size(54, 24);
            this.daBtn.TabIndex = 0;
            this.daBtn.TabStop = true;
            this.daBtn.Text = "Da";
            this.daBtn.UseVisualStyleBackColor = true;
            // 
            // neBtn
            // 
            this.neBtn.AutoSize = true;
            this.neBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.neBtn.Location = new System.Drawing.Point(511, 103);
            this.neBtn.Name = "neBtn";
            this.neBtn.Size = new System.Drawing.Size(53, 24);
            this.neBtn.TabIndex = 1;
            this.neBtn.TabStop = true;
            this.neBtn.Text = "Ne";
            this.neBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.label1.Location = new System.Drawing.Point(149, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(641, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jeste li sigurni da želite nastaviti? Molimo provjerite još jednom podatke.";
            // 
            // odaberiBtn
            // 
            this.odaberiBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.odaberiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odaberiBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.odaberiBtn.Location = new System.Drawing.Point(780, 151);
            this.odaberiBtn.Name = "odaberiBtn";
            this.odaberiBtn.Size = new System.Drawing.Size(102, 34);
            this.odaberiBtn.TabIndex = 3;
            this.odaberiBtn.Text = "Odaberi";
            this.odaberiBtn.UseVisualStyleBackColor = false;
            this.odaberiBtn.Click += new System.EventHandler(this.odaberiBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.label2.Location = new System.Drawing.Point(67, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(787, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = " Ukoliko kliknete na opciju \"da\", ne možete se više vraćati sve dok ne zakažete i" +
    "nstrukciju";
            // 
            // UpitOglas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(918, 197);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.odaberiBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.neBtn);
            this.Controls.Add(this.daBtn);
            this.Name = "UpitOglas";
            this.Text = "UpitOglas";
            this.Load += new System.EventHandler(this.UpitOglas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton daBtn;
        private System.Windows.Forms.RadioButton neBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button odaberiBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}