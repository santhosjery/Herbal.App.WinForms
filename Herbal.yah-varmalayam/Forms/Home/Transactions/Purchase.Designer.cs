﻿namespace Herbal.yah_varmalayam.Forms
{
    partial class Purchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblHeaderText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PanelPurchase = new System.Windows.Forms.Panel();
            this.DataGridPurchaseMaster = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrossAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GST = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.BtnResetLineItem = new System.Windows.Forms.Button();
            this.TxtNetAmount = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnSaveLineItem = new System.Windows.Forms.Button();
            this.TxtGST = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtPurchaseAmount = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtQuantity = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtTotalPurchaseAmount = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
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
            this.TxtPurchaseCode = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtClientMobileNumber = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtClientName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtClientInvoiceNo = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtTotalGrossAmount = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtAutoCompleteProduct = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.PanelPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPurchaseMaster)).BeginInit();
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
            this.LblHeaderText.TabIndex = 39;
            this.LblHeaderText.Text = "Purchase Stock Entry";
            this.LblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelPurchase
            // 
            this.PanelPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPurchase.AutoScroll = true;
            this.PanelPurchase.Controls.Add(this.DataGridPurchaseMaster);
            this.PanelPurchase.Controls.Add(this.groupBox2);
            this.PanelPurchase.Controls.Add(this.Grouppurchase);
            this.PanelPurchase.Controls.Add(this.groupBox1);
            this.PanelPurchase.Location = new System.Drawing.Point(54, 58);
            this.PanelPurchase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelPurchase.Name = "PanelPurchase";
            this.PanelPurchase.Size = new System.Drawing.Size(1838, 870);
            this.PanelPurchase.TabIndex = 38;
            // 
            // DataGridPurchaseMaster
            // 
            this.DataGridPurchaseMaster.AllowUserToAddRows = false;
            this.DataGridPurchaseMaster.AllowUserToDeleteRows = false;
            this.DataGridPurchaseMaster.AllowUserToOrderColumns = true;
            this.DataGridPurchaseMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridPurchaseMaster.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridPurchaseMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridPurchaseMaster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridPurchaseMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridPurchaseMaster.ColumnHeadersHeight = 40;
            this.DataGridPurchaseMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridPurchaseMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SrNo,
            this.ProductName,
            this.Quantity,
            this.PurchaseAmount,
            this.GrossAmount,
            this.GST,
            this.NetAmount,
            this.CreatedOn,
            this.Edit,
            this.Delete});
            this.DataGridPurchaseMaster.EnableHeadersVisualStyles = false;
            this.DataGridPurchaseMaster.Location = new System.Drawing.Point(54, 468);
            this.DataGridPurchaseMaster.Name = "DataGridPurchaseMaster";
            this.DataGridPurchaseMaster.ReadOnly = true;
            this.DataGridPurchaseMaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataGridPurchaseMaster.RowHeadersVisible = false;
            this.DataGridPurchaseMaster.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DataGridPurchaseMaster.RowTemplate.Height = 28;
            this.DataGridPurchaseMaster.Size = new System.Drawing.Size(1756, 389);
            this.DataGridPurchaseMaster.TabIndex = 69;
            this.DataGridPurchaseMaster.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridPurchaseMaster_MouseClick);
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
            this.ProductName.HeaderText = "Medicine Name";
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
            // PurchaseAmount
            // 
            this.PurchaseAmount.DataPropertyName = "PurchaseAmount";
            this.PurchaseAmount.FillWeight = 110F;
            this.PurchaseAmount.HeaderText = "Purchase Amount";
            this.PurchaseAmount.MinimumWidth = 8;
            this.PurchaseAmount.Name = "PurchaseAmount";
            this.PurchaseAmount.ReadOnly = true;
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
            // GST
            // 
            this.GST.DataPropertyName = "GST";
            this.GST.FillWeight = 80F;
            this.GST.HeaderText = "GST(Rs.)";
            this.GST.MinimumWidth = 8;
            this.GST.Name = "GST";
            this.GST.ReadOnly = true;
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
            this.BtnPrintSummary.Click += new System.EventHandler(this.BtnPrintSummary_Click);
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
            this.Grouppurchase.Controls.Add(this.TxtAutoCompleteProduct);
            this.Grouppurchase.Controls.Add(this.BtnResetLineItem);
            this.Grouppurchase.Controls.Add(this.TxtNetAmount);
            this.Grouppurchase.Controls.Add(this.bunifuCustomLabel4);
            this.Grouppurchase.Controls.Add(this.BtnSaveLineItem);
            this.Grouppurchase.Controls.Add(this.TxtGST);
            this.Grouppurchase.Controls.Add(this.bunifuCustomLabel13);
            this.Grouppurchase.Controls.Add(this.TxtPurchaseAmount);
            this.Grouppurchase.Controls.Add(this.bunifuCustomLabel11);
            this.Grouppurchase.Controls.Add(this.TxtQuantity);
            this.Grouppurchase.Controls.Add(this.bunifuCustomLabel9);
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
            // TxtGST
            // 
            this.TxtGST.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtGST.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtGST.Location = new System.Drawing.Point(1007, 68);
            this.TxtGST.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtGST.Name = "TxtGST";
            this.TxtGST.Size = new System.Drawing.Size(99, 33);
            this.TxtGST.TabIndex = 13;
            this.TxtGST.TabIndexChanged += new System.EventHandler(this.TxtGST_TabIndexChanged);
            this.TxtGST.TextChanged += new System.EventHandler(this.TxtCgstPercentage_TextChanged);
            this.TxtGST.Leave += new System.EventHandler(this.TxtGST_Leave);
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Georgia", 9F);
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(1002, 37);
            this.bunifuCustomLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(79, 21);
            this.bunifuCustomLabel13.TabIndex = 38;
            this.bunifuCustomLabel13.Text = "GST(Rs)";
            // 
            // TxtPurchaseAmount
            // 
            this.TxtPurchaseAmount.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtPurchaseAmount.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtPurchaseAmount.Location = new System.Drawing.Point(787, 69);
            this.TxtPurchaseAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPurchaseAmount.Name = "TxtPurchaseAmount";
            this.TxtPurchaseAmount.Size = new System.Drawing.Size(170, 33);
            this.TxtPurchaseAmount.TabIndex = 11;
            this.TxtPurchaseAmount.TabIndexChanged += new System.EventHandler(this.TxtPurchaseAmount_TabIndexChanged);
            this.TxtPurchaseAmount.TextChanged += new System.EventHandler(this.TxtGrossAmount_TextChanged);
            this.TxtPurchaseAmount.Leave += new System.EventHandler(this.TxtPurchaseAmount_Leave);
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Georgia", 9F);
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(783, 37);
            this.bunifuCustomLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(163, 21);
            this.bunifuCustomLabel11.TabIndex = 34;
            this.bunifuCustomLabel11.Text = "Purchase Amount*";
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtQuantity.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtQuantity.Location = new System.Drawing.Point(578, 69);
            this.TxtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(134, 33);
            this.TxtQuantity.TabIndex = 9;
            this.TxtQuantity.TabIndexChanged += new System.EventHandler(this.TxtQuantity_TabIndexChanged);
            this.TxtQuantity.TextChanged += new System.EventHandler(this.TxtQuantity_TextChanged);
            this.TxtQuantity.Leave += new System.EventHandler(this.TxtQuantity_Leave);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Georgia", 9F);
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(573, 37);
            this.bunifuCustomLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(89, 21);
            this.bunifuCustomLabel9.TabIndex = 30;
            this.bunifuCustomLabel9.Text = "Quantity*";
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
            this.groupBox1.Controls.Add(this.TxtTotalPurchaseAmount);
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
            this.groupBox1.Controls.Add(this.TxtPurchaseCode);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.TxtClientMobileNumber);
            this.groupBox1.Controls.Add(this.TxtClientName);
            this.groupBox1.Controls.Add(this.TxtClientInvoiceNo);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel6);
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
            // TxtTotalPurchaseAmount
            // 
            this.TxtTotalPurchaseAmount.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtTotalPurchaseAmount.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtTotalPurchaseAmount.Location = new System.Drawing.Point(12, 170);
            this.TxtTotalPurchaseAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTotalPurchaseAmount.Name = "TxtTotalPurchaseAmount";
            this.TxtTotalPurchaseAmount.ReadOnly = true;
            this.TxtTotalPurchaseAmount.Size = new System.Drawing.Size(226, 33);
            this.TxtTotalPurchaseAmount.TabIndex = 64;
            // 
            // bunifuCustomLabel17
            // 
            this.bunifuCustomLabel17.AutoSize = true;
            this.bunifuCustomLabel17.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel17.Location = new System.Drawing.Point(8, 132);
            this.bunifuCustomLabel17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel17.Name = "bunifuCustomLabel17";
            this.bunifuCustomLabel17.Size = new System.Drawing.Size(230, 24);
            this.bunifuCustomLabel17.TabIndex = 63;
            this.bunifuCustomLabel17.Text = "Total Purchase Amount*";
            // 
            // DtPickerInvoiceDate
            // 
            this.DtPickerInvoiceDate.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold);
            this.DtPickerInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtPickerInvoiceDate.Location = new System.Drawing.Point(628, 71);
            this.DtPickerInvoiceDate.Name = "DtPickerInvoiceDate";
            this.DtPickerInvoiceDate.Size = new System.Drawing.Size(275, 31);
            this.DtPickerInvoiceDate.TabIndex = 62;
            this.DtPickerInvoiceDate.Value = new System.DateTime(2020, 10, 11, 13, 25, 57, 0);
            // 
            // bunifuCustomLabel18
            // 
            this.bunifuCustomLabel18.AutoSize = true;
            this.bunifuCustomLabel18.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel18.Location = new System.Drawing.Point(624, 28);
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
            // TxtPurchaseCode
            // 
            this.TxtPurchaseCode.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtPurchaseCode.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtPurchaseCode.Location = new System.Drawing.Point(12, 72);
            this.TxtPurchaseCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPurchaseCode.Name = "TxtPurchaseCode";
            this.TxtPurchaseCode.ReadOnly = true;
            this.TxtPurchaseCode.Size = new System.Drawing.Size(226, 33);
            this.TxtPurchaseCode.TabIndex = 25;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(8, 28);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(151, 24);
            this.bunifuCustomLabel2.TabIndex = 24;
            this.bunifuCustomLabel2.Text = "Purchase Code*";
            // 
            // TxtClientMobileNumber
            // 
            this.TxtClientMobileNumber.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtClientMobileNumber.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtClientMobileNumber.Location = new System.Drawing.Point(1381, 72);
            this.TxtClientMobileNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtClientMobileNumber.Name = "TxtClientMobileNumber";
            this.TxtClientMobileNumber.Size = new System.Drawing.Size(350, 33);
            this.TxtClientMobileNumber.TabIndex = 23;
            this.TxtClientMobileNumber.TextChanged += new System.EventHandler(this.TxtClientMobileNumber_TextChanged);
            // 
            // TxtClientName
            // 
            this.TxtClientName.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtClientName.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtClientName.Location = new System.Drawing.Point(950, 72);
            this.TxtClientName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtClientName.Name = "TxtClientName";
            this.TxtClientName.Size = new System.Drawing.Size(346, 33);
            this.TxtClientName.TabIndex = 22;
            // 
            // TxtClientInvoiceNo
            // 
            this.TxtClientInvoiceNo.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtClientInvoiceNo.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtClientInvoiceNo.Location = new System.Drawing.Point(289, 75);
            this.TxtClientInvoiceNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtClientInvoiceNo.Name = "TxtClientInvoiceNo";
            this.TxtClientInvoiceNo.Size = new System.Drawing.Size(281, 33);
            this.TxtClientInvoiceNo.TabIndex = 21;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(285, 28);
            this.bunifuCustomLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(107, 24);
            this.bunifuCustomLabel6.TabIndex = 20;
            this.bunifuCustomLabel6.Text = "Invoice No";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(946, 28);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(143, 24);
            this.bunifuCustomLabel3.TabIndex = 18;
            this.bunifuCustomLabel3.Text = "Supplier Name";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(1377, 28);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(232, 24);
            this.bunifuCustomLabel1.TabIndex = 19;
            this.bunifuCustomLabel1.Text = "Supplier Mobile Number";
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
            // TxtAutoCompleteProduct
            // 
            this.TxtAutoCompleteProduct.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtAutoCompleteProduct.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.TxtAutoCompleteProduct.Location = new System.Drawing.Point(29, 69);
            this.TxtAutoCompleteProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAutoCompleteProduct.Name = "TxtAutoCompleteProduct";
            this.TxtAutoCompleteProduct.Size = new System.Drawing.Size(478, 33);
            this.TxtAutoCompleteProduct.TabIndex = 66;
            this.TxtAutoCompleteProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtAutoCompleteProduct_KeyDown);
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 978);
            this.Controls.Add(this.LblHeaderText);
            this.Controls.Add(this.PanelPurchase);
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.PanelPurchase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPurchaseMaster)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Grouppurchase.ResumeLayout(false);
            this.Grouppurchase.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtGST;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private System.Windows.Forms.Button BtnSaveLineItem;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtPurchaseAmount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel LblHeaderText;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtClientInvoiceNo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtQuantity;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtTotalGrossAmount;
        private System.Windows.Forms.Panel PanelPurchase;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private System.Windows.Forms.GroupBox Grouppurchase;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtClientMobileNumber;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtClientName;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtPurchaseCode;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtNetAmount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.Button BtnResetLineItem;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtTotalNetAmount;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtDuesAmount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel19;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtPaidAmount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.ComboBox DropDownPaymentType;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtTotalDiscount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtTotalTax;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnPrintSummary;
        private System.Windows.Forms.Button BtnSaveSummary;
        private System.Windows.Forms.DataGridView DataGridPurchaseMaster;
        private System.Windows.Forms.DateTimePicker DtPickerInvoiceDate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel18;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtTotalPurchaseAmount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrossAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn GST;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtAutoCompleteProduct;
    }
}