using System.Collections.Generic;
using App.ALL.Roles.Dto;

namespace App.ALL.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
