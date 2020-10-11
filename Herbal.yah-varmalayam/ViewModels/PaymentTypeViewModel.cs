using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbal.yah_varmalayam
{
    public class PaymentTypeViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public string PaymentTypeName { get; set; }

        public List<PaymentTypeViewModel> paymentTypeViewModel = new List<PaymentTypeViewModel>();
        public PaymentTypeViewModel()
        {

        }
        public PaymentTypeViewModel(string searchText)
        {
            var paymentlist = herbalContext.PaymentTypes.Where(_ => _.IsActive == true)
                                .OrderByDescending(_ => _.Id).ToList();
            foreach(var paymentType in paymentlist)
            {
                paymentTypeViewModel.Add(new PaymentTypeViewModel(paymentType.Id));
            }
        }

        public PaymentTypeViewModel(int id)
        {
            var paymentTypeDetail = herbalContext.PaymentTypes.Where(_ => _.Id == id).Single();
            Id = id;
            PaymentTypeName = paymentTypeDetail.PaymentTypeName;
            IsActive = paymentTypeDetail.IsActive;
            CreatedOn = paymentTypeDetail.CreatedOn;
            CreatedBy = paymentTypeDetail.CreatedBy;
            ModifiedOn = paymentTypeDetail.ModifiedOn;
            ModifiedBy = paymentTypeDetail.ModifiedBy;
            Edit = "Edit";
            Delete = "Delete";
            IsActiveText = paymentTypeDetail.IsActive ? "Yes" : "No";
        }
    }
}
