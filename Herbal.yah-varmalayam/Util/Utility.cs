using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbal.yah_varmalayam
{
    public static class Utility
    {
        public const string ExitTitle = "Exit";
        public const string ExitTitleMessage = "Do you want to Exit?";
        public const string InvalidMessage = "Invalid {0}";


        public static string LogException(Exception ex)
        {
            return "Following Error occured while processing your request: " + ex.Message;
        }
    }
}
