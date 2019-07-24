using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeSystem.BusinessLayer;
using EmployeeSystem.Data.DataAccess;
using EmployeeSystem.Data.UnitOfWork;
using EmployeeSystem.Data.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly UnitOfWork unitofWork;
        readonly UserService userService;
        private readonly UserManager<ApplicationUser> userManager;

      
        public UserController(IUnitOfWork _unitOfWork, UserService _userService, UserManager<ApplicationUser> _userManager)
        {
            this.userService = _userService;
            userManager = _userManager;
            unitofWork = _unitOfWork as UnitOfWork;
        }

        public IActionResult Delete(string Id)
        {
            var result = userService.Delete(Id);
            return Json(result);
        }
        public IActionResult Index()
        {
            UserViewModel user = new UserViewModel
            {
                //Users = userService.GetAllUsers().ToList()
                Users = unitofWork.userRepository.GetAllUser().ToList()
                
            };

            return View(user);
        }

        public IActionResult Details(string Id)
        {
            var model = userService.GetUserDetails(Id);
            return View(model);
        }
    }
}