namespace EO
{
    partial class frmJatuhTempo
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
            this.gpbKontrakKerja = new System.Windows.Forms.GroupBox();
            this.txtTglJatuhTempo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSuratKontrak = new System.Windows.Forms.ComboBox();
            this.lblIDCustomer = new System.Windows.Forms.Label();
            this.gpbClient = new System.Windows.Forms.GroupBox();
            this.txtIdClient = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoTelepon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gpbOperation = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.gpbKontrakKerja.SuspendLayout();
            this.gpbClient.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pnlHeader.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(162, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(250, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Formulir Jatuh Tempo";
            // 
            // gpbKontrakKerja
            // 
            this.gpbKontrakKerja.Controls.Add(this.txtTglJatuhTempo);
            this.gpbKontrakKerja.Controls.Add(this.label1);
            this.gpbKontrakKerja.Controls.Add(this.cboSuratKontrak);
            this.gpbKontrakKerja.Controls.Add(this.lblIDCustomer);
            this.gpbKontrakKerja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbKontrakKerja.Location = new System.Drawing.Point(12, 3);
            this.gpbKontrakKerja.Name = "gpbKontrakKerja";
            this.gpbKontrakKerja.Size = new System.Drawing.Size(560, 100);
            this.gpbKontrakKerja.TabIndex = 1;
            this.gpbKontrakKerja.TabStop = false;
            this.gpbKontrakKerja.Text = "Surat Kontrak Kerja";
            // 
            // txtTglJatuhTempo
            // 
            this.txtTglJatuhTempo.Location = new System.Drawing.Point(200, 51);
            this.txtTglJatuhTempo.Name = "txtTglJatuhTempo";
            this.txtTglJatuhTempo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTglJatuhTempo.Size = new System.Drawing.Size(314, 24);
            this.txtTglJatuhTempo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tanggal Jatuh Tempo";
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
            // gpbClient
            // 
            this.gpbClient.Controls.Add(this.txtEmail);
            this.gpbClient.Controls.Add(this.label6);
            this.gpbClient.Controls.Add(this.txtNoTelepon);
            this.gpbClient.Controls.Add(this.label5);
            this.gpbClient.Controls.Add(this.txtAlamat);
            this.gpbClient.Controls.Add(this.label4);
            this.gpbClient.Controls.Add(this.txtIdClient);
            this.gpbClient.Controls.Add(this.txtNama);
            this.gpbClient.Controls.Add(this.label2);
            this.gpbClient.Controls.Add(this.label3);
            this.gpbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbClient.Location = new System.Drawing.Point(12, 109);
            this.gpbClient.Name = "gpbClient";
            this.gpbClient.Size = new System.Drawing.Size(560, 234);
            this.gpbClient.TabIndex = 3;
            this.gpbClient.TabStop = false;
            this.gpbClient.Text = "Client";
            // 
            // txtIdClient
            // 
            this.txtIdClient.Location = new System.Drawing.Point(200, 19);
            this.txtIdClient.Name = "txtIdClient";
            this.txtIdClient.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIdClient.Size = new System.Drawing.Size(314, 24);
            this.txtIdClient.TabIndex = 11;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(200, 51);
            this.txtNama.Name = "txtNama";
            this.txtNama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNama.Size = new System.Drawing.Size(314, 24);
            this.txtNama.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Client";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gpbOperation);
            this.panel1.Controls.Add(this.gpbKontrakKerja);
            this.panel1.Controls.Add(this.gpbClient);
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 435);
            this.panel1.TabIndex = 4;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(200, 81);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAlamat.Size = new System.Drawing.Size(314, 58);
            this.txtAlamat.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Alamat";
            // 
            // txtNoTelepon
            // 
            this.txtNoTelepon.Location = new System.Drawing.Point(200, 146);
            this.txtNoTelepon.Name = "txtNoTelepon";
            this.txtNoTelepon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNoTelepon.Size = new System.Drawing.Size(314, 24);
            this.txtNoTelepon.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nomor Telepon";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(200, 177);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEmail.Size = new System.Drawing.Size(314, 24);
            this.txtEmail.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email";
            // 
            // gpbOperation
            // 
            this.gpbOperation.Controls.Add(this.btnClose);
            this.gpbOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOperation.Location = new System.Drawing.Point(12, 354);
            this.gpbOperation.Name = "gpbOperation";
            this.gpbOperation.Size = new System.Drawing.Size(560, 71);
            this.gpbOperation.TabIndex = 4;
            this.gpbOperation.TabStop = false;
            this.gpbOperation.Text = "Operation";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(231, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmJatuhTempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmJatuhTempo";
            this.Text = "Formulir Jatuh Tempo";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.gpbKontrakKerja.ResumeLayout(false);
            this.gpbKontrakKerja.PerformLayout();
            this.gpbClient.ResumeLayout(false);
            this.gpbClient.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gpbOperation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox gpbKontrakKerja;
        private System.Windows.Forms.TextBox txtTglJatuhTempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSuratKontrak;
        private System.Windows.Forms.Label lblIDCustomer;
        private System.Windows.Forms.GroupBox gpbClient;
        private System.Windows.Forms.TextBox txtIdClient;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoTelepon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gpbOperation;
        private System.Windows.Forms.Button btnClose;
    }
}