using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbal.yah_varmalayam
{
    public class StockViewModel : BaseViewModel
    {
        public int ProductId { get; set; }
        public decimal? TotalPurchaseQuantity { get; set; }
        public decimal? TotalSalesQuantity { get; set; }
        public decimal? AvilableQuantity { get; set; }

        public List<StockViewModel> stockListViewModel = new List<StockViewModel>();

        public StockViewModel()
        {

        }

        public StockViewModel(int productId)
        {
            var detail = herbalContext.StockDetails.Where(_ => _.ProductId == productId && _.IsActive == true).FirstOrDefault();
            ProductId = productId;
            TotalPurchaseQuantity = 0;
            TotalSalesQuantity = 0;
            AvilableQuantity = 0;
            if (detail != null)
            {
                TotalPurchaseQuantity = detail.TotalPurchaseQuantity;
                TotalSalesQuantity = detail.TotalSalesQuantity;
                AvilableQuantity = detail.AvilableQuantity;
            }
        }
        public bool UpdateStockDetail(StockViewModel stockViewModel)
        {
            try
            {
                var detail = herbalContext.StockDetails.Where(_ => _.ProductId == stockViewModel.ProductId && _.IsActive == true).FirstOrDefault();
                if(detail == null)
                {
                    detail = new Models.StockDetail();
                    detail.ProductId = stockViewModel.ProductId;
                    detail.IsActive = true;
                    detail.CreatedOn = DateTime.Now;
                    detail.CreatedBy = stockViewModel.CreatedBy;
                    herbalContext.StockDetails.Add(detail);
                }
                else
                {
                    detail.ModifiedOn = DateTime.Now;
                    detail.ModifiedBy = stockViewModel.ModifiedBy;
                }
                detail.TotalPurchaseQuantity = stockViewModel.TotalPurchaseQuantity;
                detail.TotalSalesQuantity = stockViewModel.TotalSalesQuantity;
                detail.AvilableQuantity = stockViewModel.AvilableQuantity;
                herbalContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
