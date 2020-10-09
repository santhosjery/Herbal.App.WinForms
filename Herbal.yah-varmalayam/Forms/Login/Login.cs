using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herbal.yah_varmalayam.Forms.Login
{
    public partial class Login : FormBase
    {
        public Login()
        {
            //this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnloginmain_Click(object sender, EventArgs e)
        {
            try
            {
                var userDetail = herbalContext.AppUsers.Where(_ =>
                                  _.UserName == TxtUserName.Text.ToString() && _.Password == TxtPassword.Text.ToString()
                                   && _.IsActive == true).FirstOrDefault();
                if (userDetail != null)
                {
                    var loggedInUserDetail = new UserViewModel(userDetail.Id);
                    showMessageBox.ShowMessage("Success");
                }
                else
                {
                    showMessageBox.ShowMessage(string.Format(Utility.InvalidMessage, "Invalid username or password"));
                }
            }
            catch(Exception ex)
            {
                showMessageBox.ShowMessage(Utility.LogException(ex));
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            int result = showMessageBox.ShowMessage(Utility.ExitTitle, Utility.ExitTitleMessage);
            if (result == 1)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
