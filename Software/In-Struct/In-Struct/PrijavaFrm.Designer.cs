
namespace In_Struct
{
    partial class PrijavaFrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.korImeTxtBox = new System.Windows.Forms.TextBox();
            this.lozinkaTxtBox = new System.Windows.Forms.TextBox();
            this.nazadButton = new System.Windows.Forms.Button();
            this.prijaviSeButton = new System.Windows.Forms.Button();
            this.sakrijPokaziLozinku = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lozinka:";
            // 
            // korImeTxtBox
            // 
            this.korImeTxtBox.Location = new System.Drawing.Point(270, 84);
            this.korImeTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.korImeTxtBox.Name = "korImeTxtBox";
            this.korImeTxtBox.Size = new System.Drawing.Size(190, 28);
            this.korImeTxtBox.TabIndex = 2;
            // 
            // lozinkaTxtBox
            // 
            this.lozinkaTxtBox.Location = new System.Drawing.Point(270, 162);
            this.lozinkaTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.lozinkaTxtBox.Name = "lozinkaTxtBox";
            this.lozinkaTxtBox.PasswordChar = '●';
            this.lozinkaTxtBox.Size = new System.Drawing.Size(190, 28);
            this.lozinkaTxtBox.TabIndex = 3;
            this.lozinkaTxtBox.TextChanged += new System.EventHandler(this.lozinkaTxtBox_TextChanged);
            this.lozinkaTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lozinkaTxtBox_KeyDown);
            // 
            // nazadButton
            // 
            this.nazadButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.nazadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nazadButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazadButton.Location = new System.Drawing.Point(192, 242);
            this.nazadButton.Margin = new System.Windows.Forms.Padding(4);
            this.nazadButton.Name = "nazadButton";
            this.nazadButton.Size = new System.Drawing.Size(128, 55);
            this.nazadButton.TabIndex = 4;
            this.nazadButton.Text = "Nazad";
            this.nazadButton.UseVisualStyleBackColor = false;
            this.nazadButton.Click += new System.EventHandler(this.nazadButton_Click);
            // 
            // prijaviSeButton
            // 
            this.prijaviSeButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.prijaviSeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prijaviSeButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prijaviSeButton.Location = new System.Drawing.Point(332, 242);
            this.prijaviSeButton.Margin = new System.Windows.Forms.Padding(4);
            this.prijaviSeButton.Name = "prijaviSeButton";
            this.prijaviSeButton.Size = new System.Drawing.Size(128, 55);
            this.prijaviSeButton.TabIndex = 5;
            this.prijaviSeButton.Text = "Prijavi se ";
            this.prijaviSeButton.UseVisualStyleBackColor = false;
            this.prijaviSeButton.Click += new System.EventHandler(this.prijaviSeButton_Click);
            // 
            // sakrijPokaziLozinku
            // 
            this.sakrijPokaziLozinku.BackColor = System.Drawing.Color.LightSeaGreen;
            this.sakrijPokaziLozinku.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.sakrijPokaziLozinku.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sakrijPokaziLozinku.Location = new System.Drawing.Point(467, 162);
            this.sakrijPokaziLozinku.Name = "sakrijPokaziLozinku";
            this.sakrijPokaziLozinku.Size = new System.Drawing.Size(165, 30);
            this.sakrijPokaziLozinku.TabIndex = 6;
            this.sakrijPokaziLozinku.Text = "Prikaži lozinku";
            this.sakrijPokaziLozinku.UseVisualStyleBackColor = false;
            this.sakrijPokaziLozinku.Click += new System.EventHandler(this.sakrijPokaziLozinku_Click);
            // 
            // PrijavaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(644, 342);
            this.Controls.Add(this.sakrijPokaziLozinku);
            this.Controls.Add(this.prijaviSeButton);
            this.Controls.Add(this.nazadButton);
            this.Controls.Add(this.lozinkaTxtBox);
            this.Controls.Add(this.korImeTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrijavaFrm";
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.PrijavaFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox korImeTxtBox;
        private System.Windows.Forms.TextBox lozinkaTxtBox;
        private System.Windows.Forms.Button nazadButton;
        private System.Windows.Forms.Button prijaviSeButton;
        private System.Windows.Forms.Button sakrijPokaziLozinku;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}