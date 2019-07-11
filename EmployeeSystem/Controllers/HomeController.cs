using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EmployeeSystem.Data.DataAccess;
using EmployeeSystem.Data.UnitOfWork;
using EmployeeSystem.Data.ViewModels;
using EmployeeSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly UnitOfWork unitofWork;


        public HomeController(IUnitOfWork _unitofWork)
        {
          unitofWork = _unitofWork as UnitOfWork;

        }

        public IActionResult Index()
        {

            var model = new SummaryVM();
            model.TotalEmployees = unitofWork.employeeRepository.GetAll().Count();
            model.TotalSupervisor = unitofWork.employeeRepository.GetSupervisors().Count();
            model.TotalSurbodinates = unitofWork.employeeRepository.GetSurbodinates().Count();
            

            ViewBag.Employees = model.TotalEmployees;
            ViewBag.Surbodinates = model.TotalSurbodinates;
            ViewBag.Supervisor = model.TotalSupervisor;

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
