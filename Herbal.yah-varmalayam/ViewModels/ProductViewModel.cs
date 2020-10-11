using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbal.yah_varmalayam
{
    public class ProductViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int ScaleId { get; set; }
        public string ScaleName { get; set; }
        public decimal SellingPrice { get; set; }
        public string PriceAndScale { get; set; }

        public List<ProductViewModel> productViewList = new List<ProductViewModel>();

        public ProductViewModel()
        {

        }
        public ProductViewModel(string searchText)
        {
            var productList = herbalContext.Products.Where(_ => (searchText == "")
                            || (searchText.ToLower().Contains(_.ProductCode.ToLower()) 
                                    || searchText.ToLower().Contains(_.ProductName.ToLower())))
                            .ToList().OrderByDescending(_ => _.Id).ToList();
            foreach (var product in productList)
            {
                productViewList.Add(new ProductViewModel(product.Id));
            }
        }

        public ProductViewModel(int productId)
        {
            var product = herbalContext.Products.Where(_ => _.Id == productId).Single();
            Id = product.Id;
            ProductCode = product.ProductCode;
            ProductName = product.ProductName;
            IsActive = product.IsActive;
            ScaleId = product.ScaleId;
            ScaleName = product.Scale.ScaleName;
            SellingPrice = product.SellingPrice ?? 0;
            PriceAndScale = string.Concat(product.SellingPrice, " per 1", product.Scale.ScaleName);
            CreatedOn = product.CreatedOn;
            CreatedBy = product.CreatedBy;
            ModifiedOn = product.ModifiedOn;
            ModifiedBy = product.ModifiedBy;
            Edit = "Edit";
            Delete = "Delete";
            IsActiveText = product.IsActive ? "Yes" : "No";
        }
    }
}
