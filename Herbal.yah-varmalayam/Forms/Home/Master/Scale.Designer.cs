namespace Herbal.yah_varmalayam.Forms
{
    partial class Scale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scale));
            this.LblHeaderText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PanelScaleMaster = new System.Windows.Forms.Panel();
            this.ChkIsActive = new System.Windows.Forms.CheckBox();
            this.DataGridScaleMaster = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScaleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtScaleName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.TxtSearchItem = new Bunifu.Framework.UI.BunifuTextbox();
            this.BtnSaveScale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.PanelScaleMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridScaleMaster)).BeginInit();
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
            this.LblHeaderText.Size = new System.Drawing.Size(1660, 48);
            this.LblHeaderText.TabIndex = 70;
            this.LblHeaderText.Text = "Scale Master";
            this.LblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelScaleMaster
            // 
            this.PanelScaleMaster.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PanelScaleMaster.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelScaleMaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelScaleMaster.Controls.Add(this.ChkIsActive);
            this.PanelScaleMaster.Controls.Add(this.DataGridScaleMaster);
            this.PanelScaleMaster.Controls.Add(this.bunifuCustomLabel2);
            this.PanelScaleMaster.Controls.Add(this.bunifuCustomLabel3);
            this.PanelScaleMaster.Controls.Add(this.TxtScaleName);
            this.PanelScaleMaster.Controls.Add(this.BtnReset);
            this.PanelScaleMaster.Controls.Add(this.TxtSearchItem);
            this.PanelScaleMaster.Controls.Add(this.BtnSaveScale);
            this.PanelScaleMaster.Location = new System.Drawing.Point(172, 106);
            this.PanelScaleMaster.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelScaleMaster.Name = "PanelScaleMaster";
            this.PanelScaleMaster.Size = new System.Drawing.Size(1234, 789);
            this.PanelScaleMaster.TabIndex = 71;
            // 
            // ChkIsActive
            // 
            this.ChkIsActive.AutoSize = true;
            this.ChkIsActive.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkIsActive.Location = new System.Drawing.Point(814, 42);
            this.ChkIsActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkIsActive.Name = "ChkIsActive";
            this.ChkIsActive.Size = new System.Drawing.Size(22, 21);
            this.ChkIsActive.TabIndex = 71;
            this.ChkIsActive.UseVisualStyleBackColor = true;
            // 
            // DataGridScaleMaster
            // 
            this.DataGridScaleMaster.AllowUserToAddRows = false;
            this.DataGridScaleMaster.AllowUserToDeleteRows = false;
            this.DataGridScaleMaster.AllowUserToOrderColumns = true;
            this.DataGridScaleMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridScaleMaster.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridScaleMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridScaleMaster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridScaleMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridScaleMaster.ColumnHeadersHeight = 40;
            this.DataGridScaleMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridScaleMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ScaleName,
            this.IsActive,
            this.CreatedOn,
            this.Edit,
            this.Delete});
            this.DataGridScaleMaster.EnableHeadersVisualStyles = false;
            this.DataGridScaleMaster.Location = new System.Drawing.Point(49, 172);
            this.DataGridScaleMaster.Name = "DataGridScaleMaster";
            this.DataGridScaleMaster.ReadOnly = true;
            this.DataGridScaleMaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataGridScaleMaster.RowHeadersVisible = false;
            this.DataGridScaleMaster.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DataGridScaleMaster.RowTemplate.Height = 28;
            this.DataGridScaleMaster.Size = new System.Drawing.Size(1121, 595);
            this.DataGridScaleMaster.TabIndex = 68;
            this.DataGridScaleMaster.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridScaleMaster_CellMouseClick);
            this.DataGridScaleMaster.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridScaleMaster_MouseClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 50F;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ScaleName
            // 
            this.ScaleName.DataPropertyName = "ScaleName";
            this.ScaleName.FillWeight = 110F;
            this.ScaleName.HeaderText = "Scale Name";
            this.ScaleName.MinimumWidth = 8;
            this.ScaleName.Name = "ScaleName";
            this.ScaleName.ReadOnly = true;
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
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.FillWeight = 50F;
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
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(680, 38);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(104, 29);
            this.bunifuCustomLabel2.TabIndex = 66;
            this.bunifuCustomLabel2.Text = "Is Active";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(56, 34);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(137, 29);
            this.bunifuCustomLabel3.TabIndex = 65;
            this.bunifuCustomLabel3.Text = "Scale Name";
            // 
            // TxtScaleName
            // 
            this.TxtScaleName.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtScaleName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtScaleName.Location = new System.Drawing.Point(250, 30);
            this.TxtScaleName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtScaleName.Name = "TxtScaleName";
            this.TxtScaleName.Size = new System.Drawing.Size(375, 37);
            this.TxtScaleName.TabIndex = 13;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnReset.Location = new System.Drawing.Point(895, 106);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(161, 57);
            this.BtnReset.TabIndex = 64;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
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
            // BtnSaveScale
            // 
            this.BtnSaveScale.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnSaveScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveScale.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveScale.ForeColor = System.Drawing.Color.White;
            this.BtnSaveScale.Location = new System.Drawing.Point(681, 106);
            this.BtnSaveScale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSaveScale.Name = "BtnSaveScale";
            this.BtnSaveScale.Size = new System.Drawing.Size(188, 57);
            this.BtnSaveScale.TabIndex = 14;
            this.BtnSaveScale.Text = "Save";
            this.BtnSaveScale.UseVisualStyleBackColor = false;
            this.BtnSaveScale.Click += new System.EventHandler(this.BtnSaveScale_Click);
            // 
            // Scale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1660, 892);
            this.Controls.Add(this.PanelScaleMaster);
            this.Controls.Add(this.LblHeaderText);
            this.Name = "Scale";
            this.Text = "Scale";
            this.Load += new System.EventHandler(this.Scale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.PanelScaleMaster.ResumeLayout(false);
            this.PanelScaleMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridScaleMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel LblHeaderText;
        private System.Windows.Forms.Panel PanelScaleMaster;
        private System.Windows.Forms.CheckBox ChkIsActive;
        private System.Windows.Forms.DataGridView DataGridScaleMaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScaleName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtScaleName;
        private System.Windows.Forms.Button BtnReset;
        private Bunifu.Framework.UI.BunifuTextbox TxtSearchItem;
        private System.Windows.Forms.Button BtnSaveScale;
    }
}