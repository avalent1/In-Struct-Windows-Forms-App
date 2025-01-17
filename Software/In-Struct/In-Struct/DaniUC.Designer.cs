
namespace In_Struct
{
    partial class DaniUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDan
            // 
            this.lblDan.AutoSize = true;
            this.lblDan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDan.Location = new System.Drawing.Point(57, 46);
            this.lblDan.Name = "lblDan";
            this.lblDan.Size = new System.Drawing.Size(40, 25);
            this.lblDan.TabIndex = 0;
            this.lblDan.Text = "00";
            // 
            // DaniUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.Controls.Add(this.lblDan);
            this.Name = "DaniUC";
            this.Size = new System.Drawing.Size(163, 114);
            this.Load += new System.EventHandler(this.DaniUC_Load);
            this.Click += new System.EventHandler(this.DaniUC_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDan;
    }
}
