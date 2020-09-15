using System.Collections.Generic;
using StudentMS.Roles.Dto;

namespace StudentMS.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}