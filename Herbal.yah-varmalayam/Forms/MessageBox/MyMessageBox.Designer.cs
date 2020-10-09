namespace Herbal.yah_varmalayam.MessageBox
{
    partial class MyMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMessageBox));
            this.panel1 = new System.Windows.Forms.Panel();
            this.msgboxbtncancel = new System.Windows.Forms.Button();
            this.msgboxbtnok = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.message = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.msgboxbtncancel);
            this.panel1.Controls.Add(this.msgboxbtnok);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.message);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 230);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // msgboxbtncancel
            // 
            this.msgboxbtncancel.BackColor = System.Drawing.Color.Gray;
            this.msgboxbtncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.msgboxbtncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgboxbtncancel.Location = new System.Drawing.Point(360, 175);
            this.msgboxbtncancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.msgboxbtncancel.Name = "msgboxbtncancel";
            this.msgboxbtncancel.Size = new System.Drawing.Size(122, 46);
            this.msgboxbtncancel.TabIndex = 46;
            this.msgboxbtncancel.Text = "Cancel.";
            this.msgboxbtncancel.UseVisualStyleBackColor = false;
            this.msgboxbtncancel.Click += new System.EventHandler(this.btncancel_Click_1);
            // 
            // msgboxbtnok
            // 
            this.msgboxbtnok.BackColor = System.Drawing.Color.Gray;
            this.msgboxbtnok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.msgboxbtnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgboxbtnok.Location = new System.Drawing.Point(226, 175);
            this.msgboxbtnok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.msgboxbtnok.Name = "msgboxbtnok";
            this.msgboxbtnok.Size = new System.Drawing.Size(124, 46);
            this.msgboxbtnok.TabIndex = 1;
            this.msgboxbtnok.Text = "Ok.";
            this.msgboxbtnok.UseVisualStyleBackColor = false;
            this.msgboxbtnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(466, -3);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 40);
            this.label7.TabIndex = 45;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.message.Location = new System.Drawing.Point(8, 71);
            this.message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(241, 28);
            this.message.TabIndex = 3;
            this.message.Text = "bunifuCustomLabel2";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Black;
            this.title.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(6, 6);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(293, 34);
            this.title.TabIndex = 4;
            this.title.Text = "bunifuCustomLabel1";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 45);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MyMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(524, 245);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MyMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBox";
            this.Load += new System.EventHandler(this.MyMessageBox_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel message;
        private Bunifu.Framework.UI.BunifuCustomLabel title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button msgboxbtnok;
        private System.Windows.Forms.Button msgboxbtncancel;
    }
}