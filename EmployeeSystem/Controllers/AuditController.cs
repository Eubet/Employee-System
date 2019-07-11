using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeSystem.BusinessLayer;
using EmployeeSystem.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.Controllers
{
    public class AuditController : Controller
    {
        readonly EmployeeService employeeService;

        public AuditController(EmployeeService _employeeService)
        {
            this.employeeService = _employeeService;
        }

        public IActionResult Index()
        {
            AuditViewModel audit = new AuditViewModel();
            audit.AuditList = employeeService.unitofWork.auditRepository.GetAll().ToList();
            return View(audit);
        }
    }
}