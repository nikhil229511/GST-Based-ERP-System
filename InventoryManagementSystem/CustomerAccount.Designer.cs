namespace InventoryManagementSystem
{
    partial class CustomerAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAdvance = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalDue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalPaid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTotalReceived = new System.Windows.Forms.DataGridView();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.listAllCreditCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listAllCreditors = new InventoryManagementSystem.DatasetList.ListAllCreditors();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTotalSales = new System.Windows.Forms.DataGridView();
            this.salesIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grandTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerSalesEntriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerSalesEntries = new InventoryManagementSystem.DatasetList.CustomerSalesEntries();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customerSalesEntriesTableAdapter = new InventoryManagementSystem.DatasetList.CustomerSalesEntriesTableAdapters.CustomerSalesEntriesTableAdapter();
            this.listAllCreditCustomerTableAdapter = new InventoryManagementSystem.DatasetList.ListAllCreditorsTableAdapters.ListAllCreditCustomerTableAdapter();
            this.customerPaymentEntries = new InventoryManagementSystem.DatasetList.CustomerPaymentEntries();
            this.customerPaymentEntriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerPaymentEntriesTableAdapter = new InventoryManagementSystem.DatasetList.CustomerPaymentEntriesTableAdapters.CustomerPaymentEntriesTableAdapter();
            this.cashIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalReceived)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAllCreditCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAllCreditors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerSalesEntriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerSalesEntries)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPaymentEntries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPaymentEntriesBindingSource)).BeginInit();
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
            this.panel1.TabIndex = 2;
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
            this.panel2.Controls.Add(this.lblTotalSales);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgvTotalReceived);
            this.panel2.Controls.Add(this.cmbCustomerName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dgvTotalSales);
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
            this.label8.Location = new System.Drawing.Point(166, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total Received";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.Location = new System.Drawing.Point(597, 329);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalSales.Size = new System.Drawing.Size(16, 19);
            this.lblTotalSales.TabIndex = 12;
            this.lblTotalSales.Text = "?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(516, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Sales";
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
            // dgvTotalReceived
            // 
            this.dgvTotalReceived.AllowUserToAddRows = false;
            this.dgvTotalReceived.AllowUserToDeleteRows = false;
            this.dgvTotalReceived.AutoGenerateColumns = false;
            this.dgvTotalReceived.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalReceived.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cashIDDataGridViewTextBoxColumn,
            this.voucherNoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dgvTotalReceived.DataSource = this.customerPaymentEntriesBindingSource;
            this.dgvTotalReceived.Location = new System.Drawing.Point(13, 87);
            this.dgvTotalReceived.Name = "dgvTotalReceived";
            this.dgvTotalReceived.ReadOnly = true;
            this.dgvTotalReceived.Size = new System.Drawing.Size(330, 197);
            this.dgvTotalReceived.TabIndex = 8;
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.DataSource = this.listAllCreditCustomerBindingSource;
            this.cmbCustomerName.DisplayMember = "Name";
            this.cmbCustomerName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(305, 14);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(196, 27);
            this.cmbCustomerName.TabIndex = 1;
            this.cmbCustomerName.ValueMember = "CustomerID";
            this.cmbCustomerName.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerName_SelectedIndexChanged);
            // 
            // listAllCreditCustomerBindingSource
            // 
            this.listAllCreditCustomerBindingSource.DataMember = "ListAllCreditCustomer";
            this.listAllCreditCustomerBindingSource.DataSource = this.listAllCreditors;
            // 
            // listAllCreditors
            // 
            this.listAllCreditors.DataSetName = "ListAllCreditors";
            this.listAllCreditors.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer Name";
            // 
            // dgvTotalSales
            // 
            this.dgvTotalSales.AllowUserToAddRows = false;
            this.dgvTotalSales.AllowUserToDeleteRows = false;
            this.dgvTotalSales.AutoGenerateColumns = false;
            this.dgvTotalSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesIDDataGridViewTextBoxColumn,
            this.salesDateDataGridViewTextBoxColumn,
            this.invoiceNoDataGridViewTextBoxColumn,
            this.grandTotalDataGridViewTextBoxColumn});
            this.dgvTotalSales.DataSource = this.customerSalesEntriesBindingSource;
            this.dgvTotalSales.Location = new System.Drawing.Point(347, 87);
            this.dgvTotalSales.Name = "dgvTotalSales";
            this.dgvTotalSales.ReadOnly = true;
            this.dgvTotalSales.Size = new System.Drawing.Size(330, 197);
            this.dgvTotalSales.TabIndex = 6;
            // 
            // salesIDDataGridViewTextBoxColumn
            // 
            this.salesIDDataGridViewTextBoxColumn.DataPropertyName = "SalesID";
            this.salesIDDataGridViewTextBoxColumn.HeaderText = "SalesID";
            this.salesIDDataGridViewTextBoxColumn.Name = "salesIDDataGridViewTextBoxColumn";
            this.salesIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.salesIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // salesDateDataGridViewTextBoxColumn
            // 
            this.salesDateDataGridViewTextBoxColumn.DataPropertyName = "SalesDate";
            this.salesDateDataGridViewTextBoxColumn.HeaderText = "SalesDate";
            this.salesDateDataGridViewTextBoxColumn.Name = "salesDateDataGridViewTextBoxColumn";
            this.salesDateDataGridViewTextBoxColumn.ReadOnly = true;
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
            // customerSalesEntriesBindingSource
            // 
            this.customerSalesEntriesBindingSource.DataMember = "CustomerSalesEntries";
            this.customerSalesEntriesBindingSource.DataSource = this.customerSalesEntries;
            // 
            // customerSalesEntries
            // 
            this.customerSalesEntries.DataSetName = "CustomerSalesEntries";
            this.customerSalesEntries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label1.Size = new System.Drawing.Size(224, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Customer Account";
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
            // customerSalesEntriesTableAdapter
            // 
            this.customerSalesEntriesTableAdapter.ClearBeforeFill = true;
            // 
            // listAllCreditCustomerTableAdapter
            // 
            this.listAllCreditCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // customerPaymentEntries
            // 
            this.customerPaymentEntries.DataSetName = "CustomerPaymentEntries";
            this.customerPaymentEntries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerPaymentEntriesBindingSource
            // 
            this.customerPaymentEntriesBindingSource.DataMember = "CustomerPaymentEntries";
            this.customerPaymentEntriesBindingSource.DataSource = this.customerPaymentEntries;
            // 
            // customerPaymentEntriesTableAdapter
            // 
            this.customerPaymentEntriesTableAdapter.ClearBeforeFill = true;
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
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
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
            // 
            // CustomerAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "CustomerAccount";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerAccount";
            this.Load += new System.EventHandler(this.CustomerAccount_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerAccount_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalReceived)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAllCreditCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAllCreditors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerSalesEntriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerSalesEntries)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPaymentEntries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPaymentEntriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTotalSales;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvTotalReceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grandTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerSalesEntriesBindingSource;
        private DatasetList.CustomerSalesEntries customerSalesEntries;
        private DatasetList.CustomerSalesEntriesTableAdapters.CustomerSalesEntriesTableAdapter customerSalesEntriesTableAdapter;
        private DatasetList.ListAllCreditors listAllCreditors;
        private System.Windows.Forms.BindingSource listAllCreditCustomerBindingSource;
        private DatasetList.ListAllCreditorsTableAdapters.ListAllCreditCustomerTableAdapter listAllCreditCustomerTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalPaid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalDue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAdvance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource customerPaymentEntriesBindingSource;
        private DatasetList.CustomerPaymentEntries customerPaymentEntries;
        private DatasetList.CustomerPaymentEntriesTableAdapters.CustomerPaymentEntriesTableAdapter customerPaymentEntriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    }
}