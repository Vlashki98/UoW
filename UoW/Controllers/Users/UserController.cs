﻿using Microsoft.AspNetCore.Mvc;
using UoW.BL.Interfaces.Users;
using UoW.Models.Users;

namespace UoW.Controllers.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public User GetUser(int userId)
        {
            return _userService.GetUserByid(userId);
        }
    }
}

