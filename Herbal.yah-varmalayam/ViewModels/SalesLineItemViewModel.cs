using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbal.yah_varmalayam
{
    public class SalesLineItemViewModel : BaseViewModel
    {
        public int SrNo { get; set; }
        public int Id { get; set; }
        public string SalesLineItemCode { get; set; }
        public int SalesId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ConfigSellingPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal SalesAmount { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal? GST { get; set; }
        public decimal NetAmount { get; set; }

        public List<SalesLineItemViewModel> salesLineItemViewList = new List<SalesLineItemViewModel>();

        public SalesLineItemViewModel(int purchaseId)
        {
            var salesLineList = herbalContext.SalesLineItems.Where(_ => _.SalesId == purchaseId && _.IsActive == true)
                                        .OrderByDescending(_ => _.Id).ToList();
            foreach (var salesLine in salesLineList)
            {
                salesLineItemViewList.Add(new SalesLineItemViewModel(false, salesLine.Id));
            }
        }

        public SalesLineItemViewModel(bool showInactive, int salesLineId)
        {
            var salesLineDetail = herbalContext.SalesLineItems.Where(_ => _.Id == salesLineId && _.IsActive == true).Single();
            Id = salesLineDetail.Id;
            SalesLineItemCode = salesLineDetail.SalesLineItemCode;
            SalesId = salesLineDetail.SalesId;
            ProductId = salesLineDetail.ProductId;
            ProductName = salesLineDetail.Product.ProductName;
            ConfigSellingPrice = salesLineDetail.ConfigSellingPrice;
            Quantity = salesLineDetail.Quantity;
            SalesAmount = salesLineDetail.SalesAmount;
            GrossAmount = salesLineDetail.GrossAmount;
            GST = salesLineDetail.GST;
            NetAmount = salesLineDetail.NetAmount;
            IsActive = salesLineDetail.IsActive;
            CreatedOn = salesLineDetail.CreatedOn;
            CreatedBy = salesLineDetail.CreatedBy;
            ModifiedOn = salesLineDetail.ModifiedOn;
            ModifiedBy = salesLineDetail.ModifiedBy;
            Edit = "Edit";
            Delete = "Delete";
            IsActiveText = salesLineDetail.IsActive ? "Yes" : "No";
        }

    }
}
