﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Dependency;
using Abp.Events.Bus.Exceptions;
using Abp.Events.Bus.Handlers;
using Abp.UI;
using Abp.Web.Mvc.Authorization;
using App.ALL.Authorization;
using App.ALL.Authorization.Roles;
using App.ALL.Users;
using App.ALL.Web.Models.Users;

namespace App.ALL.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class UsersController : ALLControllerBase
    {
        private readonly IUserAppService _userAppService;
        private readonly RoleManager _roleManager;

        public UsersController(IUserAppService userAppService, RoleManager roleManager)
        {
            _userAppService = userAppService;
            _roleManager = roleManager;
        }

        public async Task<ActionResult> Index()
        {
            var users = (await _userAppService.GetAllAsync(new PagedResultRequestDto { MaxResultCount = int.MaxValue })).Items; //Paging not implemented yet
            var roles = (await _userAppService.GetRoles()).Items;
            var model = new UserListViewModel
            {
                Users = users,
                Roles = roles
            };

            return View(model);
        }

        public async Task<ActionResult> EditUserModal(long userId)
        {
            var user = await _userAppService.GetAsync(new EntityDto<long>(userId));
            var roles = (await _userAppService.GetRoles()).Items;
            var model = new EditUserModalViewModel
            {
                User = user,
                Roles = roles
            };
            return View("_EditUserModal", model);
        }
    }
}