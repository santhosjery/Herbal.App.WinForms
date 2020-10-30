using Herbal.yah_varmalayam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbal.yah_varmalayam
{
    public static class BaseRepository
    {
        internal static HerbalEntities herbalContext = new HerbalEntities();

        internal static bool IsProductHasPurchaseOrSales(int productId)
        {
            //TO implement the purchase table check validation
            return false;
        }

        public static string GetNextProductCode()
        {
            var lstProductCode = herbalContext.Products.OrderByDescending(_ => _.Id).FirstOrDefault();
            if(lstProductCode != null)
            {
                return CodeGenerator.NextID(lstProductCode.ProductCode);
            }
            return CodeGenerator.NextID();
        }

        internal static bool IsScaleHasPurchaseOrSales(int scaleId)
        {
            return herbalContext.Products.Where(_ => _.ScaleId == scaleId).Any();
        }

        public static string GetNextPurchaseCode()
        {
            var lstProductCode = herbalContext.PurchaseHeaders.OrderByDescending(_ => _.Id).FirstOrDefault();
            if (lstProductCode != null)
            {
                return CodeGenerator.NextID(lstProductCode.PurchaseCode);
            }
            return CodeGenerator.NextID();
        }

        public static string GetNextSalesCode()
        {
            var lstProductCode = herbalContext.SalesHeaders.OrderByDescending(_ => _.Id).FirstOrDefault();
            if (lstProductCode != null)
            {
                return CodeGenerator.NextID(lstProductCode.SalesCode);
            }
            return CodeGenerator.NextID();
        }
    }
}
