using BLL.User;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimesheetApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserBLL _userBLL;
        public UserController(IUserBLL userBLL)
        {
            _userBLL = userBLL;
        }

        public IActionResult GetAllUser()
        {
            var users = _userBLL.GetAllUser();
            return Json(users.DataList);
        }
    }
}
