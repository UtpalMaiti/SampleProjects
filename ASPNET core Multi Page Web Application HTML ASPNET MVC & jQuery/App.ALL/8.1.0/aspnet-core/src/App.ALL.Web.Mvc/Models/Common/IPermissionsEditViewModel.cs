using System.Collections.Generic;
using App.ALL.Roles.Dto;

namespace App.ALL.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}