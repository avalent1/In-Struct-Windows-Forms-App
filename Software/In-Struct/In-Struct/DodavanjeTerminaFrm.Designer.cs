
namespace In_Struct
{
    partial class DodavanjeTerminaFrm
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
            this.BrojMjestaTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OdustaniBtn = new System.Windows.Forms.Button();
            this.DodajTerminBtn = new System.Windows.Forms.Button();
            this.datumPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.vrijemePicker = new System.Windows.Forms.DateTimePicker();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.label1.Location = new System.Drawing.Point(33, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj mjesta";
            // 
            // BrojMjestaTxtBox
            // 
            this.BrojMjestaTxtBox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.BrojMjestaTxtBox.Location = new System.Drawing.Point(161, 53);
            this.BrojMjestaTxtBox.Name = "BrojMjestaTxtBox";
            this.BrojMjestaTxtBox.Size = new System.Drawing.Size(366, 28);
            this.BrojMjestaTxtBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.label3.Location = new System.Drawing.Point(33, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum";
            // 
            // OdustaniBtn
            // 
            this.OdustaniBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.OdustaniBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.OdustaniBtn.Location = new System.Drawing.Point(34, 377);
            this.OdustaniBtn.Name = "OdustaniBtn";
            this.OdustaniBtn.Size = new System.Drawing.Size(108, 45);
            this.OdustaniBtn.TabIndex = 6;
            this.OdustaniBtn.Text = "Odustani";
            this.OdustaniBtn.UseVisualStyleBackColor = false;
            this.OdustaniBtn.Click += new System.EventHandler(this.OdustaniBtn_Click);
            // 
            // DodajTerminBtn
            // 
            this.DodajTerminBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.DodajTerminBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.DodajTerminBtn.Location = new System.Drawing.Point(400, 377);
            this.DodajTerminBtn.Name = "DodajTerminBtn";
            this.DodajTerminBtn.Size = new System.Drawing.Size(107, 45);
            this.DodajTerminBtn.TabIndex = 7;
            this.DodajTerminBtn.Text = "Dodaj";
            this.DodajTerminBtn.UseVisualStyleBackColor = false;
            this.DodajTerminBtn.Click += new System.EventHandler(this.DodajTerminBtn_Click);
            // 
            // datumPicker
            // 
            this.datumPicker.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.datumPicker.Location = new System.Drawing.Point(161, 135);
            this.datumPicker.Name = "datumPicker";
            this.datumPicker.Size = new System.Drawing.Size(366, 28);
            this.datumPicker.TabIndex = 8;
            this.datumPicker.Value = new System.DateTime(2023, 7, 3, 17, 15, 32, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.label2.Location = new System.Drawing.Point(33, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vrijeme";
            // 
            // vrijemePicker
            // 
            this.vrijemePicker.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.vrijemePicker.Location = new System.Drawing.Point(161, 92);
            this.vrijemePicker.Name = "vrijemePicker";
            this.vrijemePicker.Size = new System.Drawing.Size(366, 28);
            this.vrijemePicker.TabIndex = 9;
            this.vrijemePicker.Value = new System.DateTime(2023, 7, 3, 17, 15, 32, 0);
            // 
            // DodavanjeTerminaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.vrijemePicker);
            this.Controls.Add(this.datumPicker);
            this.Controls.Add(this.DodajTerminBtn);
            this.Controls.Add(this.OdustaniBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BrojMjestaTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodavanjeTerminaFrm";
            this.Text = "DodavanjeTerminaFrm";
            this.Load += new System.EventHandler(this.DodavanjeTerminaFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BrojMjestaTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OdustaniBtn;
        private System.Windows.Forms.Button DodajTerminBtn;
        private System.Windows.Forms.DateTimePicker datumPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker vrijemePicker;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}