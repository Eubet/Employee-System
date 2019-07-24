using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EmployeeSystem.BusinessLayer;
using EmployeeSystem.Data.DataAccess;
using EmployeeSystem.Data.UnitOfWork;
using EmployeeSystem.Data.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeSystem.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        
        private readonly UnitOfWork unitofWork;
        readonly EmployeeService employeeService;
        private readonly UserManager<ApplicationUser> userManager;

      

        public EmployeeController(IUnitOfWork _unitofWork, EmployeeService _employeeService, UserManager<ApplicationUser> _userManager)
        {
            unitofWork = _unitofWork as UnitOfWork;
            userManager = _userManager;
            employeeService = _employeeService;
        }

        [HttpPost]
        public   IActionResult AddEmployee(EmployeeViewModel model)
        {
            
             string userName = userManager.GetUserName(HttpContext.User);
          
            if (!ModelState.IsValid)
            {
                return View();
                
            }
            var result = employeeService.AddNewEmployee(model.Employee, userName);
            var saveResult = unitofWork.CommitAll();
            return  Json(result);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {


            var model = new EmployeeViewModel
            {
                Employees = unitofWork.employeeRepository.GetAll().ToList(),
                Employee = unitofWork.employeeRepository.GetEmployeeById(id).FirstOrDefault(),
                GenderList = unitofWork.genderRepository.Populate().ToList(),
                RegionList = unitofWork.regionRepository.Populate().ToList(),
                TitleList = unitofWork.titleRepos.Populate().ToList(),
                

            };
            
            return View(model);
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult Edit(EmployeeViewModel employeeViewModel)
        {
            string userName = userManager.GetUserName(HttpContext.User);

            
            employeeService.UpdateEmployee(employeeViewModel.Employee, userName);
                var saveResult = unitofWork.CommitAll();

                return  RedirectToAction(nameof(Index));
            
        }

        [HttpPost]
        public IActionResult Delete(int EmployeeId)
        {
            var result = employeeService.Delete(EmployeeId);
            return Json(result);
        }


        public IActionResult Details(int id)
        {

            var model = employeeService.GetEmployeeDetails(id);
            model.Employee = employeeService.GetEmployeeById(id);
           // model.Employee  = unitofWork.employeeRepository.GetEmployeeById(id).FirstOrDefault();
            model.Supervisors = unitofWork.employeeRepository.GetSupervisors().ToList();
            model.Surbodinates = unitofWork.employeeRepository.GetSubordinates().ToList();
           

            return View(model);
        }


        public IActionResult Index()
        {

            EmployeeViewModel model = new EmployeeViewModel()
            {
                Employees = employeeService.GetAllEmployees(),
               // Employees = unitofWork.employeeRepository.GetAll().ToList(),

                GenderList = employeeService.PopulateGender(),
                RegionList = employeeService.PopulateRegion(),
                TitleList = employeeService.PopulateTitle()
            };
            
            return View(model);
        }
    }
}