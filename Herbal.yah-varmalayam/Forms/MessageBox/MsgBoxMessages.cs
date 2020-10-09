using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbal.yah_varmalayam.MessageBox
{
    public class MsgBoxMessages
    {
        public int ShowMessage(string title,string msg)
        {
            return MyMessageBox.ShowBox(title,msg);
        }
        public void ShowMessage(string msg)
        {
             MyMessageBox.singlemsgtext(msg);
        }
    }
}