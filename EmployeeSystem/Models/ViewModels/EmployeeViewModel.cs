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

        //new ViewModel
        public int EmployeeId { get; set; }
        public int? SupervisorId { get; set; }
        public string EmpNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? EmployedOn { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int? GenderId { get; set; }
        public int RegionId { get; set; }
        public int TitleId { get; set; }
        public int? AuditInfoId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string Operation { get; set; }


        public AuditInfo AuditInfo { get; set; }
        public Gender Gender { get; set; }
        public Region Region { get; set; }
        public Employee Supervisor { get; set; }






    }
}
