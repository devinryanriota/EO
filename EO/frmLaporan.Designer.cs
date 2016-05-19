namespace EO
{
    partial class frmLaporan
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
            this.label3 = new System.Windows.Forms.Label();
            this.dudPeriode = new System.Windows.Forms.DomainUpDown();
            this.cboJenisLaporan = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lvwOrder = new System.Windows.Forms.ListView();
            this.lvwKas = new System.Windows.Forms.ListView();
            this.colIDSuratKontrakKerja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTglSelesai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTglJatuhTempo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatusKontrak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTglPelunasan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwPiutang = new System.Windows.Forms.ListView();
            this.colIDTransaksi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colJenisTransaksi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTglTransaksi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colJumlahTransaksi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIDBuktiPelunasan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIDSuratKontrakKerja2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colJumlahPelunasan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTglPelunasan2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Laporan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Laporan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Periode";
            // 
            // dudPeriode
            // 
            this.dudPeriode.Items.Add("January");
            this.dudPeriode.Items.Add("February");
            this.dudPeriode.Items.Add("March");
            this.dudPeriode.Items.Add("April");
            this.dudPeriode.Items.Add("May");
            this.dudPeriode.Items.Add("June");
            this.dudPeriode.Items.Add("July");
            this.dudPeriode.Items.Add("August");
            this.dudPeriode.Items.Add("September");
            this.dudPeriode.Items.Add("October");
            this.dudPeriode.Items.Add("November");
            this.dudPeriode.Items.Add("December");
            this.dudPeriode.Location = new System.Drawing.Point(171, 98);
            this.dudPeriode.Name = "dudPeriode";
            this.dudPeriode.Size = new System.Drawing.Size(257, 20);
            this.dudPeriode.TabIndex = 3;
            this.dudPeriode.Text = "Pilih Periode";
            // 
            // cboJenisLaporan
            // 
            this.cboJenisLaporan.FormattingEnabled = true;
            this.cboJenisLaporan.Items.AddRange(new object[] {
            "Laporan Order",
            "Laporan Penerimaan Kas",
            "Laporan Pelunasan Piutang"});
            this.cboJenisLaporan.Location = new System.Drawing.Point(170, 66);
            this.cboJenisLaporan.Name = "cboJenisLaporan";
            this.cboJenisLaporan.Size = new System.Drawing.Size(303, 21);
            this.cboJenisLaporan.TabIndex = 4;
            this.cboJenisLaporan.Text = "Pilih Jenis Laporan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Location = new System.Drawing.Point(64, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operation";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(152, 19);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(129, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lvwOrder
            // 
            this.lvwOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIDSuratKontrakKerja,
            this.colTglSelesai,
            this.colTglJatuhTempo,
            this.colStatusKontrak,
            this.colTglPelunasan});
            this.lvwOrder.Location = new System.Drawing.Point(22, 228);
            this.lvwOrder.Name = "lvwOrder";
            this.lvwOrder.Size = new System.Drawing.Size(550, 222);
            this.lvwOrder.TabIndex = 6;
            this.lvwOrder.UseCompatibleStateImageBehavior = false;
            this.lvwOrder.View = System.Windows.Forms.View.Details;
            // 
            // lvwKas
            // 
            this.lvwKas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIDTransaksi,
            this.colJenisTransaksi,
            this.colTglTransaksi,
            this.colJumlahTransaksi});
            this.lvwKas.Location = new System.Drawing.Point(22, 228);
            this.lvwKas.Name = "lvwKas";
            this.lvwKas.Size = new System.Drawing.Size(550, 222);
            this.lvwKas.TabIndex = 7;
            this.lvwKas.UseCompatibleStateImageBehavior = false;
            this.lvwKas.View = System.Windows.Forms.View.Details;
            // 
            // colIDSuratKontrakKerja
            // 
            this.colIDSuratKontrakKerja.Text = "ID Surat Kontrak kerja";
            this.colIDSuratKontrakKerja.Width = 120;
            // 
            // colTglSelesai
            // 
            this.colTglSelesai.Text = "Tgl Selesai";
            this.colTglSelesai.Width = 93;
            // 
            // colTglJatuhTempo
            // 
            this.colTglJatuhTempo.Text = "Tgl Jatuh Tempo";
            this.colTglJatuhTempo.Width = 92;
            // 
            // colStatusKontrak
            // 
            this.colStatusKontrak.Text = "Status Kontrak";
            this.colStatusKontrak.Width = 109;
            // 
            // colTglPelunasan
            // 
            this.colTglPelunasan.Text = "Tgl Pelunasan";
            this.colTglPelunasan.Width = 116;
            // 
            // lvwPiutang
            // 
            this.lvwPiutang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIDBuktiPelunasan,
            this.colIDSuratKontrakKerja2,
            this.colJumlahPelunasan,
            this.colTglPelunasan2,
            this.colDenda});
            this.lvwPiutang.Location = new System.Drawing.Point(22, 228);
            this.lvwPiutang.Name = "lvwPiutang";
            this.lvwPiutang.Size = new System.Drawing.Size(550, 222);
            this.lvwPiutang.TabIndex = 8;
            this.lvwPiutang.UseCompatibleStateImageBehavior = false;
            this.lvwPiutang.View = System.Windows.Forms.View.Details;
            // 
            // colIDTransaksi
            // 
            this.colIDTransaksi.Text = "ID Transaksi";
            this.colIDTransaksi.Width = 72;
            // 
            // colJenisTransaksi
            // 
            this.colJenisTransaksi.Text = "Jenis Transaksi";
            this.colJenisTransaksi.Width = 132;
            // 
            // colTglTransaksi
            // 
            this.colTglTransaksi.Text = "Tanggal Transaksi";
            this.colTglTransaksi.Width = 100;
            // 
            // colJumlahTransaksi
            // 
            this.colJumlahTransaksi.Text = "Jumlah Transaksi";
            this.colJumlahTransaksi.Width = 154;
            // 
            // colIDBuktiPelunasan
            // 
            this.colIDBuktiPelunasan.Text = "ID Bukti Pelunasan";
            this.colIDBuktiPelunasan.Width = 118;
            // 
            // colIDSuratKontrakKerja2
            // 
            this.colIDSuratKontrakKerja2.Text = "ID Surat Kontrak Kerja";
            this.colIDSuratKontrakKerja2.Width = 120;
            // 
            // colJumlahPelunasan
            // 
            this.colJumlahPelunasan.Text = "Jumlah Pelunasan";
            this.colJumlahPelunasan.Width = 106;
            // 
            // colTglPelunasan2
            // 
            this.colTglPelunasan2.Text = "Tgl Pelunasan";
            this.colTglPelunasan2.Width = 91;
            // 
            // colDenda
            // 
            this.colDenda.Text = "Denda";
            this.colDenda.Width = 111;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "2016";
            // 
            // frmLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboJenisLaporan);
            this.Controls.Add(this.dudPeriode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwOrder);
            this.Controls.Add(this.lvwPiutang);
            this.Controls.Add(this.lvwKas);
            this.Name = "frmLaporan";
            this.Text = "Form Laporan";
            this.Load += new System.EventHandler(this.frmLaporan_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown dudPeriode;
        private System.Windows.Forms.ComboBox cboJenisLaporan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListView lvwOrder;
        private System.Windows.Forms.ColumnHeader colIDSuratKontrakKerja;
        private System.Windows.Forms.ColumnHeader colTglSelesai;
        private System.Windows.Forms.ColumnHeader colTglJatuhTempo;
        private System.Windows.Forms.ColumnHeader colStatusKontrak;
        private System.Windows.Forms.ColumnHeader colTglPelunasan;
        private System.Windows.Forms.ListView lvwKas;
        private System.Windows.Forms.ColumnHeader colIDTransaksi;
        private System.Windows.Forms.ColumnHeader colJenisTransaksi;
        private System.Windows.Forms.ColumnHeader colTglTransaksi;
        private System.Windows.Forms.ColumnHeader colJumlahTransaksi;
        private System.Windows.Forms.ListView lvwPiutang;
        private System.Windows.Forms.ColumnHeader colIDBuktiPelunasan;
        private System.Windows.Forms.ColumnHeader colIDSuratKontrakKerja2;
        private System.Windows.Forms.ColumnHeader colJumlahPelunasan;
        private System.Windows.Forms.ColumnHeader colTglPelunasan2;
        private System.Windows.Forms.ColumnHeader colDenda;
        private System.Windows.Forms.Label label4;
    }
}