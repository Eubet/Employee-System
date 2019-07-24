using System.Linq;
using EmployeeSystem.BusinessLayer;
using EmployeeSystem.Data.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.Controllers
{
    [Authorize]
    public class SupervisorController : Controller
    {
        readonly EmployeeService employeeService;

        public SupervisorController(EmployeeService _employeeService)
        {
            this.employeeService = _employeeService;
        }

        public IActionResult Index()
        {
            var model = new EmployeeViewModel
            {
                Supervisors = employeeService.unitofWork.employeeRepository.GetSupervisors().ToList(),

                Employees = employeeService.GetAllEmployees().ToList(),
                GenderList = employeeService.unitofWork.genderRepository.Populate().ToList(),
                RegionList = employeeService.unitofWork.regionRepository.Populate().ToList(),
                TitleList = employeeService.unitofWork.titleRepos.Populate().ToList()
            };
            return View(model);
        }
    }
}