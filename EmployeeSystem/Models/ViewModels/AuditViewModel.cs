using EmployeeSystem.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.Data.ViewModels
{
    public class AuditViewModel
    {
        public AuditInfo    auditInfo { get; set; }
        public Employee    Employee { get; set; }
        public List<AuditInfo> AuditList { get; set; }
    }
}
