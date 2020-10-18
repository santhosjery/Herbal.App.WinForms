using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbal.yah_varmalayam
{
    class PurchaseLineItemViewModel : BaseViewModel
    {
        public int SrNo { get; set; }
        public int Id { get; set; }
        public string PurchaseLineItemCode { get; set; }
        public int PurchaseId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Quantity { get; set; }
        public decimal PurchaseAmount { get; set; }
        public decimal? Discount { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal? CGST { get; set; }
        public decimal? SGST { get; set; }
        public decimal? IGST { get; set; }
        public decimal? TotalTax { get; set; }
        public decimal NetAmount { get; set; }
        public decimal? SellingPrice { get; set; }

        public List<PurchaseLineItemViewModel> purchaseLineItemViewList = new List<PurchaseLineItemViewModel>();
        public PurchaseLineItemViewModel(int purchaseId)
        {
            var productLineList = herbalContext.PurchaseLineItems.Where(_ => _.PurchaseId == purchaseId && _.IsActive == true)
                                        .OrderByDescending(_ => _.Id).ToList();
            foreach(var purchaseLine in productLineList)
            {
                purchaseLineItemViewList.Add(new PurchaseLineItemViewModel(false, purchaseLine.Id));
            }
        }
        public PurchaseLineItemViewModel(bool showInactive, int purchaseLineId)
        {
            var productLineList = herbalContext.PurchaseLineItems.Where(_ => _.Id == purchaseLineId && _.IsActive == true).Single();
            Id = productLineList.Id;
            PurchaseLineItemCode = productLineList.PurchaseLineItemCode;
            PurchaseId = productLineList.PurchaseId;
            ProductId = productLineList.ProductId;
            ProductName = productLineList.Product.ProductName;
            Quantity = productLineList.Quantity;
            PurchaseAmount = productLineList.PurchaseAmount;
            Discount = productLineList.Discount;
            GrossAmount = productLineList.GrossAmount;
            CGST = productLineList.CGST;
            SGST = productLineList.SGST;
            IGST = productLineList.IGST;
            TotalTax = productLineList.TotalTax;
            NetAmount = productLineList.NetAmount;
            SellingPrice = productLineList.SellingPrice;
            IsActive = productLineList.IsActive;
            CreatedOn = productLineList.CreatedOn;
            CreatedBy = productLineList.CreatedBy;
            ModifiedOn = productLineList.ModifiedOn;
            ModifiedBy = productLineList.ModifiedBy;
            Edit = "Edit";
            Delete = "Delete";
            IsActiveText = productLineList.IsActive ? "Yes" : "No";
        }
    }
}
