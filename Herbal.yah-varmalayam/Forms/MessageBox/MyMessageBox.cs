using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herbal.yah_varmalayam.MessageBox
{
    public partial class MyMessageBox : Form
    {
        static MyMessageBox newMessageBox;
        static int buttonid;
        public MyMessageBox()
        {
            InitializeComponent();
        }
        public static int ShowBox(string txttitle,string txtmsg)
        {
            newMessageBox = new MyMessageBox();
            newMessageBox.title.Text = txttitle;
            newMessageBox.message.Text = txtmsg;
            newMessageBox.ShowDialog();
            return buttonid;
        }
        public static void singlemsgtext(string errmsg)
        {
            newMessageBox = new MyMessageBox();
            newMessageBox.title.Text = "Message.";
            newMessageBox.message.Text = errmsg;
            newMessageBox.msgboxbtnok.Hide();
            newMessageBox.msgboxbtncancel.Text = "Ok";
            newMessageBox.ShowDialog();
        }
        private void MyMessageBox_Load(object sender, EventArgs e)
        {
            message.MaximumSize = new Size(Bounds.Width, 0);
            message.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.AcceptButton = msgboxbtncancel;
            // label7.Focus = true;
        }
        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //btnok.Focused = true;
        }
        private void btncancel_Click_1(object sender, EventArgs e)
        {
            buttonid = 2;
            newMessageBox.Close();
        }
        private void btnok_Click(object sender, EventArgs e)
        {
            buttonid = 1;
            newMessageBox.Close();
        }
    }
}