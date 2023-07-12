using Abp.Authorization;
using App.ALL.Authorization.Roles;
using App.ALL.Authorization.Users;

namespace App.ALL.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
