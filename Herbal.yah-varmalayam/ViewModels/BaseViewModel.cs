using Herbal.yah_varmalayam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbal.yah_varmalayam
{
    public class BaseViewModel
    {

        protected HerbalEntities herbalContext = new HerbalEntities(Utility.GetEntityConnectionString());

        public bool IsActive { get; set; }
        public string IsActiveText { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string Edit { get; set; }
        public string Delete { get; set; }
    }
}
