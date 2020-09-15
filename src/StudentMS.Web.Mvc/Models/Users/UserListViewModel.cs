using System.Collections.Generic;
using StudentMS.Roles.Dto;

namespace StudentMS.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
