namespace Herbal.yah_varmalayam.Forms
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblHeaderText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PanelSales = new System.Windows.Forms.Panel();
            this.DataGridSalesMaster = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrossAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGSTPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGSTPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnPrintSummary = new System.Windows.Forms.Button();
            this.BtnSaveSummary = new System.Windows.Forms.Button();
            this.TxtTotalNetAmount = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel19 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Grouppurchase = new System.Windows.Forms.GroupBox();
            this.LblScaleName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnResetLineItem = new System.Windows.Forms.Button();
            this.TxtNetAmount = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtDiscount = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel20 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnSaveLineItem = new System.Windows.Forms.Button();
            this.TxtCgstPercentage = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtSgstPercentage = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtSalesAmount = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtQuantity = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DropDownProductName = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtTotalSalesAmount = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel17 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DtPickerInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel18 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtDuesAmount = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtPaidAmount = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DropDownPaymentType = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtTotalDiscount = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtTotalTax = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtSalesCode = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtCustomerMobileNumber = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtCustomerName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtTotalGrossAmount = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.PanelSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSalesMaster)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.Grouppurchase.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.LblHeaderText.TabIndex = 41;
            this.LblHeaderText.Text = "Sales Entry";
            this.LblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelSales
            // 
            this.PanelSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelSales.AutoScroll = true;
            this.PanelSales.Controls.Add(this.DataGridSalesMaster);
            this.PanelSales.Controls.Add(this.groupBox2);
            this.PanelSales.Controls.Add(this.Grouppurchase);
            this.PanelSales.Controls.Add(this.groupBox1);
            this.PanelSales.Location = new System.Drawing.Point(54, 83);
            this.PanelSales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelSales.Name = "PanelSales";
            this.PanelSales.Size = new System.Drawing.Size(1838, 870);
            this.PanelSales.TabIndex = 40;
            // 
            // DataGridSalesMaster
            // 
            this.DataGridSalesMaster.AllowUserToAddRows = false;
            this.DataGridSalesMaster.AllowUserToDeleteRows = false;
            this.DataGridSalesMaster.AllowUserToOrderColumns = true;
            this.DataGridSalesMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridSalesMaster.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridSalesMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridSalesMaster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridSalesMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridSalesMaster.ColumnHeadersHeight = 40;
            this.DataGridSalesMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridSalesMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SrNo,
            this.ProductName,
            this.Quantity,
            this.SalesAmount,
            this.Discount,
            this.GrossAmount,
            this.CGSTPercentage,
            this.SGSTPercentage,
            this.TotalTax,
            this.NetAmount,
            this.CreatedOn,
            this.Edit,
            this.Delete});
            this.DataGridSalesMaster.EnableHeadersVisualStyles = false;
            this.DataGridSalesMaster.Location = new System.Drawing.Point(54, 468);
            this.DataGridSalesMaster.Name = "DataGridSalesMaster";
            this.DataGridSalesMaster.ReadOnly = true;
            this.DataGridSalesMaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataGridSalesMaster.RowHeadersVisible = false;
            this.DataGridSalesMaster.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DataGridSalesMaster.RowTemplate.Height = 28;
            this.DataGridSalesMaster.Size = new System.Drawing.Size(1756, 389);
            this.DataGridSalesMaster.TabIndex = 69;
            this.DataGridSalesMaster.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridSalesMaster_MouseClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // SrNo
            // 
            this.SrNo.DataPropertyName = "SrNo";
            this.SrNo.FillWeight = 50F;
            this.SrNo.HeaderText = "Sr.No";
            this.SrNo.MinimumWidth = 8;
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.FillWeight = 230F;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 8;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // SalesAmount
            // 
            this.SalesAmount.DataPropertyName = "SalesAmount";
            this.SalesAmount.FillWeight = 110F;
            this.SalesAmount.HeaderText = "Sales Amount";
            this.SalesAmount.MinimumWidth = 8;
            this.SalesAmount.Name = "SalesAmount";
            this.SalesAmount.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Discount";
            this.Discount.MinimumWidth = 8;
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // GrossAmount
            // 
            this.GrossAmount.DataPropertyName = "GrossAmount";
            this.GrossAmount.FillWeight = 120F;
            this.GrossAmount.HeaderText = "Gross Amount";
            this.GrossAmount.MinimumWidth = 8;
            this.GrossAmount.Name = "GrossAmount";
            this.GrossAmount.ReadOnly = true;
            // 
            // CGSTPercentage
            // 
            this.CGSTPercentage.DataPropertyName = "CGSTPercentage";
            this.CGSTPercentage.FillWeight = 80F;
            this.CGSTPercentage.HeaderText = "CGST%";
            this.CGSTPercentage.MinimumWidth = 8;
            this.CGSTPercentage.Name = "CGSTPercentage";
            this.CGSTPercentage.ReadOnly = true;
            this.CGSTPercentage.Visible = false;
            // 
            // SGSTPercentage
            // 
            this.SGSTPercentage.DataPropertyName = "SGSTPercentage";
            this.SGSTPercentage.FillWeight = 80F;
            this.SGSTPercentage.HeaderText = "SGST%";
            this.SGSTPercentage.MinimumWidth = 8;
            this.SGSTPercentage.Name = "SGSTPercentage";
            this.SGSTPercentage.ReadOnly = true;
            this.SGSTPercentage.Visible = false;
            // 
            // TotalTax
            // 
            this.TotalTax.DataPropertyName = "TotalTax";
            this.TotalTax.HeaderText = "GST Amount";
            this.TotalTax.MinimumWidth = 8;
            this.TotalTax.Name = "TotalTax";
            this.TotalTax.ReadOnly = true;
            // 
            // NetAmount
            // 
            this.NetAmount.DataPropertyName = "NetAmount";
            this.NetAmount.FillWeight = 120F;
            this.NetAmount.HeaderText = "Net Amount";
            this.NetAmount.MinimumWidth = 8;
            this.NetAmount.Name = "NetAmount";
            this.NetAmount.ReadOnly = true;
            // 
            // CreatedOn
            // 
            this.CreatedOn.DataPropertyName = "CreatedOn";
            this.CreatedOn.FillWeight = 140F;
            this.CreatedOn.HeaderText = "Created On";
            this.CreatedOn.MinimumWidth = 8;
            this.CreatedOn.Name = "CreatedOn";
            this.CreatedOn.ReadOnly = true;
            this.CreatedOn.Visible = false;
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Edit";
            this.Edit.FillWeight = 60F;
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.FillWeight = 70F;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnPrintSummary);
            this.groupBox2.Controls.Add(this.BtnSaveSummary);
            this.groupBox2.Controls.Add(this.TxtTotalNetAmount);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel19);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(1434, 265);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(376, 195);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summary";
            // 
            // BtnPrintSummary
            // 
            this.BtnPrintSummary.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnPrintSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPrintSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrintSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrintSummary.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintSummary.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPrintSummary.Location = new System.Drawing.Point(190, 128);
            this.BtnPrintSummary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPrintSummary.Name = "BtnPrintSummary";
            this.BtnPrintSummary.Size = new System.Drawing.Size(148, 57);
            this.BtnPrintSummary.TabIndex = 67;
            this.BtnPrintSummary.Text = "Print";
            this.BtnPrintSummary.UseVisualStyleBackColor = false;
            // 
            // BtnSaveSummary
            // 
            this.BtnSaveSummary.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnSaveSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSaveSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveSummary.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveSummary.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSaveSummary.Location = new System.Drawing.Point(24, 128);
            this.BtnSaveSummary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSaveSummary.Name = "BtnSaveSummary";
            this.BtnSaveSummary.Size = new System.Drawing.Size(148, 57);
            this.BtnSaveSummary.TabIndex = 66;
            this.BtnSaveSummary.Text = "Save";
            this.BtnSaveSummary.UseVisualStyleBackColor = false;
            this.BtnSaveSummary.Click += new System.EventHandler(this.BtnSaveSummary_Click);
            // 
            // TxtTotalNetAmount
            // 
            this.TxtTotalNetAmount.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtTotalNetAmount.Font = new System.Drawing.Font("Verdana", 12F);
            this.TxtTotalNetAmount.Location = new System.Drawing.Point(24, 65);
            this.TxtTotalNetAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTotalNetAmount.Name = "TxtTotalNetAmount";
            this.TxtTotalNetAmount.ReadOnly = true;
            this.TxtTotalNetAmount.Size = new System.Drawing.Size(278, 37);
            this.TxtTotalNetAmount.TabIndex = 63;
            // 
            // bunifuCustomLabel19
            // 
            this.bunifuCustomLabel19.AutoSize = true;
            this.bunifuCustomLabel19.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel19.Location = new System.Drawing.Point(20, 36);
            this.bunifuCustomLabel19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel19.Name = "bunifuCustomLabel19";
            this.bunifuCustomLabel19.Size = new System.Drawing.Size(180, 24);
            this.bunifuCustomLabel19.TabIndex = 62;
            this.bunifuCustomLabel19.Text = "Total Net Amount*";
            // 
            // Grouppurchase
            // 
            this.Grouppurchase.Controls.Add(this.LblScaleName);
            this.Grouppurchase.Controls.Add(this.BtnResetLineItem);
            this.Grouppurchase.Controls.Add(this.TxtNetAmount);
            this.Grouppurchase.Controls.Add(this.bunifuCustomLabel4);
            this.Grouppurchase.Controls.Add(this.TxtDiscount);
            this.Grouppurchase.Controls.Add(this.bunifuCustomLabel20);
            this.Grouppurchase.Controls.Add(this.BtnSaveLineItem);
            this.Grouppurchase.Controls.Add(this.TxtCgstPercentage);
            this.Grouppurchase.Controls.Add(this.bunifuCustomLabel13);
            this.Grouppurchase.Controls.Add(this.TxtSgstPercentage);
            this.Grouppurchase.Controls.Add(this.bunifuCustomLabel12);
            this.Grouppurchase.Controls.Add(this.TxtSalesAmount);
            this.Grouppurchase.Controls.Add(this.bunifuCustomLabel11);
            this.Grouppurchase.Controls.Add(this.TxtQuantity);
            this.Grouppurchase.Controls.Add(this.bunifuCustomLabel9);
            this.Grouppurchase.Controls.Add(this.DropDownProductName);
            this.Grouppurchase.Controls.Add(this.bunifuCustomLabel5);
            this.Grouppurchase.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.Grouppurchase.Location = new System.Drawing.Point(54, 265);
            this.Grouppurchase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Grouppurchase.Name = "Grouppurchase";
            this.Grouppurchase.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Grouppurchase.Size = new System.Drawing.Size(1372, 195);
            this.Grouppurchase.TabIndex = 23;
            this.Grouppurchase.TabStop = false;
            this.Grouppurchase.Text = "Line Item";
            // 
            // LblScaleName
            // 
            this.LblScaleName.AutoSize = true;
            this.LblScaleName.Font = new System.Drawing.Font("Georgia", 9F);
            this.LblScaleName.Location = new System.Drawing.Point(533, 75);
            this.LblScaleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblScaleName.Name = "LblScaleName";
            this.LblScaleName.Size = new System.Drawing.Size(51, 21);
            this.LblScaleName.TabIndex = 66;
            this.LblScaleName.Text = "Scale";
            // 
            // BtnResetLineItem
            // 
            this.BtnResetLineItem.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnResetLineItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnResetLineItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnResetLineItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResetLineItem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResetLineItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnResetLineItem.Location = new System.Drawing.Point(1187, 128);
            this.BtnResetLineItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnResetLineItem.Name = "BtnResetLineItem";
            this.BtnResetLineItem.Size = new System.Drawing.Size(170, 57);
            this.BtnResetLineItem.TabIndex = 65;
            this.BtnResetLineItem.Text = "Reset";
            this.BtnResetLineItem.UseVisualStyleBackColor = false;
            this.BtnResetLineItem.Click += new System.EventHandler(this.BtnResetLineItem_Click);
            // 
            // TxtNetAmount
            // 
            this.TxtNetAmount.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtNetAmount.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtNetAmount.Location = new System.Drawing.Point(1187, 68);
            this.TxtNetAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNetAmount.Name = "TxtNetAmount";
            this.TxtNetAmount.ReadOnly = true;
            this.TxtNetAmount.Size = new System.Drawing.Size(170, 33);
            this.TxtNetAmount.TabIndex = 61;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Georgia", 9F);
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(1183, 36);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(118, 21);
            this.bunifuCustomLabel4.TabIndex = 62;
            this.bunifuCustomLabel4.Text = "Net Amount*";
            // 
            // TxtDiscount
            // 
            this.TxtDiscount.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtDiscount.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtDiscount.Location = new System.Drawing.Point(826, 68);
            this.TxtDiscount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDiscount.Name = "TxtDiscount";
            this.TxtDiscount.Size = new System.Drawing.Size(154, 33);
            this.TxtDiscount.TabIndex = 12;
            this.TxtDiscount.TextChanged += new System.EventHandler(this.TxtDiscount_TextChanged);
            // 
            // bunifuCustomLabel20
            // 
            this.bunifuCustomLabel20.AutoSize = true;
            this.bunifuCustomLabel20.Font = new System.Drawing.Font("Georgia", 9F);
            this.bunifuCustomLabel20.Location = new System.Drawing.Point(821, 37);
            this.bunifuCustomLabel20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel20.Name = "bunifuCustomLabel20";
            this.bunifuCustomLabel20.Size = new System.Drawing.Size(82, 21);
            this.bunifuCustomLabel20.TabIndex = 45;
            this.bunifuCustomLabel20.Text = "Discount";
            // 
            // BtnSaveLineItem
            // 
            this.BtnSaveLineItem.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnSaveLineItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveLineItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveLineItem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveLineItem.ForeColor = System.Drawing.Color.White;
            this.BtnSaveLineItem.Location = new System.Drawing.Point(825, 128);
            this.BtnSaveLineItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSaveLineItem.Name = "BtnSaveLineItem";
            this.BtnSaveLineItem.Size = new System.Drawing.Size(323, 57);
            this.BtnSaveLineItem.TabIndex = 15;
            this.BtnSaveLineItem.Text = "Add Line Item";
            this.BtnSaveLineItem.UseVisualStyleBackColor = false;
            this.BtnSaveLineItem.Click += new System.EventHandler(this.BtnSaveLineItem_Click);
            // 
            // TxtCgstPercentage
            // 
            this.TxtCgstPercentage.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtCgstPercentage.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtCgstPercentage.Location = new System.Drawing.Point(1007, 68);
            this.TxtCgstPercentage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCgstPercentage.Name = "TxtCgstPercentage";
            this.TxtCgstPercentage.Size = new System.Drawing.Size(64, 33);
            this.TxtCgstPercentage.TabIndex = 13;
            this.TxtCgstPercentage.TextChanged += new System.EventHandler(this.TxtCgstPercentage_TextChanged);
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Georgia", 9F);
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(1002, 37);
            this.bunifuCustomLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(60, 21);
            this.bunifuCustomLabel13.TabIndex = 38;
            this.bunifuCustomLabel13.Text = "Cgst%";
            // 
            // TxtSgstPercentage
            // 
            this.TxtSgstPercentage.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtSgstPercentage.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtSgstPercentage.Location = new System.Drawing.Point(1086, 68);
            this.TxtSgstPercentage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSgstPercentage.Name = "TxtSgstPercentage";
            this.TxtSgstPercentage.Size = new System.Drawing.Size(62, 33);
            this.TxtSgstPercentage.TabIndex = 14;
            this.TxtSgstPercentage.TextChanged += new System.EventHandler(this.TxtSgstPercentage_TextChanged);
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Georgia", 9F);
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(1082, 37);
            this.bunifuCustomLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(58, 21);
            this.bunifuCustomLabel12.TabIndex = 36;
            this.bunifuCustomLabel12.Text = "Sgst%";
            // 
            // TxtSalesAmount
            // 
            this.TxtSalesAmount.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtSalesAmount.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtSalesAmount.Location = new System.Drawing.Point(628, 70);
            this.TxtSalesAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSalesAmount.Name = "TxtSalesAmount";
            this.TxtSalesAmount.Size = new System.Drawing.Size(170, 33);
            this.TxtSalesAmount.TabIndex = 11;
            this.TxtSalesAmount.TextChanged += new System.EventHandler(this.TxtPurchaseAmount_TextChanged);
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Georgia", 9F);
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(624, 38);
            this.bunifuCustomLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(130, 21);
            this.bunifuCustomLabel11.TabIndex = 34;
            this.bunifuCustomLabel11.Text = "Sales Amount*";
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtQuantity.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtQuantity.Location = new System.Drawing.Point(381, 70);
            this.TxtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(134, 33);
            this.TxtQuantity.TabIndex = 9;
            this.TxtQuantity.TextChanged += new System.EventHandler(this.TxtQuantity_TextChanged);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Georgia", 9F);
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(376, 38);
            this.bunifuCustomLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(89, 21);
            this.bunifuCustomLabel9.TabIndex = 30;
            this.bunifuCustomLabel9.Text = "Quantity*";
            // 
            // DropDownProductName
            // 
            this.DropDownProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DropDownProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DropDownProductName.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.DropDownProductName.FormattingEnabled = true;
            this.DropDownProductName.Location = new System.Drawing.Point(29, 68);
            this.DropDownProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DropDownProductName.Name = "DropDownProductName";
            this.DropDownProductName.Size = new System.Drawing.Size(312, 33);
            this.DropDownProductName.TabIndex = 4;
            this.DropDownProductName.SelectedIndexChanged += new System.EventHandler(this.DropDownProductName_SelectedIndexChanged);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Georgia", 9F);
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(25, 35);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(134, 21);
            this.bunifuCustomLabel5.TabIndex = 20;
            this.bunifuCustomLabel5.Text = "Product Name*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtTotalSalesAmount);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel17);
            this.groupBox1.Controls.Add(this.DtPickerInvoiceDate);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel18);
            this.groupBox1.Controls.Add(this.TxtDuesAmount);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel14);
            this.groupBox1.Controls.Add(this.TxtPaidAmount);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel10);
            this.groupBox1.Controls.Add(this.DropDownPaymentType);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel16);
            this.groupBox1.Controls.Add(this.TxtTotalDiscount);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel8);
            this.groupBox1.Controls.Add(this.TxtTotalTax);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel7);
            this.groupBox1.Controls.Add(this.TxtSalesCode);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.TxtCustomerMobileNumber);
            this.groupBox1.Controls.Add(this.TxtCustomerName);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Controls.Add(this.TxtTotalGrossAmount);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel15);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(54, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1756, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Header Info";
            // 
            // TxtTotalSalesAmount
            // 
            this.TxtTotalSalesAmount.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtTotalSalesAmount.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtTotalSalesAmount.Location = new System.Drawing.Point(12, 170);
            this.TxtTotalSalesAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTotalSalesAmount.Name = "TxtTotalSalesAmount";
            this.TxtTotalSalesAmount.ReadOnly = true;
            this.TxtTotalSalesAmount.Size = new System.Drawing.Size(226, 33);
            this.TxtTotalSalesAmount.TabIndex = 64;
            // 
            // bunifuCustomLabel17
            // 
            this.bunifuCustomLabel17.AutoSize = true;
            this.bunifuCustomLabel17.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel17.Location = new System.Drawing.Point(8, 132);
            this.bunifuCustomLabel17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel17.Name = "bunifuCustomLabel17";
            this.bunifuCustomLabel17.Size = new System.Drawing.Size(194, 24);
            this.bunifuCustomLabel17.TabIndex = 63;
            this.bunifuCustomLabel17.Text = "Total Sales Amount*";
            // 
            // DtPickerInvoiceDate
            // 
            this.DtPickerInvoiceDate.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.DtPickerInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtPickerInvoiceDate.Location = new System.Drawing.Point(289, 74);
            this.DtPickerInvoiceDate.Name = "DtPickerInvoiceDate";
            this.DtPickerInvoiceDate.Size = new System.Drawing.Size(275, 31);
            this.DtPickerInvoiceDate.TabIndex = 62;
            this.DtPickerInvoiceDate.Value = new System.DateTime(2020, 10, 11, 13, 25, 57, 0);
            // 
            // bunifuCustomLabel18
            // 
            this.bunifuCustomLabel18.AutoSize = true;
            this.bunifuCustomLabel18.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel18.Location = new System.Drawing.Point(285, 31);
            this.bunifuCustomLabel18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel18.Name = "bunifuCustomLabel18";
            this.bunifuCustomLabel18.Size = new System.Drawing.Size(132, 24);
            this.bunifuCustomLabel18.TabIndex = 61;
            this.bunifuCustomLabel18.Text = "Invoice Date*";
            // 
            // TxtDuesAmount
            // 
            this.TxtDuesAmount.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtDuesAmount.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtDuesAmount.Location = new System.Drawing.Point(1541, 170);
            this.TxtDuesAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDuesAmount.Name = "TxtDuesAmount";
            this.TxtDuesAmount.ReadOnly = true;
            this.TxtDuesAmount.Size = new System.Drawing.Size(190, 33);
            this.TxtDuesAmount.TabIndex = 60;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(1537, 129);
            this.bunifuCustomLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(134, 24);
            this.bunifuCustomLabel14.TabIndex = 59;
            this.bunifuCustomLabel14.Text = "Dues Amount";
            // 
            // TxtPaidAmount
            // 
            this.TxtPaidAmount.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtPaidAmount.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtPaidAmount.Location = new System.Drawing.Point(1285, 170);
            this.TxtPaidAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPaidAmount.Name = "TxtPaidAmount";
            this.TxtPaidAmount.Size = new System.Drawing.Size(192, 33);
            this.TxtPaidAmount.TabIndex = 58;
            this.TxtPaidAmount.TextChanged += new System.EventHandler(this.TxtPaidAmount_TextChanged);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(1280, 128);
            this.bunifuCustomLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(136, 24);
            this.bunifuCustomLabel10.TabIndex = 57;
            this.bunifuCustomLabel10.Text = "Paid Amount*";
            // 
            // DropDownPaymentType
            // 
            this.DropDownPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownPaymentType.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.DropDownPaymentType.FormattingEnabled = true;
            this.DropDownPaymentType.Location = new System.Drawing.Point(1041, 170);
            this.DropDownPaymentType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DropDownPaymentType.Name = "DropDownPaymentType";
            this.DropDownPaymentType.Size = new System.Drawing.Size(186, 33);
            this.DropDownPaymentType.TabIndex = 56;
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(1037, 129);
            this.bunifuCustomLabel16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(132, 24);
            this.bunifuCustomLabel16.TabIndex = 55;
            this.bunifuCustomLabel16.Text = "Payment type";
            // 
            // TxtTotalDiscount
            // 
            this.TxtTotalDiscount.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtTotalDiscount.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtTotalDiscount.Location = new System.Drawing.Point(289, 170);
            this.TxtTotalDiscount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTotalDiscount.Name = "TxtTotalDiscount";
            this.TxtTotalDiscount.ReadOnly = true;
            this.TxtTotalDiscount.Size = new System.Drawing.Size(145, 33);
            this.TxtTotalDiscount.TabIndex = 54;
            this.TxtTotalDiscount.TextChanged += new System.EventHandler(this.TxtTotalDiscount_TextChanged);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(285, 132);
            this.bunifuCustomLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(142, 24);
            this.bunifuCustomLabel8.TabIndex = 53;
            this.bunifuCustomLabel8.Text = "Total Discount";
            // 
            // TxtTotalTax
            // 
            this.TxtTotalTax.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtTotalTax.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtTotalTax.Location = new System.Drawing.Point(774, 170);
            this.TxtTotalTax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTotalTax.Name = "TxtTotalTax";
            this.TxtTotalTax.ReadOnly = true;
            this.TxtTotalTax.Size = new System.Drawing.Size(206, 33);
            this.TxtTotalTax.TabIndex = 52;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(771, 132);
            this.bunifuCustomLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(171, 24);
            this.bunifuCustomLabel7.TabIndex = 51;
            this.bunifuCustomLabel7.Text = "Total Tax Amount";
            // 
            // TxtSalesCode
            // 
            this.TxtSalesCode.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtSalesCode.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtSalesCode.Location = new System.Drawing.Point(12, 72);
            this.TxtSalesCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSalesCode.Name = "TxtSalesCode";
            this.TxtSalesCode.ReadOnly = true;
            this.TxtSalesCode.Size = new System.Drawing.Size(226, 33);
            this.TxtSalesCode.TabIndex = 25;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(8, 28);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(115, 24);
            this.bunifuCustomLabel2.TabIndex = 24;
            this.bunifuCustomLabel2.Text = "Sales Code*";
            // 
            // TxtCustomerMobileNumber
            // 
            this.TxtCustomerMobileNumber.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtCustomerMobileNumber.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtCustomerMobileNumber.Location = new System.Drawing.Point(1042, 75);
            this.TxtCustomerMobileNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCustomerMobileNumber.Name = "TxtCustomerMobileNumber";
            this.TxtCustomerMobileNumber.Size = new System.Drawing.Size(350, 33);
            this.TxtCustomerMobileNumber.TabIndex = 23;
            this.TxtCustomerMobileNumber.TextChanged += new System.EventHandler(this.TxtCustomerMobileNumber_TextChanged);
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtCustomerName.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtCustomerName.Location = new System.Drawing.Point(611, 75);
            this.TxtCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.Size = new System.Drawing.Size(369, 33);
            this.TxtCustomerName.TabIndex = 22;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(607, 31);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(156, 24);
            this.bunifuCustomLabel3.TabIndex = 18;
            this.bunifuCustomLabel3.Text = "Customer Name";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(1038, 31);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(245, 24);
            this.bunifuCustomLabel1.TabIndex = 19;
            this.bunifuCustomLabel1.Text = "Customer Mobile Number";
            // 
            // TxtTotalGrossAmount
            // 
            this.TxtTotalGrossAmount.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtTotalGrossAmount.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtTotalGrossAmount.Location = new System.Drawing.Point(506, 170);
            this.TxtTotalGrossAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTotalGrossAmount.Name = "TxtTotalGrossAmount";
            this.TxtTotalGrossAmount.ReadOnly = true;
            this.TxtTotalGrossAmount.Size = new System.Drawing.Size(206, 33);
            this.TxtTotalGrossAmount.TabIndex = 50;
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(502, 132);
            this.bunifuCustomLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(200, 24);
            this.bunifuCustomLabel15.TabIndex = 22;
            this.bunifuCustomLabel15.Text = "Total Gross Amount*";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 978);
            this.Controls.Add(this.LblHeaderText);
            this.Controls.Add(this.PanelSales);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.PanelSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSalesMaster)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Grouppurchase.ResumeLayout(false);
            this.Grouppurchase.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel LblHeaderText;
        private System.Windows.Forms.Panel PanelSales;
        private System.Windows.Forms.DataGridView DataGridSalesMaster;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnPrintSummary;
        private System.Windows.Forms.Button BtnSaveSummary;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtTotalNetAmount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel19;
        private System.Windows.Forms.GroupBox Grouppurchase;
        private Bunifu.Framework.UI.BunifuCustomLabel LblScaleName;
        private System.Windows.Forms.Button BtnResetLineItem;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtNetAmount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtDiscount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel20;
        private System.Windows.Forms.Button BtnSaveLineItem;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtCgstPercentage;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtSgstPercentage;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtSalesAmount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtQuantity;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.ComboBox DropDownProductName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtTotalSalesAmount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel17;
        private System.Windows.Forms.DateTimePicker DtPickerInvoiceDate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel18;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtDuesAmount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtPaidAmount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.ComboBox DropDownPaymentType;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtTotalDiscount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtTotalTax;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtSalesCode;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtCustomerMobileNumber;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtCustomerName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtTotalGrossAmount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrossAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGSTPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGSTPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}