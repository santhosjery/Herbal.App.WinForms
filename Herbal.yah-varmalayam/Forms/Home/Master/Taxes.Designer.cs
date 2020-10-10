namespace Herbal.yah_varmalayam.Forms
{
    partial class Taxes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblHeaderText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PanelTaxMaster = new System.Windows.Forms.Panel();
            this.BtnReset = new System.Windows.Forms.Button();
            this.ChkIsActive = new System.Windows.Forms.CheckBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtIGST = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnSaveTax = new System.Windows.Forms.Button();
            this.TxtCGST = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtSGST = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DataGridTaxMaster = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGSTPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGSTPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGSTPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.PanelTaxMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTaxMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.CurrentChanged += new System.EventHandler(this.bindingSource_CurrentChanged);
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
            this.LblHeaderText.Size = new System.Drawing.Size(1555, 48);
            this.LblHeaderText.TabIndex = 39;
            this.LblHeaderText.Text = "Tax Master";
            this.LblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelTaxMaster
            // 
            this.PanelTaxMaster.Controls.Add(this.DataGridTaxMaster);
            this.PanelTaxMaster.Controls.Add(this.BtnReset);
            this.PanelTaxMaster.Controls.Add(this.ChkIsActive);
            this.PanelTaxMaster.Controls.Add(this.bunifuCustomLabel4);
            this.PanelTaxMaster.Controls.Add(this.TxtIGST);
            this.PanelTaxMaster.Controls.Add(this.bunifuCustomLabel2);
            this.PanelTaxMaster.Controls.Add(this.BtnSaveTax);
            this.PanelTaxMaster.Controls.Add(this.TxtCGST);
            this.PanelTaxMaster.Controls.Add(this.bunifuCustomLabel3);
            this.PanelTaxMaster.Controls.Add(this.TxtSGST);
            this.PanelTaxMaster.Controls.Add(this.bunifuCustomLabel1);
            this.PanelTaxMaster.Location = new System.Drawing.Point(88, 63);
            this.PanelTaxMaster.Name = "PanelTaxMaster";
            this.PanelTaxMaster.Size = new System.Drawing.Size(1433, 528);
            this.PanelTaxMaster.TabIndex = 70;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnReset.Location = new System.Drawing.Point(484, 369);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(171, 71);
            this.BtnReset.TabIndex = 76;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            // 
            // ChkIsActive
            // 
            this.ChkIsActive.AutoSize = true;
            this.ChkIsActive.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkIsActive.Location = new System.Drawing.Point(288, 301);
            this.ChkIsActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkIsActive.Name = "ChkIsActive";
            this.ChkIsActive.Size = new System.Drawing.Size(365, 24);
            this.ChkIsActive.TabIndex = 70;
            this.ChkIsActive.Text = "(Check or Uncheck to change status)";
            this.ChkIsActive.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(66, 301);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(104, 29);
            this.bunifuCustomLabel4.TabIndex = 75;
            this.bunifuCustomLabel4.Text = "Is Active";
            // 
            // TxtIGST
            // 
            this.TxtIGST.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtIGST.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIGST.Location = new System.Drawing.Point(288, 217);
            this.TxtIGST.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtIGST.Name = "TxtIGST";
            this.TxtIGST.Size = new System.Drawing.Size(386, 37);
            this.TxtIGST.TabIndex = 69;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(66, 217);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(93, 29);
            this.bunifuCustomLabel2.TabIndex = 74;
            this.bunifuCustomLabel2.Text = "IGST %";
            // 
            // BtnSaveTax
            // 
            this.BtnSaveTax.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnSaveTax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveTax.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveTax.ForeColor = System.Drawing.Color.White;
            this.BtnSaveTax.Location = new System.Drawing.Point(288, 369);
            this.BtnSaveTax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSaveTax.Name = "BtnSaveTax";
            this.BtnSaveTax.Size = new System.Drawing.Size(188, 71);
            this.BtnSaveTax.TabIndex = 71;
            this.BtnSaveTax.Text = "Save";
            this.BtnSaveTax.UseVisualStyleBackColor = false;
            // 
            // TxtCGST
            // 
            this.TxtCGST.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtCGST.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCGST.Location = new System.Drawing.Point(288, 43);
            this.TxtCGST.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCGST.Name = "TxtCGST";
            this.TxtCGST.Size = new System.Drawing.Size(386, 37);
            this.TxtCGST.TabIndex = 67;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(66, 43);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(99, 29);
            this.bunifuCustomLabel3.TabIndex = 72;
            this.bunifuCustomLabel3.Text = "CGST %";
            // 
            // TxtSGST
            // 
            this.TxtSGST.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtSGST.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSGST.Location = new System.Drawing.Point(288, 126);
            this.TxtSGST.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSGST.Name = "TxtSGST";
            this.TxtSGST.Size = new System.Drawing.Size(386, 37);
            this.TxtSGST.TabIndex = 68;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(66, 126);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(97, 29);
            this.bunifuCustomLabel1.TabIndex = 73;
            this.bunifuCustomLabel1.Text = "SGST %";
            // 
            // DataGridTaxMaster
            // 
            this.DataGridTaxMaster.AllowUserToAddRows = false;
            this.DataGridTaxMaster.AllowUserToDeleteRows = false;
            this.DataGridTaxMaster.AllowUserToOrderColumns = true;
            this.DataGridTaxMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridTaxMaster.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridTaxMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridTaxMaster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridTaxMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridTaxMaster.ColumnHeadersHeight = 40;
            this.DataGridTaxMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridTaxMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CGSTPercentage,
            this.SGSTPercentage,
            this.IGSTPercentage,
            this.IsActive,
            this.Edit});
            this.DataGridTaxMaster.EnableHeadersVisualStyles = false;
            this.DataGridTaxMaster.Location = new System.Drawing.Point(700, 43);
            this.DataGridTaxMaster.Name = "DataGridTaxMaster";
            this.DataGridTaxMaster.ReadOnly = true;
            this.DataGridTaxMaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataGridTaxMaster.RowHeadersVisible = false;
            this.DataGridTaxMaster.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DataGridTaxMaster.RowTemplate.Height = 28;
            this.DataGridTaxMaster.Size = new System.Drawing.Size(681, 397);
            this.DataGridTaxMaster.TabIndex = 77;
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
            // CGSTPercentage
            // 
            this.CGSTPercentage.DataPropertyName = "CGSTPercentage";
            this.CGSTPercentage.FillWeight = 90F;
            this.CGSTPercentage.HeaderText = "CGST (%)";
            this.CGSTPercentage.MinimumWidth = 8;
            this.CGSTPercentage.Name = "CGSTPercentage";
            this.CGSTPercentage.ReadOnly = true;
            // 
            // SGSTPercentage
            // 
            this.SGSTPercentage.DataPropertyName = "SGSTPercentage";
            this.SGSTPercentage.FillWeight = 90F;
            this.SGSTPercentage.HeaderText = "SGST (%)";
            this.SGSTPercentage.MinimumWidth = 8;
            this.SGSTPercentage.Name = "SGSTPercentage";
            this.SGSTPercentage.ReadOnly = true;
            // 
            // IGSTPercentage
            // 
            this.IGSTPercentage.DataPropertyName = "IGSTPercentage";
            this.IGSTPercentage.FillWeight = 90F;
            this.IGSTPercentage.HeaderText = "IGST (%)";
            this.IGSTPercentage.MinimumWidth = 8;
            this.IGSTPercentage.Name = "IGSTPercentage";
            this.IGSTPercentage.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.FillWeight = 80F;
            this.IsActive.HeaderText = "Is Active";
            this.IsActive.MinimumWidth = 8;
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            this.IsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Edit";
            this.Edit.FillWeight = 50F;
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Taxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 892);
            this.Controls.Add(this.PanelTaxMaster);
            this.Controls.Add(this.LblHeaderText);
            this.Name = "Taxes";
            this.Text = "Taxes";
            this.Load += new System.EventHandler(this.Taxes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.PanelTaxMaster.ResumeLayout(false);
            this.PanelTaxMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTaxMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel LblHeaderText;
        private System.Windows.Forms.Panel PanelTaxMaster;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.CheckBox ChkIsActive;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtIGST;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Button BtnSaveTax;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtCGST;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtSGST;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.DataGridView DataGridTaxMaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGSTPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGSTPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGSTPercentage;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}