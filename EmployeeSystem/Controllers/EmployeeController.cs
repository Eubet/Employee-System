using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EmployeeSystem.BusinessLayer;
using EmployeeSystem.Data.UnitOfWork;
using EmployeeSystem.Data.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeSystem.Controllers
{

    public class EmployeeController : Controller
    {
        
        private readonly UnitOfWork unitofWork;
        readonly EmployeeService employeeService;
        private readonly UserManager<IdentityUser> userManager;

      

        public EmployeeController(IUnitOfWork _unitofWork, EmployeeService _employeeService, UserManager<IdentityUser> _userManager)
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
            var result = unitofWork.employeeRepository.AddNewEmployee(model.Employee, userName);
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
                TitleList = unitofWork.titleRepos.Populate().ToList()

            };
            
            return View(model);
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult Edit(EmployeeViewModel employeeViewModel)
        {
            string userName = userManager.GetUserName(HttpContext.User);

            
            unitofWork.employeeRepository.UpdateEmployee(employeeViewModel.Employee);
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
            var model = new EmployeeViewModel
            {

                Employee = unitofWork.employeeRepository.GetEmployeeById(id).FirstOrDefault(),
                //AuditLog = unitofWork.employeeRepository.Audit(id).FirstOrDefault(),
                Audit = unitofWork.employeeRepository.Audit(id).FirstOrDefault(),
                Surbodinates = unitofWork.employeeRepository.GetSubordinates().ToList(),
                Supervisors = unitofWork.employeeRepository.GetSupervisors().ToList(),
                //Employees = unitofWork.employeeRepository.GetAll().ToList()
                
            };
           
            return View(model);
        }


        public IActionResult Index()
        {

            EmployeeViewModel model = new EmployeeViewModel()
            {
                Employees = unitofWork.employeeRepository.GetAll().ToList(),

                GenderList = unitofWork.genderRepository.Populate().ToList(),
                RegionList = unitofWork.regionRepository.Populate().ToList(),
                TitleList = unitofWork.titleRepos.Populate().ToList()
            };
            
            return View(model);
        }
    }
}