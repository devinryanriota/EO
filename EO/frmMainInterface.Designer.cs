namespace EO
{
    partial class frmMainInterface
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnRegisterCustomer = new System.Windows.Forms.Button();
            this.btnRancanganCustomer = new System.Windows.Forms.Button();
            this.btnPerjanjianKerja = new System.Windows.Forms.Button();
            this.btnPembayaranDP = new System.Windows.Forms.Button();
            this.btnJatuhTempo = new System.Windows.Forms.Button();
            this.btnBuktiPelunasan = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(584, 65);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(245, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(65, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Main";
            // 
            // btnRegisterCustomer
            // 
            this.btnRegisterCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterCustomer.Location = new System.Drawing.Point(42, 81);
            this.btnRegisterCustomer.Name = "btnRegisterCustomer";
            this.btnRegisterCustomer.Size = new System.Drawing.Size(205, 62);
            this.btnRegisterCustomer.TabIndex = 3;
            this.btnRegisterCustomer.Text = "Customer";
            this.btnRegisterCustomer.UseVisualStyleBackColor = true;
            // 
            // btnRancanganCustomer
            // 
            this.btnRancanganCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRancanganCustomer.Location = new System.Drawing.Point(328, 81);
            this.btnRancanganCustomer.Name = "btnRancanganCustomer";
            this.btnRancanganCustomer.Size = new System.Drawing.Size(205, 62);
            this.btnRancanganCustomer.TabIndex = 4;
            this.btnRancanganCustomer.Text = "Rancangan Customer";
            this.btnRancanganCustomer.UseVisualStyleBackColor = true;
            // 
            // btnPerjanjianKerja
            // 
            this.btnPerjanjianKerja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerjanjianKerja.Location = new System.Drawing.Point(42, 164);
            this.btnPerjanjianKerja.Name = "btnPerjanjianKerja";
            this.btnPerjanjianKerja.Size = new System.Drawing.Size(205, 62);
            this.btnPerjanjianKerja.TabIndex = 5;
            this.btnPerjanjianKerja.Text = "Perjanjian Kerja";
            this.btnPerjanjianKerja.UseVisualStyleBackColor = true;
            // 
            // btnPembayaranDP
            // 
            this.btnPembayaranDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPembayaranDP.Location = new System.Drawing.Point(328, 164);
            this.btnPembayaranDP.Name = "btnPembayaranDP";
            this.btnPembayaranDP.Size = new System.Drawing.Size(205, 62);
            this.btnPembayaranDP.TabIndex = 6;
            this.btnPembayaranDP.Text = "Pembayaran DP";
            this.btnPembayaranDP.UseVisualStyleBackColor = true;
            // 
            // btnJatuhTempo
            // 
            this.btnJatuhTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJatuhTempo.Location = new System.Drawing.Point(42, 245);
            this.btnJatuhTempo.Name = "btnJatuhTempo";
            this.btnJatuhTempo.Size = new System.Drawing.Size(205, 62);
            this.btnJatuhTempo.TabIndex = 7;
            this.btnJatuhTempo.Text = "Jatuh Tempo";
            this.btnJatuhTempo.UseVisualStyleBackColor = true;
            // 
            // btnBuktiPelunasan
            // 
            this.btnBuktiPelunasan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuktiPelunasan.Location = new System.Drawing.Point(328, 245);
            this.btnBuktiPelunasan.Name = "btnBuktiPelunasan";
            this.btnBuktiPelunasan.Size = new System.Drawing.Size(205, 62);
            this.btnBuktiPelunasan.TabIndex = 8;
            this.btnBuktiPelunasan.Text = "Bukti Pelunasan";
            this.btnBuktiPelunasan.UseVisualStyleBackColor = true;
            // 
            // frmMainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btnBuktiPelunasan);
            this.Controls.Add(this.btnJatuhTempo);
            this.Controls.Add(this.btnPembayaranDP);
            this.Controls.Add(this.btnPerjanjianKerja);
            this.Controls.Add(this.btnRancanganCustomer);
            this.Controls.Add(this.btnRegisterCustomer);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmMainInterface";
            this.Text = "Main";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnRegisterCustomer;
        private System.Windows.Forms.Button btnRancanganCustomer;
        private System.Windows.Forms.Button btnPerjanjianKerja;
        private System.Windows.Forms.Button btnPembayaranDP;
        private System.Windows.Forms.Button btnJatuhTempo;
        private System.Windows.Forms.Button btnBuktiPelunasan;
    }
}