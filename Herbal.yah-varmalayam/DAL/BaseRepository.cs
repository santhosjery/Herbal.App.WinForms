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

        public static bool IsProductHasPurchaseOrSales(int productId)
        {
            //TO implement the purchase table check validation
            return false;
        }
    }
}
