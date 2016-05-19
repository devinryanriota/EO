namespace EO
{
    partial class frmCustomer
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
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSearchCustomer = new System.Windows.Forms.Label();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.lvwCustomer = new System.Windows.Forms.ListView();
            this.colCustID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsCustomer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.cmsCustomer.SuspendLayout();
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
            this.lblHeader.Location = new System.Drawing.Point(234, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(129, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Customers";
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
            // 
            // lblSearchCustomer
            // 
            this.lblSearchCustomer.AutoSize = true;
            this.lblSearchCustomer.Location = new System.Drawing.Point(31, 92);
            this.lblSearchCustomer.Name = "lblSearchCustomer";
            this.lblSearchCustomer.Size = new System.Drawing.Size(97, 13);
            this.lblSearchCustomer.TabIndex = 4;
            this.lblSearchCustomer.Text = "Search Customer : ";
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(165, 92);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(292, 20);
            this.txtSearchCustomer.TabIndex = 5;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // lvwCustomer
            // 
            this.lvwCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCustID,
            this.colName,
            this.colPhone,
            this.colAddress,
            this.colEmail});
            this.lvwCustomer.ContextMenuStrip = this.cmsCustomer;
            this.lvwCustomer.FullRowSelect = true;
            this.lvwCustomer.GridLines = true;
            this.lvwCustomer.LabelEdit = true;
            this.lvwCustomer.Location = new System.Drawing.Point(34, 135);
            this.lvwCustomer.Name = "lvwCustomer";
            this.lvwCustomer.Size = new System.Drawing.Size(520, 217);
            this.lvwCustomer.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwCustomer.TabIndex = 6;
            this.lvwCustomer.UseCompatibleStateImageBehavior = false;
            this.lvwCustomer.View = System.Windows.Forms.View.Details;
            // 
            // colCustID
            // 
            this.colCustID.Text = "Cust ID";
            this.colCustID.Width = 95;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 94;
            // 
            // colPhone
            // 
            this.colPhone.Text = "Phone";
            this.colPhone.Width = 93;
            // 
            // colAddress
            // 
            this.colAddress.Text = "Address";
            this.colAddress.Width = 125;
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            this.colEmail.Width = 114;
            // 
            // cmsCustomer
            // 
            this.cmsCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.cmsCustomer.Name = "cmsCustomer";
            this.cmsCustomer.Size = new System.Drawing.Size(95, 26);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Location = new System.Drawing.Point(239, 377);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(124, 23);
            this.btnAddNewCustomer.TabIndex = 7;
            this.btnAddNewCustomer.Text = "Add New Customer";
            this.btnAddNewCustomer.UseVisualStyleBackColor = true;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 512);
            this.Controls.Add(this.lvwCustomer);
            this.Controls.Add(this.btnAddNewCustomer);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.lblSearchCustomer);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.cmsCustomer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSearchCustomer;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.ListView lvwCustomer;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colPhone;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.ColumnHeader colCustID;
        private System.Windows.Forms.ContextMenuStrip cmsCustomer;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}