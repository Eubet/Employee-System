using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeSystem.Data.DataAccess
{
    public partial class Employee
    {
        public Employee()
        {
            InverseSupervisor = new HashSet<Employee>();
        }

        public int EmployeeId { get; set; }
        public int? SupervisorId { get; set; }
        public string EmpNum { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
       
        public DateTime? Dob { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EmployedOn { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public bool IsActive { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int? GenderId { get; set; }
        public int RegionId { get; set; }
        public int TitleId { get; set; }
        public int? AuditInfoId { get; set; }

        public AuditInfo AuditInfo { get; set; }
        public Gender Gender { get; set; }
        public Region Region { get; set; }
        public Employee Supervisor { get; set; }
        public Title Title { get; set; }
        public ICollection<Employee> InverseSupervisor { get; set; }
    }
}
