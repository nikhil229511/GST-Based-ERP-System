namespace InventoryManagementSystem
{
    partial class PurchaseReportSupplierwise
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseReportSupplierwise));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rptPurchaseSupplierwise = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbSupplierName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.purchaseSupplierwiseRpt = new InventoryManagementSystem.DatasetList.PurchaseSupplierwiseRpt();
            this.rptSupplierwisePurchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptSupplierwisePurchaseTableAdapter = new InventoryManagementSystem.DatasetList.PurchaseSupplierwiseRptTableAdapters.RptSupplierwisePurchaseTableAdapter();
            this.purchaseComboSupplier = new InventoryManagementSystem.DatasetList.PurchaseComboSupplier();
            this.purchaseSupplierComboProcedureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseSupplierComboProcedureTableAdapter = new InventoryManagementSystem.DatasetList.PurchaseComboSupplierTableAdapters.PurchaseSupplierComboProcedureTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseSupplierwiseRpt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptSupplierwisePurchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseComboSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseSupplierComboProcedureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.rptPurchaseSupplierwise);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 600);
            this.panel1.TabIndex = 5;
            // 
            // rptPurchaseSupplierwise
            // 
            reportDataSource4.Name = "PurchaseSupplierwise";
            reportDataSource4.Value = this.rptSupplierwisePurchaseBindingSource;
            this.rptPurchaseSupplierwise.LocalReport.DataSources.Add(reportDataSource4);
            this.rptPurchaseSupplierwise.LocalReport.ReportEmbeddedResource = "InventoryManagementSystem.Reports.PurchaseSupplierwise.rdlc";
            this.rptPurchaseSupplierwise.Location = new System.Drawing.Point(5, 108);
            this.rptPurchaseSupplierwise.Name = "rptPurchaseSupplierwise";
            this.rptPurchaseSupplierwise.Size = new System.Drawing.Size(790, 485);
            this.rptPurchaseSupplierwise.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.cmbSupplierName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Location = new System.Drawing.Point(5, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 48);
            this.panel2.TabIndex = 11;
            // 
            // cmbSupplierName
            // 
            this.cmbSupplierName.DataSource = this.purchaseSupplierComboProcedureBindingSource;
            this.cmbSupplierName.DisplayMember = "SupplierName";
            this.cmbSupplierName.FormattingEnabled = true;
            this.cmbSupplierName.Location = new System.Drawing.Point(286, 13);
            this.cmbSupplierName.Name = "cmbSupplierName";
            this.cmbSupplierName.Size = new System.Drawing.Size(196, 21);
            this.cmbSupplierName.TabIndex = 15;
            this.cmbSupplierName.ValueMember = "SupplierId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Supplier Name";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(494, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 33);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(5, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(790, 42);
            this.panel3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Purchase Supplierwise Report";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(751, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // purchaseSupplierwiseRpt
            // 
            this.purchaseSupplierwiseRpt.DataSetName = "PurchaseSupplierwiseRpt";
            this.purchaseSupplierwiseRpt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptSupplierwisePurchaseBindingSource
            // 
            this.rptSupplierwisePurchaseBindingSource.DataMember = "RptSupplierwisePurchase";
            this.rptSupplierwisePurchaseBindingSource.DataSource = this.purchaseSupplierwiseRpt;
            // 
            // rptSupplierwisePurchaseTableAdapter
            // 
            this.rptSupplierwisePurchaseTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseComboSupplier
            // 
            this.purchaseComboSupplier.DataSetName = "PurchaseComboSupplier";
            this.purchaseComboSupplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseSupplierComboProcedureBindingSource
            // 
            this.purchaseSupplierComboProcedureBindingSource.DataMember = "PurchaseSupplierComboProcedure";
            this.purchaseSupplierComboProcedureBindingSource.DataSource = this.purchaseComboSupplier;
            // 
            // purchaseSupplierComboProcedureTableAdapter
            // 
            this.purchaseSupplierComboProcedureTableAdapter.ClearBeforeFill = true;
            // 
            // PurchaseReportSupplierwise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "PurchaseReportSupplierwise";
            this.Text = "PurchaseReportSupplierwise";
            this.Load += new System.EventHandler(this.PurchaseReportSupplierwise_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PurchaseReportSupplierwise_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseSupplierwiseRpt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptSupplierwisePurchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseComboSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseSupplierComboProcedureBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rptPurchaseSupplierwise;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSupplierName;
        private System.Windows.Forms.BindingSource rptSupplierwisePurchaseBindingSource;
        private DatasetList.PurchaseSupplierwiseRpt purchaseSupplierwiseRpt;
        private DatasetList.PurchaseSupplierwiseRptTableAdapters.RptSupplierwisePurchaseTableAdapter rptSupplierwisePurchaseTableAdapter;
        private DatasetList.PurchaseComboSupplier purchaseComboSupplier;
        private System.Windows.Forms.BindingSource purchaseSupplierComboProcedureBindingSource;
        private DatasetList.PurchaseComboSupplierTableAdapters.PurchaseSupplierComboProcedureTableAdapter purchaseSupplierComboProcedureTableAdapter;
    }
}