namespace In_Struct
{
    partial class PocetnaFrm
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
            this.pregledInstrukcijaNeReg = new System.Windows.Forms.Button();
            this.registrirajSeButton = new System.Windows.Forms.Button();
            this.prijavaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pregledInstrukcijaNeReg
            // 
            this.pregledInstrukcijaNeReg.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pregledInstrukcijaNeReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pregledInstrukcijaNeReg.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pregledInstrukcijaNeReg.Location = new System.Drawing.Point(321, 118);
            this.pregledInstrukcijaNeReg.Margin = new System.Windows.Forms.Padding(4);
            this.pregledInstrukcijaNeReg.Name = "pregledInstrukcijaNeReg";
            this.pregledInstrukcijaNeReg.Size = new System.Drawing.Size(162, 62);
            this.pregledInstrukcijaNeReg.TabIndex = 0;
            this.pregledInstrukcijaNeReg.Text = "Pregled instrukcija";
            this.pregledInstrukcijaNeReg.UseVisualStyleBackColor = false;
            this.pregledInstrukcijaNeReg.Click += new System.EventHandler(this.pregledInstrukcijaNeReg_Click);
            // 
            // registrirajSeButton
            // 
            this.registrirajSeButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.registrirajSeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrirajSeButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registrirajSeButton.Location = new System.Drawing.Point(47, 110);
            this.registrirajSeButton.Margin = new System.Windows.Forms.Padding(4);
            this.registrirajSeButton.Name = "registrirajSeButton";
            this.registrirajSeButton.Size = new System.Drawing.Size(179, 51);
            this.registrirajSeButton.TabIndex = 1;
            this.registrirajSeButton.Text = "Registriraj se";
            this.registrirajSeButton.UseVisualStyleBackColor = false;
            this.registrirajSeButton.Click += new System.EventHandler(this.registrirajSeButton_Click);
            // 
            // prijavaButton
            // 
            this.prijavaButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.prijavaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prijavaButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prijavaButton.Location = new System.Drawing.Point(533, 110);
            this.prijavaButton.Margin = new System.Windows.Forms.Padding(4);
            this.prijavaButton.Name = "prijavaButton";
            this.prijavaButton.Size = new System.Drawing.Size(177, 51);
            this.prijavaButton.TabIndex = 2;
            this.prijavaButton.Text = "Prijavi se ";
            this.prijavaButton.UseVisualStyleBackColor = false;
            this.prijavaButton.Click += new System.EventHandler(this.prijavaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Želiš pregledati instrukcije bez prijave ili registracije?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Želiš rezervirati termin instrukcija?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Već imaš račun?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.registrirajSeButton);
            this.groupBox1.Controls.Add(this.prijavaButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 227);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::In_Struct.Properties.Resources._580b57fcd9996e24bc43c43c;
            this.pictureBox1.Location = new System.Drawing.Point(195, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::In_Struct.Properties.Resources._580b57fcd9996e24bc43c43c;
            this.pictureBox2.Location = new System.Drawing.Point(466, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // PocetnaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(782, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pregledInstrukcijaNeReg);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PocetnaFrm";
            this.Text = "Početna stranica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PocetnaFrm_FormClosed);
            this.Load += new System.EventHandler(this.PocetnaFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pregledInstrukcijaNeReg;
        private System.Windows.Forms.Button registrirajSeButton;
        private System.Windows.Forms.Button prijavaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

