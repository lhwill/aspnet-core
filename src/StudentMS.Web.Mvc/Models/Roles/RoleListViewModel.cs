using System.Collections.Generic;
using StudentMS.Roles.Dto;

namespace StudentMS.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
