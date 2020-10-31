namespace Herbal.yah_varmalayam.Forms
{
    partial class PurchaseReport
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
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnAllpyFilter = new System.Windows.Forms.Button();
            this.DropDownProductName = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DtPickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DtPickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel18 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtPurchaseCode = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LblHeaderText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PanelPurchaseReport = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.PanelPurchaseReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnReset.Location = new System.Drawing.Point(1313, 31);
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
            this.BtnAllpyFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAllpyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAllpyFilter.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAllpyFilter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAllpyFilter.Location = new System.Drawing.Point(1101, 31);
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
            this.DropDownProductName.Location = new System.Drawing.Point(774, 55);
            this.DropDownProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DropDownProductName.Name = "DropDownProductName";
            this.DropDownProductName.Size = new System.Drawing.Size(306, 33);
            this.DropDownProductName.TabIndex = 69;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Georgia", 9F);
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(770, 16);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(125, 21);
            this.bunifuCustomLabel5.TabIndex = 70;
            this.bunifuCustomLabel5.Text = "Product Name";
            // 
            // DtPickerEndDate
            // 
            this.DtPickerEndDate.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.DtPickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtPickerEndDate.Location = new System.Drawing.Point(538, 57);
            this.DtPickerEndDate.Name = "DtPickerEndDate";
            this.DtPickerEndDate.Size = new System.Drawing.Size(205, 31);
            this.DtPickerEndDate.TabIndex = 68;
            this.DtPickerEndDate.Value = new System.DateTime(2020, 10, 11, 13, 25, 57, 0);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(534, 14);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(93, 24);
            this.bunifuCustomLabel1.TabIndex = 67;
            this.bunifuCustomLabel1.Text = "End Date";
            // 
            // DtPickerStartDate
            // 
            this.DtPickerStartDate.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.DtPickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtPickerStartDate.Location = new System.Drawing.Point(294, 58);
            this.DtPickerStartDate.Name = "DtPickerStartDate";
            this.DtPickerStartDate.Size = new System.Drawing.Size(205, 31);
            this.DtPickerStartDate.TabIndex = 66;
            this.DtPickerStartDate.Value = new System.DateTime(2020, 10, 11, 13, 25, 57, 0);
            this.DtPickerStartDate.ValueChanged += new System.EventHandler(this.DtPickerStartDate_ValueChanged);
            // 
            // bunifuCustomLabel18
            // 
            this.bunifuCustomLabel18.AutoSize = true;
            this.bunifuCustomLabel18.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel18.Location = new System.Drawing.Point(290, 15);
            this.bunifuCustomLabel18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel18.Name = "bunifuCustomLabel18";
            this.bunifuCustomLabel18.Size = new System.Drawing.Size(100, 24);
            this.bunifuCustomLabel18.TabIndex = 65;
            this.bunifuCustomLabel18.Text = "Start Date";
            // 
            // TxtPurchaseCode
            // 
            this.TxtPurchaseCode.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtPurchaseCode.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtPurchaseCode.Location = new System.Drawing.Point(31, 58);
            this.TxtPurchaseCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPurchaseCode.Name = "TxtPurchaseCode";
            this.TxtPurchaseCode.Size = new System.Drawing.Size(226, 33);
            this.TxtPurchaseCode.TabIndex = 64;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(27, 14);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(142, 24);
            this.bunifuCustomLabel2.TabIndex = 63;
            this.bunifuCustomLabel2.Text = "Purchase Code";
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
            this.LblHeaderText.TabIndex = 40;
            this.LblHeaderText.Text = "Purchase Report";
            this.LblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "PurchaseDataSet";
            reportDataSource1.Value = this.dataTable;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Herbal.yah_varmalayam.Forms.Home.Reports.Purchase.PurchaseReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(63, 232);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1802, 657);
            this.reportViewer1.TabIndex = 42;
            // 
            // PanelPurchaseReport
            // 
            this.PanelPurchaseReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPurchaseReport.Controls.Add(this.BtnReset);
            this.PanelPurchaseReport.Controls.Add(this.BtnAllpyFilter);
            this.PanelPurchaseReport.Controls.Add(this.DropDownProductName);
            this.PanelPurchaseReport.Controls.Add(this.bunifuCustomLabel5);
            this.PanelPurchaseReport.Controls.Add(this.DtPickerEndDate);
            this.PanelPurchaseReport.Controls.Add(this.bunifuCustomLabel1);
            this.PanelPurchaseReport.Controls.Add(this.DtPickerStartDate);
            this.PanelPurchaseReport.Controls.Add(this.bunifuCustomLabel18);
            this.PanelPurchaseReport.Controls.Add(this.TxtPurchaseCode);
            this.PanelPurchaseReport.Controls.Add(this.bunifuCustomLabel2);
            this.PanelPurchaseReport.Location = new System.Drawing.Point(188, 72);
            this.PanelPurchaseReport.Name = "PanelPurchaseReport";
            this.PanelPurchaseReport.Size = new System.Drawing.Size(1478, 117);
            this.PanelPurchaseReport.TabIndex = 41;
            // 
            // PurchaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 920);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.PanelPurchaseReport);
            this.Controls.Add(this.LblHeaderText);
            this.Name = "PurchaseReport";
            this.Text = "PurchaseReport";
            this.Load += new System.EventHandler(this.PurchaseReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.PanelPurchaseReport.ResumeLayout(false);
            this.PanelPurchaseReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel LblHeaderText;
        private System.Windows.Forms.DateTimePicker DtPickerEndDate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.DateTimePicker DtPickerStartDate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel18;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtPurchaseCode;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox DropDownProductName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnAllpyFilter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel PanelPurchaseReport;
    }
}