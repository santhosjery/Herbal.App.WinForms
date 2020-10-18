using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbal.yah_varmalayam
{
    class PurchaseHeaderViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public string PurchaseCode { get; set; }
        public string ClientName { get; set; }
        public long? ClientMobileNumber { get; set; }
        public string ClientInvoiceNumber { get; set; }
        public int? PaymentTypeId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal TotalPurchaseAmount { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalGrossAmount { get; set; }
        public decimal? TotalTaxAmount { get; set; }
        public decimal TotalNetAmount { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal DueAmount { get; set; }

        public List<PurchaseHeaderViewModel> purchaseHeaderViewList = new List<PurchaseHeaderViewModel>();
        public PurchaseHeaderViewModel()
        {
            var productHeaderList = herbalContext.PurchaseHeaders.Where(_ => _.IsActive == true)
                                        .OrderByDescending(_ => _.Id).Take(10).ToList();
            foreach (var productHeader in productHeaderList)
            {
                purchaseHeaderViewList.Add(new PurchaseHeaderViewModel(productHeader.Id));
            }
        }

        public PurchaseHeaderViewModel(int id)
        {
            var productHeaderDetail = herbalContext.PurchaseHeaders.Where(_ => _.Id == id).Single();
            Id = productHeaderDetail.Id;
            PurchaseCode = productHeaderDetail.PurchaseCode;
            ClientName = productHeaderDetail.ClientName;
            ClientMobileNumber = productHeaderDetail.ClientMobileNumber;
            ClientInvoiceNumber = productHeaderDetail.ClientInvoiceNumber;
            PaymentTypeId = productHeaderDetail.PaymentTypeId;
            PurchaseDate = productHeaderDetail.PurchaseDate;
            TotalPurchaseAmount = productHeaderDetail.TotalPurchaseAmount;
            TotalDiscount = productHeaderDetail.TotalDiscount;
            TotalGrossAmount = productHeaderDetail.TotalGrossAmount;
            TotalTaxAmount = productHeaderDetail.TotalTaxAmount;
            TotalNetAmount = productHeaderDetail.TotalNetAmount;
            AmountPaid = productHeaderDetail.AmountPaid;
            DueAmount = productHeaderDetail.DueAmount;
            IsActive = productHeaderDetail.IsActive;
            CreatedOn = productHeaderDetail.CreatedOn;
            CreatedBy = productHeaderDetail.CreatedBy;
            ModifiedOn = productHeaderDetail.ModifiedOn;
            ModifiedBy = productHeaderDetail.ModifiedBy;
            Edit = "Edit";
            Delete = "Delete";
            IsActiveText = productHeaderDetail.IsActive ? "Yes" : "No";
        }
    }
}
