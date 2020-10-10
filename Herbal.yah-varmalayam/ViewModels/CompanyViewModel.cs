using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbal.yah_varmalayam
{
    public class CompanyViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public string AuthorisedDealer { get; set; }
        public long PrimaryContactNumber { get; set; }
        public long? SecondaryContactNumber { get; set; }
        public string PrimaryEmailAddress { get; set; }
        public string WebSite { get; set; }
        public string CompanyAddress { get; set; }
        public string GSTINNumber { get; set; }
        public string Note { get; set; }
        public string RevisedNote { get; set; }
        public string GSTINCertifiedBy { get; set; }

        public List<CompanyViewModel> companyViewList = new List<CompanyViewModel>();

        public CompanyViewModel()
        {
            var companyList = herbalContext.CompanyDetails.OrderByDescending(_ => _.Id).ToList();
            foreach (var company in companyList)
            {
                companyViewList.Add(new CompanyViewModel(company.Id));
            }
        }

        public CompanyViewModel(int id)
        {
            var companyList = herbalContext.CompanyDetails.Where(_ => _.Id == id).Single();
            Id = id;
            CompanyName = companyList.CompanyName;
            Description = companyList.Description;
            AuthorisedDealer = companyList.AuthorisedDealer;
            PrimaryContactNumber = companyList.PrimaryContactNumber;
            SecondaryContactNumber = companyList.SecondaryContactNumber;
            PrimaryEmailAddress = companyList.PrimaryEmailAddress;
            WebSite = companyList.WebSite;
            CompanyAddress = companyList.CompanyAddress;
            GSTINNumber = companyList.GSTINNumber;
            GSTINCertifiedBy = companyList.GSTINCertifiedBy;
            Note = companyList.Note;
            RevisedNote = companyList.RevisedNote;
            IsActive = companyList.IsActive;
            CreatedOn = companyList.CreatedOn;
            CreatedBy = companyList.CreatedBy;
            ModifiedOn = companyList.ModifiedOn;
            ModifiedBy = companyList.ModifiedBy;
            Edit = "Edit";
            Delete = "Delete";
            IsActiveText = companyList.IsActive ? "Yes" : "No";
        }
    }
}
