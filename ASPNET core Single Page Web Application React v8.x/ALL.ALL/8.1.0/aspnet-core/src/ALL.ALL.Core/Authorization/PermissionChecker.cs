using Abp.Authorization;
using ALL.ALL.Authorization.Roles;
using ALL.ALL.Authorization.Users;

namespace ALL.ALL.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
