namespace InventoryManagementSystem
{
    partial class SupplierAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAdvance = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalDue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalPaid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalPurchase = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTotalPaid = new System.Windows.Forms.DataGridView();
            this.cmbSupplierName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTotalPurchase = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listAllDebtors = new InventoryManagementSystem.DatasetList.ListAllDebtors();
            this.listAllDebitSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listAllDebitSupplierTableAdapter = new InventoryManagementSystem.DatasetList.ListAllDebtorsTableAdapters.ListAllDebitSupplierTableAdapter();
            this.supplierPurchaseEntries = new InventoryManagementSystem.DatasetList.SupplierPurchaseEntries();
            this.supplierPurchaseEntriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierPurchaseEntriesTableAdapter = new InventoryManagementSystem.DatasetList.SupplierPurchaseEntriesTableAdapters.SupplierPurchaseEntriesTableAdapter();
            this.purchaseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grandTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierReceiptEntries = new InventoryManagementSystem.DatasetList.SupplierReceiptEntries();
            this.supplierReceiptEntriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierReceiptEntriesTableAdapter = new InventoryManagementSystem.DatasetList.SupplierReceiptEntriesTableAdapters.SupplierReceiptEntriesTableAdapter();
            this.cashIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalPurchase)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAllDebtors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAllDebitSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierPurchaseEntries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierPurchaseEntriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierReceiptEntries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierReceiptEntriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 450);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.lblAdvance);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lblTotalDue);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblTotalPaid);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblTotalPurchase);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgvTotalPaid);
            this.panel2.Controls.Add(this.cmbSupplierName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dgvTotalPurchase);
            this.panel2.Location = new System.Drawing.Point(5, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 385);
            this.panel2.TabIndex = 11;
            // 
            // lblAdvance
            // 
            this.lblAdvance.AutoSize = true;
            this.lblAdvance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvance.Location = new System.Drawing.Point(597, 298);
            this.lblAdvance.Name = "lblAdvance";
            this.lblAdvance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAdvance.Size = new System.Drawing.Size(16, 19);
            this.lblAdvance.TabIndex = 18;
            this.lblAdvance.Text = "?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(516, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 19);
            this.label12.TabIndex = 17;
            this.label12.Text = "Advance";
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.AutoSize = true;
            this.lblTotalDue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDue.Location = new System.Drawing.Point(271, 298);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalDue.Size = new System.Drawing.Size(16, 19);
            this.lblTotalDue.TabIndex = 16;
            this.lblTotalDue.Text = "?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(179, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Amount Due";
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.AutoSize = true;
            this.lblTotalPaid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaid.Location = new System.Drawing.Point(271, 329);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalPaid.Size = new System.Drawing.Size(16, 19);
            this.lblTotalPaid.TabIndex = 14;
            this.lblTotalPaid.Text = "?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(179, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total Paid";
            // 
            // lblTotalPurchase
            // 
            this.lblTotalPurchase.AutoSize = true;
            this.lblTotalPurchase.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPurchase.Location = new System.Drawing.Point(597, 329);
            this.lblTotalPurchase.Name = "lblTotalPurchase";
            this.lblTotalPurchase.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalPurchase.Size = new System.Drawing.Size(16, 19);
            this.lblTotalPurchase.TabIndex = 12;
            this.lblTotalPurchase.Text = "?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(481, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Purchase";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(477, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Debit Side";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Credit Side";
            // 
            // dgvTotalPaid
            // 
            this.dgvTotalPaid.AllowUserToAddRows = false;
            this.dgvTotalPaid.AllowUserToDeleteRows = false;
            this.dgvTotalPaid.AutoGenerateColumns = false;
            this.dgvTotalPaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalPaid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cashIDDataGridViewTextBoxColumn,
            this.voucherNoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dgvTotalPaid.DataSource = this.supplierReceiptEntriesBindingSource;
            this.dgvTotalPaid.Location = new System.Drawing.Point(13, 87);
            this.dgvTotalPaid.Name = "dgvTotalPaid";
            this.dgvTotalPaid.ReadOnly = true;
            this.dgvTotalPaid.Size = new System.Drawing.Size(330, 197);
            this.dgvTotalPaid.TabIndex = 8;
            // 
            // cmbSupplierName
            // 
            this.cmbSupplierName.DataSource = this.listAllDebitSupplierBindingSource;
            this.cmbSupplierName.DisplayMember = "SupplierName";
            this.cmbSupplierName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplierName.FormattingEnabled = true;
            this.cmbSupplierName.Location = new System.Drawing.Point(293, 14);
            this.cmbSupplierName.Name = "cmbSupplierName";
            this.cmbSupplierName.Size = new System.Drawing.Size(196, 27);
            this.cmbSupplierName.TabIndex = 1;
            this.cmbSupplierName.ValueMember = "SupplierID";
            this.cmbSupplierName.SelectedIndexChanged += new System.EventHandler(this.cmbSupplierName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Supplier Name";
            // 
            // dgvTotalPurchase
            // 
            this.dgvTotalPurchase.AllowUserToAddRows = false;
            this.dgvTotalPurchase.AllowUserToDeleteRows = false;
            this.dgvTotalPurchase.AutoGenerateColumns = false;
            this.dgvTotalPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchaseIDDataGridViewTextBoxColumn,
            this.purchaseDateDataGridViewTextBoxColumn,
            this.invoiceNoDataGridViewTextBoxColumn,
            this.grandTotalDataGridViewTextBoxColumn});
            this.dgvTotalPurchase.DataSource = this.supplierPurchaseEntriesBindingSource;
            this.dgvTotalPurchase.Location = new System.Drawing.Point(347, 87);
            this.dgvTotalPurchase.Name = "dgvTotalPurchase";
            this.dgvTotalPurchase.ReadOnly = true;
            this.dgvTotalPurchase.Size = new System.Drawing.Size(330, 197);
            this.dgvTotalPurchase.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(5, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 42);
            this.panel3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Supplier Account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(649, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listAllDebtors
            // 
            this.listAllDebtors.DataSetName = "ListAllDebtors";
            this.listAllDebtors.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listAllDebitSupplierBindingSource
            // 
            this.listAllDebitSupplierBindingSource.DataMember = "ListAllDebitSupplier";
            this.listAllDebitSupplierBindingSource.DataSource = this.listAllDebtors;
            // 
            // listAllDebitSupplierTableAdapter
            // 
            this.listAllDebitSupplierTableAdapter.ClearBeforeFill = true;
            // 
            // supplierPurchaseEntries
            // 
            this.supplierPurchaseEntries.DataSetName = "SupplierPurchaseEntries";
            this.supplierPurchaseEntries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierPurchaseEntriesBindingSource
            // 
            this.supplierPurchaseEntriesBindingSource.DataMember = "SupplierPurchaseEntries";
            this.supplierPurchaseEntriesBindingSource.DataSource = this.supplierPurchaseEntries;
            // 
            // supplierPurchaseEntriesTableAdapter
            // 
            this.supplierPurchaseEntriesTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseIDDataGridViewTextBoxColumn
            // 
            this.purchaseIDDataGridViewTextBoxColumn.DataPropertyName = "PurchaseID";
            this.purchaseIDDataGridViewTextBoxColumn.HeaderText = "PurchaseID";
            this.purchaseIDDataGridViewTextBoxColumn.Name = "purchaseIDDataGridViewTextBoxColumn";
            this.purchaseIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.purchaseIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // purchaseDateDataGridViewTextBoxColumn
            // 
            this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
            this.purchaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceNoDataGridViewTextBoxColumn
            // 
            this.invoiceNoDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNo";
            this.invoiceNoDataGridViewTextBoxColumn.HeaderText = "InvoiceNo";
            this.invoiceNoDataGridViewTextBoxColumn.Name = "invoiceNoDataGridViewTextBoxColumn";
            this.invoiceNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grandTotalDataGridViewTextBoxColumn
            // 
            this.grandTotalDataGridViewTextBoxColumn.DataPropertyName = "GrandTotal";
            this.grandTotalDataGridViewTextBoxColumn.HeaderText = "GrandTotal";
            this.grandTotalDataGridViewTextBoxColumn.Name = "grandTotalDataGridViewTextBoxColumn";
            this.grandTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierReceiptEntries
            // 
            this.supplierReceiptEntries.DataSetName = "SupplierReceiptEntries";
            this.supplierReceiptEntries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierReceiptEntriesBindingSource
            // 
            this.supplierReceiptEntriesBindingSource.DataMember = "SupplierReceiptEntries";
            this.supplierReceiptEntriesBindingSource.DataSource = this.supplierReceiptEntries;
            // 
            // supplierReceiptEntriesTableAdapter
            // 
            this.supplierReceiptEntriesTableAdapter.ClearBeforeFill = true;
            // 
            // cashIDDataGridViewTextBoxColumn
            // 
            this.cashIDDataGridViewTextBoxColumn.DataPropertyName = "CashID";
            this.cashIDDataGridViewTextBoxColumn.HeaderText = "CashID";
            this.cashIDDataGridViewTextBoxColumn.Name = "cashIDDataGridViewTextBoxColumn";
            this.cashIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cashIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // voucherNoDataGridViewTextBoxColumn
            // 
            this.voucherNoDataGridViewTextBoxColumn.DataPropertyName = "VoucherNo";
            this.voucherNoDataGridViewTextBoxColumn.HeaderText = "VoucherNo";
            this.voucherNoDataGridViewTextBoxColumn.Name = "voucherNoDataGridViewTextBoxColumn";
            this.voucherNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.voucherNoDataGridViewTextBoxColumn.Width = 75;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 75;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 75;
            // 
            // SupplierAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "SupplierAccount";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplierAccount";
            this.Load += new System.EventHandler(this.SupplierAccount_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SupplierAccount_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalPurchase)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAllDebtors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAllDebitSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierPurchaseEntries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierPurchaseEntriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierReceiptEntries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierReceiptEntriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAdvance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalDue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalPaid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalPurchase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTotalPaid;
        private System.Windows.Forms.ComboBox cmbSupplierName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTotalPurchase;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DatasetList.ListAllDebtors listAllDebtors;
        private System.Windows.Forms.BindingSource listAllDebitSupplierBindingSource;
        private DatasetList.ListAllDebtorsTableAdapters.ListAllDebitSupplierTableAdapter listAllDebitSupplierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grandTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource supplierPurchaseEntriesBindingSource;
        private DatasetList.SupplierPurchaseEntries supplierPurchaseEntries;
        private DatasetList.SupplierPurchaseEntriesTableAdapters.SupplierPurchaseEntriesTableAdapter supplierPurchaseEntriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource supplierReceiptEntriesBindingSource;
        private DatasetList.SupplierReceiptEntries supplierReceiptEntries;
        private DatasetList.SupplierReceiptEntriesTableAdapters.SupplierReceiptEntriesTableAdapter supplierReceiptEntriesTableAdapter;
    }
}