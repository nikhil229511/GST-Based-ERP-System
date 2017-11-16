namespace InventoryManagementSystem
{
    partial class ItemwiseStockDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemwiseStockDetail));
            this.itemWiseStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemwiseStock = new InventoryManagementSystem.DatasetList.ItemwiseStock();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rptStockItemwise = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbBrandName = new System.Windows.Forms.ComboBox();
            this.itemMasterComboBrandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemMasterComboBrand = new InventoryManagementSystem.DatasetList.ItemMasterComboBrand();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.itemMasterComboBrandTableAdapter = new InventoryManagementSystem.DatasetList.ItemMasterComboBrandTableAdapters.ItemMasterComboBrandTableAdapter();
            this.itemWiseStockTableAdapter = new InventoryManagementSystem.DatasetList.ItemwiseStockTableAdapters.ItemWiseStockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.itemWiseStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemwiseStock)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemMasterComboBrandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMasterComboBrand)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // itemWiseStockBindingSource
            // 
            this.itemWiseStockBindingSource.DataMember = "ItemWiseStock";
            this.itemWiseStockBindingSource.DataSource = this.itemwiseStock;
            // 
            // itemwiseStock
            // 
            this.itemwiseStock.DataSetName = "ItemwiseStock";
            this.itemwiseStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.rptStockItemwise);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 600);
            this.panel1.TabIndex = 5;
            // 
            // rptStockItemwise
            // 
            reportDataSource1.Name = "ItemwiseStock";
            reportDataSource1.Value = this.itemWiseStockBindingSource;
            this.rptStockItemwise.LocalReport.DataSources.Add(reportDataSource1);
            this.rptStockItemwise.LocalReport.ReportEmbeddedResource = "InventoryManagementSystem.Reports.ItemWiseStock.rdlc";
            this.rptStockItemwise.Location = new System.Drawing.Point(5, 108);
            this.rptStockItemwise.Name = "rptStockItemwise";
            this.rptStockItemwise.Size = new System.Drawing.Size(790, 485);
            this.rptStockItemwise.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.cmbBrandName);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(5, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 48);
            this.panel2.TabIndex = 11;
            // 
            // cmbBrandName
            // 
            this.cmbBrandName.DataSource = this.itemMasterComboBrandBindingSource;
            this.cmbBrandName.DisplayMember = "BrandName";
            this.cmbBrandName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrandName.FormattingEnabled = true;
            this.cmbBrandName.Location = new System.Drawing.Point(285, 10);
            this.cmbBrandName.Name = "cmbBrandName";
            this.cmbBrandName.Size = new System.Drawing.Size(173, 27);
            this.cmbBrandName.TabIndex = 14;
            this.cmbBrandName.ValueMember = "BrandID";
            // 
            // itemMasterComboBrandBindingSource
            // 
            this.itemMasterComboBrandBindingSource.DataMember = "ItemMasterComboBrand";
            this.itemMasterComboBrandBindingSource.DataSource = this.itemMasterComboBrand;
            // 
            // itemMasterComboBrand
            // 
            this.itemMasterComboBrand.DataSetName = "ItemMasterComboBrand";
            this.itemMasterComboBrand.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(473, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 33);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Brand Name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(5, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(790, 42);
            this.panel3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Itemwise Stock Detail";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(753, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // itemMasterComboBrandTableAdapter
            // 
            this.itemMasterComboBrandTableAdapter.ClearBeforeFill = true;
            // 
            // itemWiseStockTableAdapter
            // 
            this.itemWiseStockTableAdapter.ClearBeforeFill = true;
            // 
            // ItemwiseStockDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ItemwiseStockDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemwiseStockDetail";
            this.Load += new System.EventHandler(this.ItemwiseStockDetail_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemwiseStockDetail_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.itemWiseStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemwiseStock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemMasterComboBrandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMasterComboBrand)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rptStockItemwise;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbBrandName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DatasetList.ItemMasterComboBrand itemMasterComboBrand;
        private System.Windows.Forms.BindingSource itemMasterComboBrandBindingSource;
        private DatasetList.ItemMasterComboBrandTableAdapters.ItemMasterComboBrandTableAdapter itemMasterComboBrandTableAdapter;
        private System.Windows.Forms.BindingSource itemWiseStockBindingSource;
        private DatasetList.ItemwiseStock itemwiseStock;
        private DatasetList.ItemwiseStockTableAdapters.ItemWiseStockTableAdapter itemWiseStockTableAdapter;
    }
}