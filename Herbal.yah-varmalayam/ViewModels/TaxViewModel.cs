using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbal.yah_varmalayam
{
    public class TaxViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public decimal CGSTPercentage { get; set; }
        public decimal SGSTPercentage { get; set; }
        public decimal IGSTPercentage { get; set; }

        public List<TaxViewModel> taxViewList = new List<TaxViewModel>();
        public TaxViewModel()
        {
            var taxList = herbalContext.Taxes.OrderByDescending(_ => _.Id).ToList();
            foreach (var tax in taxList)
            {
                taxViewList.Add(new TaxViewModel(tax.Id));
            }
        }

        public TaxViewModel(int id)
        {
            var taxList = herbalContext.Taxes.Where(_ => _.Id == id).Single();
            Id = taxList.Id;
            CGSTPercentage = taxList.CGSTPercentage ?? 0;
            SGSTPercentage = taxList.SGSTPercentage ?? 0;
            IGSTPercentage = taxList.IGSTPercentage ?? 0;
            IsActive = taxList.IsActive;
            CreatedOn = taxList.CreatedOn;
            CreatedBy = taxList.CreatedBy;
            ModifiedOn = taxList.ModifiedOn;
            ModifiedBy = taxList.ModifiedBy;
            Edit = "Edit";
            Delete = "Delete";
            IsActiveText = taxList.IsActive ? "Yes" : "No";
        }
    }
}
