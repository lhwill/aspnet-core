using Abp.Authorization;
using StudentMS.Authorization.Roles;
using StudentMS.Authorization.Users;

namespace StudentMS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
