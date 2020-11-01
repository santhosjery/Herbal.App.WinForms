using Herbal.yah_varmalayam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbal.yah_varmalayam
{
    public class ReportsRepository
    {
        internal static HerbalEntities herbalContext = new HerbalEntities();

        public static IEnumerable<getPurchaseReport_Result> getPurchaseReportResult(
            string purchaseCode, Nullable<int> purchaseId, 
            Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate, 
            Nullable<int> productId
            )
        {
            return herbalContext.getPurchaseReport(purchaseCode, purchaseId, startDate, endDate, productId).ToList();
        }

        public static IEnumerable<getSalesReport_Result> getSalesReportResult(
            string salesCode, Nullable<int> salesId,
            Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate,
            Nullable<int> productId
            )
        {
            return herbalContext.getSalesReport(salesCode, salesId, startDate, endDate, productId).ToList();
        }
    }
}
