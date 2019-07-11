using System;
using System.Collections.Generic;

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

        public AuditInfo AuditInfo { get; set; }
        public Gender Gender { get; set; }
        public Region Region { get; set; }
        public Employee Supervisor { get; set; }
        public Title Title { get; set; }
        public ICollection<Employee> InverseSupervisor { get; set; }
    }
}
