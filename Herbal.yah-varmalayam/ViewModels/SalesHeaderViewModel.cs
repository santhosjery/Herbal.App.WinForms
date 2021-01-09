using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbal.yah_varmalayam
{
    public class SalesHeaderViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public string SalesCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerMobileNumbers { get; set; }
        public string CustomerGSTIN { get; set; }
        public string CustomerAddress { get; set; }
        public int? PaymentTypeId { get; set; }
        public DateTime SalesDate { get; set; }
        public decimal TotalSalesAmount { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalGrossAmount { get; set; }
        public decimal? TotalTaxAmount { get; set; }
        public decimal TotalNetAmount { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal DueAmount { get; set; }

        public List<SalesHeaderViewModel> salesHeaderViewList = new List<SalesHeaderViewModel>();

        public SalesHeaderViewModel()
        {
            var salesHeaderList = herbalContext.SalesHeaders.Where(_ => _.IsActive == true)
                                        .OrderByDescending(_ => _.Id).Take(10).ToList();
            foreach (var salesHeader in salesHeaderList)
            {
                salesHeaderViewList.Add(new SalesHeaderViewModel(salesHeader.Id));
            }
        }

        public SalesHeaderViewModel(int id)
        {
            var salesHeaderDetail = herbalContext.SalesHeaders.Where(_ => _.Id == id).Single();
            Id = salesHeaderDetail.Id;
            SalesCode = salesHeaderDetail.SalesCode;
            CustomerName = salesHeaderDetail.CustomerName;
            CustomerMobileNumbers = salesHeaderDetail.CustomerMobileNumbers;
            CustomerGSTIN = salesHeaderDetail.CustomerGSTIN;
            CustomerAddress = salesHeaderDetail.CustomerAddress;
            PaymentTypeId = salesHeaderDetail.PaymentTypeId;
            SalesDate = salesHeaderDetail.SalesDate;
            TotalSalesAmount = salesHeaderDetail.TotalSalesAmount;
            TotalDiscount = salesHeaderDetail.TotalDiscount;
            TotalGrossAmount = salesHeaderDetail.TotalGrossAmount;
            TotalTaxAmount = salesHeaderDetail.TotalTaxAmount;
            TotalNetAmount = salesHeaderDetail.TotalNetAmount;
            AmountPaid = salesHeaderDetail.AmountPaid;
            DueAmount = salesHeaderDetail.DueAmount;
            IsActive = salesHeaderDetail.IsActive;
            CreatedOn = salesHeaderDetail.CreatedOn;
            CreatedBy = salesHeaderDetail.CreatedBy;
            ModifiedOn = salesHeaderDetail.ModifiedOn;
            ModifiedBy = salesHeaderDetail.ModifiedBy;
            Edit = "Edit";
            Delete = "Delete";
            IsActiveText = salesHeaderDetail.IsActive ? "Yes" : "No";
        }
    }
}
