using EmployeeSystem.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EmployeeSystem.Data.ViewModels
{
    public class EmployeeDetailsVM
    {
        public Employee Employee { get; set; }
       
        public AuditInfo AuditLog { get; set; }

        public List<Employee> Subordinates { get; set; }

        public List<Employee> Employees { get; set; }
        public Employee EmployeeAddModel { get; set; }

        
    }
}
