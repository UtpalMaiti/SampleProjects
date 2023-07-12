using System.Collections.Generic;
using App.ALL.Roles.Dto;

namespace App.ALL.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
