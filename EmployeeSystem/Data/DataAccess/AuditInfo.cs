using System;
using System.Collections.Generic;

namespace EmployeeSystem.Data.DataAccess
{
    public partial class AuditInfo
    {
        public AuditInfo()
        {
            Employee = new HashSet<Employee>();
        }

        public int AuditInfoId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string Operation { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
