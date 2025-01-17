
namespace In_Struct
{
    partial class KalendarskiPrikazFrm
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
            this.DayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMjesecNaprijed = new System.Windows.Forms.Button();
            this.btnMjesecNazad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mjesecGodina = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DayContainer
            // 
            this.DayContainer.Location = new System.Drawing.Point(12, 96);
            this.DayContainer.Name = "DayContainer";
            this.DayContainer.Size = new System.Drawing.Size(1190, 702);
            this.DayContainer.TabIndex = 0;
            this.DayContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.DayContainer_Paint);
            // 
            // btnMjesecNaprijed
            // 
            this.btnMjesecNaprijed.Location = new System.Drawing.Point(1083, 815);
            this.btnMjesecNaprijed.Name = "btnMjesecNaprijed";
            this.btnMjesecNaprijed.Size = new System.Drawing.Size(119, 36);
            this.btnMjesecNaprijed.TabIndex = 1;
            this.btnMjesecNaprijed.Text = "Sljedeći";
            this.btnMjesecNaprijed.UseVisualStyleBackColor = true;
            this.btnMjesecNaprijed.Click += new System.EventHandler(this.btnMjesecNaprijed_Click);
            // 
            // btnMjesecNazad
            // 
            this.btnMjesecNazad.Location = new System.Drawing.Point(958, 815);
            this.btnMjesecNazad.Name = "btnMjesecNazad";
            this.btnMjesecNazad.Size = new System.Drawing.Size(119, 36);
            this.btnMjesecNazad.TabIndex = 2;
            this.btnMjesecNazad.Text = "Prijašnji";
            this.btnMjesecNazad.UseVisualStyleBackColor = true;
            this.btnMjesecNazad.Click += new System.EventHandler(this.btnMjesecNazad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nedjelja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Utorak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(731, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Četvrtak";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Srijeda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ponedjeljak";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1079, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Subota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(905, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Petak";
            // 
            // mjesecGodina
            // 
            this.mjesecGodina.AutoSize = true;
            this.mjesecGodina.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mjesecGodina.Location = new System.Drawing.Point(483, 13);
            this.mjesecGodina.Name = "mjesecGodina";
            this.mjesecGodina.Size = new System.Drawing.Size(83, 29);
            this.mjesecGodina.TabIndex = 8;
            this.mjesecGodina.Text = "label8";
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(12, 815);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(119, 36);
            this.btnNazad.TabIndex = 9;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // KalendarskiPrikazFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 876);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.mjesecGodina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMjesecNazad);
            this.Controls.Add(this.btnMjesecNaprijed);
            this.Controls.Add(this.DayContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KalendarskiPrikazFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KalendarskiPrikazFrm";
            this.Load += new System.EventHandler(this.KalendarskiPrikazFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel DayContainer;
        private System.Windows.Forms.Button btnMjesecNaprijed;
        private System.Windows.Forms.Button btnMjesecNazad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label mjesecGodina;
        private System.Windows.Forms.Button btnNazad;
    }
}