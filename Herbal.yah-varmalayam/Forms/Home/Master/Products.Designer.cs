namespace Herbal.yah_varmalayam.Forms
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtSearchItem = new Bunifu.Framework.UI.BunifuTextbox();
            this.BtnSaveProduct = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtProductCode = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.LblHeaderText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtProductName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.PanelProductMaster = new System.Windows.Forms.Panel();
            this.TxtPackQuantity = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtGST = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtSellingPrice = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ChkIsActive = new System.Windows.Forms.CheckBox();
            this.DataGridProductMaster = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.PanelProductMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProductMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(392, 27);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(181, 29);
            this.bunifuCustomLabel3.TabIndex = 65;
            this.bunifuCustomLabel3.Text = "Medicine Name";
            // 
            // TxtSearchItem
            // 
            this.TxtSearchItem.BackColor = System.Drawing.Color.White;
            this.TxtSearchItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtSearchItem.BackgroundImage")));
            this.TxtSearchItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtSearchItem.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchItem.ForeColor = System.Drawing.Color.SeaGreen;
            this.TxtSearchItem.Icon = ((System.Drawing.Image)(resources.GetObject("TxtSearchItem.Icon")));
            this.TxtSearchItem.Location = new System.Drawing.Point(49, 118);
            this.TxtSearchItem.Margin = new System.Windows.Forms.Padding(6);
            this.TxtSearchItem.Name = "TxtSearchItem";
            this.TxtSearchItem.Size = new System.Drawing.Size(414, 45);
            this.TxtSearchItem.TabIndex = 7;
            this.TxtSearchItem.text = "";
            this.TxtSearchItem.OnTextChange += new System.EventHandler(this.TxtSearchItem_OnTextChange);
            // 
            // BtnSaveProduct
            // 
            this.BtnSaveProduct.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnSaveProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveProduct.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveProduct.ForeColor = System.Drawing.Color.White;
            this.BtnSaveProduct.Location = new System.Drawing.Point(1096, 100);
            this.BtnSaveProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSaveProduct.Name = "BtnSaveProduct";
            this.BtnSaveProduct.Size = new System.Drawing.Size(188, 57);
            this.BtnSaveProduct.TabIndex = 14;
            this.BtnSaveProduct.Text = "Save";
            this.BtnSaveProduct.UseVisualStyleBackColor = false;
            this.BtnSaveProduct.Click += new System.EventHandler(this.BtnSaveProduct_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnReset.Location = new System.Drawing.Point(1292, 100);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(161, 57);
            this.BtnReset.TabIndex = 64;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(50, 27);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(172, 29);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Medicine Code";
            // 
            // TxtProductCode
            // 
            this.TxtProductCode.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtProductCode.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProductCode.Location = new System.Drawing.Point(224, 27);
            this.TxtProductCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtProductCode.Name = "TxtProductCode";
            this.TxtProductCode.Size = new System.Drawing.Size(132, 35);
            this.TxtProductCode.TabIndex = 12;
            this.TxtProductCode.Text = " ";
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
            this.LblHeaderText.Size = new System.Drawing.Size(1568, 48);
            this.LblHeaderText.TabIndex = 39;
            this.LblHeaderText.Text = "Product Master";
            this.LblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtProductName
            // 
            this.TxtProductName.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtProductName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProductName.Location = new System.Drawing.Point(591, 23);
            this.TxtProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(410, 37);
            this.TxtProductName.TabIndex = 13;
            // 
            // PanelProductMaster
            // 
            this.PanelProductMaster.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PanelProductMaster.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelProductMaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelProductMaster.Controls.Add(this.TxtPackQuantity);
            this.PanelProductMaster.Controls.Add(this.TxtGST);
            this.PanelProductMaster.Controls.Add(this.bunifuCustomLabel6);
            this.PanelProductMaster.Controls.Add(this.TxtSellingPrice);
            this.PanelProductMaster.Controls.Add(this.bunifuCustomLabel5);
            this.PanelProductMaster.Controls.Add(this.bunifuCustomLabel4);
            this.PanelProductMaster.Controls.Add(this.ChkIsActive);
            this.PanelProductMaster.Controls.Add(this.DataGridProductMaster);
            this.PanelProductMaster.Controls.Add(this.bunifuCustomLabel2);
            this.PanelProductMaster.Controls.Add(this.bunifuCustomLabel3);
            this.PanelProductMaster.Controls.Add(this.TxtProductName);
            this.PanelProductMaster.Controls.Add(this.BtnReset);
            this.PanelProductMaster.Controls.Add(this.TxtSearchItem);
            this.PanelProductMaster.Controls.Add(this.BtnSaveProduct);
            this.PanelProductMaster.Controls.Add(this.bunifuCustomLabel1);
            this.PanelProductMaster.Controls.Add(this.TxtProductCode);
            this.PanelProductMaster.Location = new System.Drawing.Point(39, 89);
            this.PanelProductMaster.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelProductMaster.Name = "PanelProductMaster";
            this.PanelProductMaster.Size = new System.Drawing.Size(1511, 789);
            this.PanelProductMaster.TabIndex = 38;
            // 
            // TxtPackQuantity
            // 
            this.TxtPackQuantity.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtPackQuantity.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPackQuantity.Location = new System.Drawing.Point(1096, 23);
            this.TxtPackQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPackQuantity.Name = "TxtPackQuantity";
            this.TxtPackQuantity.Size = new System.Drawing.Size(188, 37);
            this.TxtPackQuantity.TabIndex = 78;
            // 
            // TxtGST
            // 
            this.TxtGST.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtGST.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGST.Location = new System.Drawing.Point(904, 110);
            this.TxtGST.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtGST.Name = "TxtGST";
            this.TxtGST.Size = new System.Drawing.Size(97, 37);
            this.TxtGST.TabIndex = 77;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(824, 118);
            this.bunifuCustomLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(58, 29);
            this.bunifuCustomLabel6.TabIndex = 76;
            this.bunifuCustomLabel6.Text = "GST";
            // 
            // TxtSellingPrice
            // 
            this.TxtSellingPrice.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtSellingPrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSellingPrice.Location = new System.Drawing.Point(660, 114);
            this.TxtSellingPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSellingPrice.Name = "TxtSellingPrice";
            this.TxtSellingPrice.Size = new System.Drawing.Size(124, 37);
            this.TxtSellingPrice.TabIndex = 75;
            this.TxtSellingPrice.TextChanged += new System.EventHandler(this.TxtSellingPrice_TextChanged);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(485, 122);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(146, 29);
            this.bunifuCustomLabel5.TabIndex = 74;
            this.bunifuCustomLabel5.Text = "Selling Price";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(1024, 23);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(64, 29);
            this.bunifuCustomLabel4.TabIndex = 72;
            this.bunifuCustomLabel4.Text = "Pack";
            // 
            // ChkIsActive
            // 
            this.ChkIsActive.AutoSize = true;
            this.ChkIsActive.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkIsActive.Location = new System.Drawing.Point(1431, 38);
            this.ChkIsActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkIsActive.Name = "ChkIsActive";
            this.ChkIsActive.Size = new System.Drawing.Size(22, 21);
            this.ChkIsActive.TabIndex = 71;
            this.ChkIsActive.UseVisualStyleBackColor = true;
            // 
            // DataGridProductMaster
            // 
            this.DataGridProductMaster.AllowUserToAddRows = false;
            this.DataGridProductMaster.AllowUserToDeleteRows = false;
            this.DataGridProductMaster.AllowUserToOrderColumns = true;
            this.DataGridProductMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridProductMaster.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridProductMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridProductMaster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridProductMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridProductMaster.ColumnHeadersHeight = 40;
            this.DataGridProductMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridProductMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProductCode,
            this.ProductName,
            this.PackQuantity,
            this.SellingPrice,
            this.GST,
            this.IsActive,
            this.CreatedOn,
            this.Edit,
            this.Delete});
            this.DataGridProductMaster.EnableHeadersVisualStyles = false;
            this.DataGridProductMaster.Location = new System.Drawing.Point(49, 172);
            this.DataGridProductMaster.Name = "DataGridProductMaster";
            this.DataGridProductMaster.ReadOnly = true;
            this.DataGridProductMaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataGridProductMaster.RowHeadersVisible = false;
            this.DataGridProductMaster.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DataGridProductMaster.RowTemplate.Height = 28;
            this.DataGridProductMaster.Size = new System.Drawing.Size(1404, 595);
            this.DataGridProductMaster.TabIndex = 68;
            this.DataGridProductMaster.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridProductMaster_CellMouseClick);
            this.DataGridProductMaster.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridProductMaster_ColumnHeaderMouseClick);
            this.DataGridProductMaster.Click += new System.EventHandler(this.DataGridProductMaster_Click);
            this.DataGridProductMaster.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridProductMaster_MouseClick);
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
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "ProductCode";
            this.ProductCode.HeaderText = "Medicine Code";
            this.ProductCode.MinimumWidth = 8;
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.FillWeight = 240F;
            this.ProductName.HeaderText = "Medicine Name";
            this.ProductName.MinimumWidth = 8;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // PackQuantity
            // 
            this.PackQuantity.DataPropertyName = "PackQuantity";
            this.PackQuantity.FillWeight = 80F;
            this.PackQuantity.HeaderText = "Pack";
            this.PackQuantity.MinimumWidth = 8;
            this.PackQuantity.Name = "PackQuantity";
            this.PackQuantity.ReadOnly = true;
            // 
            // SellingPrice
            // 
            this.SellingPrice.DataPropertyName = "SellingPrice";
            this.SellingPrice.HeaderText = "Selling Price";
            this.SellingPrice.MinimumWidth = 8;
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.ReadOnly = true;
            // 
            // GST
            // 
            this.GST.DataPropertyName = "GST";
            this.GST.FillWeight = 50F;
            this.GST.HeaderText = "GST";
            this.GST.MinimumWidth = 8;
            this.GST.Name = "GST";
            this.GST.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.FillWeight = 70F;
            this.IsActive.HeaderText = "Is Active";
            this.IsActive.MinimumWidth = 8;
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            this.IsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CreatedOn
            // 
            this.CreatedOn.DataPropertyName = "CreatedOn";
            this.CreatedOn.FillWeight = 130F;
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
            this.Delete.FillWeight = 60F;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(1308, 30);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(104, 29);
            this.bunifuCustomLabel2.TabIndex = 66;
            this.bunifuCustomLabel2.Text = "Is Active";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 892);
            this.Controls.Add(this.LblHeaderText);
            this.Controls.Add(this.PanelProductMaster);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.PanelProductMaster.ResumeLayout(false);
            this.PanelProductMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProductMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuTextbox TxtSearchItem;
        private System.Windows.Forms.Button BtnSaveProduct;
        private System.Windows.Forms.Button BtnReset;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtProductCode;
        private Bunifu.Framework.UI.BunifuCustomLabel LblHeaderText;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtProductName;
        private System.Windows.Forms.Panel PanelProductMaster;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.DataGridView DataGridProductMaster;
        private System.Windows.Forms.CheckBox ChkIsActive;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtSellingPrice;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtPackQuantity;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtGST;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn GST;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}