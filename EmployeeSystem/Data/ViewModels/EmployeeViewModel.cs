using EmployeeSystem.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeSystem.Data.ViewModels
{
    public class EmployeeViewModel
    {
        public List<Employee> Employees { get; set; }

        public List<Employee> Surbodinates { get; set; }
        public List<Employee> Supervisors { get; set; }
        
        
        public Employee Employee { get; set; }
        //public IQueryable<AuditInfo> AuditLog { get; set; }
        public AuditInfo AuditLog { get; set; }
        public Employee Audit { get; set; }

        public SelectList EmployeeSelectList { get; set; }
       
        public SelectList Regions { get; set; }
        public SelectList Genders { get; set; }
        public SelectList Titles { get; set; }

        public List<Gender> GenderList { get; set; }
         public List<Region> RegionList { get; set; }
        public List<Title> TitleList { get; set; }




    }
}
