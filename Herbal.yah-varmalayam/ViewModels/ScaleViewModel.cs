using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbal.yah_varmalayam
{
    public class ScaleViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public string ScaleName { get; set; }

        public List<ScaleViewModel> scaleViewModel = new List<ScaleViewModel>();
        public ScaleViewModel()
        {

        }
        public ScaleViewModel(string searchText)
        {
            /*var scaleList = herbalContext.Scales.Where(_ => (searchText == "")
                            || searchText.ToLower().Contains(_.ScaleName.ToLower()))
                            .ToList().OrderByDescending(_ => _.Id).ToList();
            foreach (var scale in scaleList)
            {
                scaleViewModel.Add(new ScaleViewModel(scale.Id));
            }*/
        }

        public ScaleViewModel(int productId)
        {
            /*var product = herbalContext.Scales.Where(_ => _.Id == productId).Single();
            Id = product.Id;
            ScaleName = product.ScaleName;
            IsActive = product.IsActive;
            CreatedOn = product.CreatedOn;
            CreatedBy = product.CreatedBy;
            ModifiedOn = product.ModifiedOn;
            ModifiedBy = product.ModifiedBy;
            Edit = "Edit";
            Delete = "Delete";
            IsActiveText = product.IsActive ? "Yes" : "No";*/
        }

    }
}
