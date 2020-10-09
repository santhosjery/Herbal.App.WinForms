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

        /// <summary>
        /// Top form names
        public const string ProductFormName = "Product Master";
        public const string TaxMasterFormName = "Tax Master";
        public const string CompanyDetailFormName = "Company Details";
        public const string ManageUserFormName = "Manage User";
        public const string PurchaseReportFormName = "Purchase Report";
        public const string SalesReportFormName = "Sales Report";
        public const string StockReportFormName = "Stock Report";
        public const string PurchaseFormName = "Purchase";
        public const string SalesFormName = "Sales";
        public const string HomeFormName = "Home";
        /// </summary>


        public static string LogException(Exception ex)
        {
            return "Following Error occured while processing your request: " + ex.Message;
        }
    }
}
