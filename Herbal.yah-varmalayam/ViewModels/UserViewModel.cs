using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbal.yah_varmalayam
{
    public class UserViewModel : BaseViewModel
    {
        public int UserId { get; set; }
        public int AccessRoleId { get; set; }
        public string UserName { get; set; }
        public long MobileNumber { get; set; }
        public string AccessRoleName { get; set; }

        public UserViewModel()
        {

        }

        public UserViewModel(int userId)
        {
            var userDetail = herbalContext.AppUsers.Where(_ => _.Id == userId).Single();
            UserId = userDetail.Id;
            UserName = userDetail.UserName;
            MobileNumber = userDetail.MobileNumber;
            AccessRoleName = userDetail.AccessRole.RoleName;
            AccessRoleId = userDetail.AccessRole.Id;
            IsActive = userDetail.IsActive;
            CreatedOn = userDetail.CreatedOn;
        }
    }
}
