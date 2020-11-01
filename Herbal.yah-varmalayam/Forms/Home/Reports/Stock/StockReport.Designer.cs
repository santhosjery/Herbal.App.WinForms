namespace Herbal.yah_varmalayam.Forms
{
    partial class StockReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.LblHeaderText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PanelSalesReport = new System.Windows.Forms.Panel();
            this.DropDownSortByDirection = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DropDownSortByName = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnAllpyFilter = new System.Windows.Forms.Button();
            this.DropDownProductName = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.PanelSalesReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblHeaderText
            // 
            this.LblHeaderText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LblHeaderText.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblHeaderText.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.LblHeaderText.ForeColor = System.Drawing.Color.Blue;
            this.LblHeaderText.Location = new System.Drawing.Point(0, 0);
            this.LblHeaderText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHeaderText.Name = "LblHeaderText";
            this.LblHeaderText.Size = new System.Drawing.Size(1924, 53);
            this.LblHeaderText.TabIndex = 44;
            this.LblHeaderText.Text = "Stock Report";
            this.LblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "StockDataSet";
            reportDataSource1.Value = this.dataTable;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Herbal.yah_varmalayam.Forms.Home.Reports.Stock.StockReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(48, 252);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1802, 657);
            this.reportViewer1.TabIndex = 47;
            // 
            // PanelSalesReport
            // 
            this.PanelSalesReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSalesReport.Controls.Add(this.DropDownSortByDirection);
            this.PanelSalesReport.Controls.Add(this.bunifuCustomLabel2);
            this.PanelSalesReport.Controls.Add(this.DropDownSortByName);
            this.PanelSalesReport.Controls.Add(this.bunifuCustomLabel1);
            this.PanelSalesReport.Controls.Add(this.BtnReset);
            this.PanelSalesReport.Controls.Add(this.BtnAllpyFilter);
            this.PanelSalesReport.Controls.Add(this.DropDownProductName);
            this.PanelSalesReport.Controls.Add(this.bunifuCustomLabel5);
            this.PanelSalesReport.Location = new System.Drawing.Point(205, 91);
            this.PanelSalesReport.Name = "PanelSalesReport";
            this.PanelSalesReport.Size = new System.Drawing.Size(1410, 117);
            this.PanelSalesReport.TabIndex = 46;
            // 
            // DropDownSortByDirection
            // 
            this.DropDownSortByDirection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DropDownSortByDirection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DropDownSortByDirection.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.DropDownSortByDirection.FormattingEnabled = true;
            this.DropDownSortByDirection.Location = new System.Drawing.Point(723, 55);
            this.DropDownSortByDirection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DropDownSortByDirection.Name = "DropDownSortByDirection";
            this.DropDownSortByDirection.Size = new System.Drawing.Size(195, 33);
            this.DropDownSortByDirection.TabIndex = 75;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Georgia", 9F);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(719, 16);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(142, 21);
            this.bunifuCustomLabel2.TabIndex = 76;
            this.bunifuCustomLabel2.Text = "SortBy Direction";
            // 
            // DropDownSortByName
            // 
            this.DropDownSortByName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DropDownSortByName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DropDownSortByName.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.DropDownSortByName.FormattingEnabled = true;
            this.DropDownSortByName.Location = new System.Drawing.Point(375, 55);
            this.DropDownSortByName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DropDownSortByName.Name = "DropDownSortByName";
            this.DropDownSortByName.Size = new System.Drawing.Size(306, 33);
            this.DropDownSortByName.TabIndex = 73;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Georgia", 9F);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(371, 16);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(116, 21);
            this.bunifuCustomLabel1.TabIndex = 74;
            this.bunifuCustomLabel1.Text = "SortBy Name";
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnReset.Location = new System.Drawing.Point(1212, 31);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(148, 57);
            this.BtnReset.TabIndex = 72;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnAllpyFilter
            // 
            this.BtnAllpyFilter.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAllpyFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAllpyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAllpyFilter.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAllpyFilter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAllpyFilter.Location = new System.Drawing.Point(988, 31);
            this.BtnAllpyFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAllpyFilter.Name = "BtnAllpyFilter";
            this.BtnAllpyFilter.Size = new System.Drawing.Size(193, 57);
            this.BtnAllpyFilter.TabIndex = 71;
            this.BtnAllpyFilter.Text = "Apply Filter";
            this.BtnAllpyFilter.UseVisualStyleBackColor = false;
            this.BtnAllpyFilter.Click += new System.EventHandler(this.BtnAllpyFilter_Click);
            // 
            // DropDownProductName
            // 
            this.DropDownProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DropDownProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DropDownProductName.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.DropDownProductName.FormattingEnabled = true;
            this.DropDownProductName.Location = new System.Drawing.Point(33, 55);
            this.DropDownProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DropDownProductName.Name = "DropDownProductName";
            this.DropDownProductName.Size = new System.Drawing.Size(306, 33);
            this.DropDownProductName.TabIndex = 69;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Georgia", 9F);
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(29, 16);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(125, 21);
            this.bunifuCustomLabel5.TabIndex = 70;
            this.bunifuCustomLabel5.Text = "Product Name";
            // 
            // StockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 920);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.PanelSalesReport);
            this.Controls.Add(this.LblHeaderText);
            this.Name = "StockReport";
            this.Text = "StockReport";
            this.Load += new System.EventHandler(this.StockReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.PanelSalesReport.ResumeLayout(false);
            this.PanelSalesReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel LblHeaderText;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel PanelSalesReport;
        private System.Windows.Forms.ComboBox DropDownSortByDirection;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox DropDownSortByName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnAllpyFilter;
        private System.Windows.Forms.ComboBox DropDownProductName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
    }
}