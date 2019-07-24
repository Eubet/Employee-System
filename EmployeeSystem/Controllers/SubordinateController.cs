using System.Linq;
using EmployeeSystem.BusinessLayer;
using EmployeeSystem.Data.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.Controllers
{
    [Authorize]
    public class SubordinateController : Controller
    {
        readonly EmployeeService employeeService;

        public SubordinateController(EmployeeService _employeeService)
        {
            this.employeeService = _employeeService;
        }

        public IActionResult Index()
        {
            
            EmployeeViewModel model = new EmployeeViewModel
            {
                Surbodinates = employeeService.unitofWork.employeeRepository.GetSurbodinates().ToList(),
               // Supervisors = employeeService.unitofWork.employeeRepository.GetSupervisors().ToList(),
                Employees = employeeService.unitofWork.employeeRepository.GetAll().ToList(),
                GenderList = employeeService.unitofWork.genderRepository.Populate().ToList(),
                RegionList = employeeService.unitofWork.regionRepository.Populate().ToList(),
                TitleList = employeeService.unitofWork.titleRepos.Populate().ToList()
            };
            return View(model);
         
        }
    }
}