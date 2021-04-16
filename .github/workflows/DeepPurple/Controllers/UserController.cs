using DeepPurple.ApplicationLogic.Services;
using DeepPurple.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepPurple.Controllers
{
    public class UserController : Controller
    {
        private readonly UserServices _userServices; 

        public UserController(UserServices userServices)
        {
            this._userServices = userServices;
        }
        public IActionResult Users()
        {
            try
            {
                var users = _userServices.GetAll();
                return View(new GetAllUsersViewModel
                {
                    Users = users
                });
            }
            catch (Exception)
            {
                return BadRequest("Invalid Request");
            }
            
        }

        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser([FromForm]AddUserViewModel model)
        {
            _userServices.AddUser(model.Username,model.Password, model.Email, model.Member);

            return View("AddUsers", "User");
        }

    }
}
