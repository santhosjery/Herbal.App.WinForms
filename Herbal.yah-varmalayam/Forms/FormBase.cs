using Herbal.yah_varmalayam.MessageBox;
using Herbal.yah_varmalayam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herbal.yah_varmalayam.Forms
{
    public class FormBase : Form
    {
        protected HerbalEntities herbalContext = new HerbalEntities();
        public MsgBoxMessages showMessageBox = new MsgBoxMessages();
        public UserViewModel userViewModel = new UserViewModel();
        public FormBase()
        {
            
        }
    }
}
