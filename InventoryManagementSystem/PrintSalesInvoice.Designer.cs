namespace InventoryManagementSystem
{
    partial class PrintSalesInvoice
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintSalesInvoice));
            this.rptInvoicewiseSalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesInvoicewiseRpt = new InventoryManagementSystem.DatasetList.SalesInvoicewiseRpt();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rptSalesInvoice = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rptInvoicewiseSalesTableAdapter = new InventoryManagementSystem.DatasetList.SalesInvoicewiseRptTableAdapters.RptInvoicewiseSalesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rptInvoicewiseSalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInvoicewiseRpt)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rptInvoicewiseSalesBindingSource
            // 
            this.rptInvoicewiseSalesBindingSource.DataMember = "RptInvoicewiseSales";
            this.rptInvoicewiseSalesBindingSource.DataSource = this.salesInvoicewiseRpt;
            // 
            // salesInvoicewiseRpt
            // 
            this.salesInvoicewiseRpt.DataSetName = "SalesInvoicewiseRpt";
            this.salesInvoicewiseRpt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.rptSalesInvoice);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 600);
            this.panel1.TabIndex = 6;
            // 
            // rptSalesInvoice
            // 
            reportDataSource1.Name = "SalesPrintInvoice";
            reportDataSource1.Value = this.rptInvoicewiseSalesBindingSource;
            this.rptSalesInvoice.LocalReport.DataSources.Add(reportDataSource1);
            this.rptSalesInvoice.LocalReport.ReportEmbeddedResource = "InventoryManagementSystem.Reports.SalesPrintInvoice.rdlc";
            this.rptSalesInvoice.Location = new System.Drawing.Point(3, 49);
            this.rptSalesInvoice.Name = "rptSalesInvoice";
            this.rptSalesInvoice.Size = new System.Drawing.Size(795, 548);
            this.rptSalesInvoice.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(790, 42);
            this.panel3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sales Invoice";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(751, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rptInvoicewiseSalesTableAdapter
            // 
            this.rptInvoicewiseSalesTableAdapter.ClearBeforeFill = true;
            // 
            // PrintSalesInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "PrintSalesInvoice";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintSalesInvoice";
            this.Load += new System.EventHandler(this.PrintSalesInvoice_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrintSalesInvoice_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.rptInvoicewiseSalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInvoicewiseRpt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rptSalesInvoice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource rptInvoicewiseSalesBindingSource;
        private DatasetList.SalesInvoicewiseRpt salesInvoicewiseRpt;
        private DatasetList.SalesInvoicewiseRptTableAdapters.RptInvoicewiseSalesTableAdapter rptInvoicewiseSalesTableAdapter;
    }
}