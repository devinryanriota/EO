namespace EO
{
    partial class frmPelunasan
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gpbKontrakKerja = new System.Windows.Forms.GroupBox();
            this.txtTotalBiaya = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSuratKontrak = new System.Windows.Forms.ComboBox();
            this.lblIDCustomer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTglJatuhTempo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTagihan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPembayaran = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDenda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gpbOperation = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.gpbKontrakKerja.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gpbOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(584, 65);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(152, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(281, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Formulir Bukti Pelunasan";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 71);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(584, 382);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // gpbKontrakKerja
            // 
            this.gpbKontrakKerja.Controls.Add(this.txtTglJatuhTempo);
            this.gpbKontrakKerja.Controls.Add(this.label2);
            this.gpbKontrakKerja.Controls.Add(this.label4);
            this.gpbKontrakKerja.Controls.Add(this.txtTotalBiaya);
            this.gpbKontrakKerja.Controls.Add(this.label1);
            this.gpbKontrakKerja.Controls.Add(this.cboSuratKontrak);
            this.gpbKontrakKerja.Controls.Add(this.lblIDCustomer);
            this.gpbKontrakKerja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbKontrakKerja.Location = new System.Drawing.Point(12, 86);
            this.gpbKontrakKerja.Name = "gpbKontrakKerja";
            this.gpbKontrakKerja.Size = new System.Drawing.Size(560, 126);
            this.gpbKontrakKerja.TabIndex = 5;
            this.gpbKontrakKerja.TabStop = false;
            this.gpbKontrakKerja.Text = "Surat Kontrak Kerja";
            // 
            // txtTotalBiaya
            // 
            this.txtTotalBiaya.Location = new System.Drawing.Point(248, 51);
            this.txtTotalBiaya.Name = "txtTotalBiaya";
            this.txtTotalBiaya.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTotalBiaya.Size = new System.Drawing.Size(266, 24);
            this.txtTotalBiaya.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Biaya";
            // 
            // cboSuratKontrak
            // 
            this.cboSuratKontrak.FormattingEnabled = true;
            this.cboSuratKontrak.Location = new System.Drawing.Point(200, 19);
            this.cboSuratKontrak.Name = "cboSuratKontrak";
            this.cboSuratKontrak.Size = new System.Drawing.Size(314, 26);
            this.cboSuratKontrak.TabIndex = 5;
            // 
            // lblIDCustomer
            // 
            this.lblIDCustomer.AutoSize = true;
            this.lblIDCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCustomer.Location = new System.Drawing.Point(37, 24);
            this.lblIDCustomer.Name = "lblIDCustomer";
            this.lblIDCustomer.Size = new System.Drawing.Size(137, 16);
            this.lblIDCustomer.TabIndex = 4;
            this.lblIDCustomer.Text = "ID Surat Kontrak Kerja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "RP.";
            // 
            // txtTglJatuhTempo
            // 
            this.txtTglJatuhTempo.Location = new System.Drawing.Point(200, 82);
            this.txtTglJatuhTempo.Name = "txtTglJatuhTempo";
            this.txtTglJatuhTempo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTglJatuhTempo.Size = new System.Drawing.Size(314, 24);
            this.txtTglJatuhTempo.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tanggal Jatuh Tempo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDenda);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTagihan);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPembayaran);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 124);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pembayaran";
            // 
            // txtTagihan
            // 
            this.txtTagihan.Location = new System.Drawing.Point(246, 19);
            this.txtTagihan.Name = "txtTagihan";
            this.txtTagihan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTagihan.Size = new System.Drawing.Size(268, 24);
            this.txtTagihan.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(197, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "RP.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "RP.";
            // 
            // txtPembayaran
            // 
            this.txtPembayaran.Location = new System.Drawing.Point(246, 51);
            this.txtPembayaran.Name = "txtPembayaran";
            this.txtPembayaran.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPembayaran.Size = new System.Drawing.Size(268, 24);
            this.txtPembayaran.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pembayaran";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Jumlah Tagihan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(197, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "RP.";
            // 
            // txtDenda
            // 
            this.txtDenda.Location = new System.Drawing.Point(246, 84);
            this.txtDenda.Name = "txtDenda";
            this.txtDenda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDenda.Size = new System.Drawing.Size(268, 24);
            this.txtDenda.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Denda";
            // 
            // gpbOperation
            // 
            this.gpbOperation.Controls.Add(this.btnPrint);
            this.gpbOperation.Controls.Add(this.btnSave);
            this.gpbOperation.Controls.Add(this.btnCancel);
            this.gpbOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOperation.Location = new System.Drawing.Point(12, 357);
            this.gpbOperation.Name = "gpbOperation";
            this.gpbOperation.Size = new System.Drawing.Size(560, 86);
            this.gpbOperation.TabIndex = 7;
            this.gpbOperation.TabStop = false;
            this.gpbOperation.Text = "Operation";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(388, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 49);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(200, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(155, 49);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(23, 19);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(155, 49);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // frmPelunasan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.gpbOperation);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpbKontrakKerja);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmPelunasan";
            this.Text = "Formulir Bukti Pelunasan";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.gpbKontrakKerja.ResumeLayout(false);
            this.gpbKontrakKerja.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpbOperation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox gpbKontrakKerja;
        private System.Windows.Forms.TextBox txtTotalBiaya;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSuratKontrak;
        private System.Windows.Forms.Label lblIDCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTglJatuhTempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTagihan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPembayaran;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gpbOperation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
    }
}