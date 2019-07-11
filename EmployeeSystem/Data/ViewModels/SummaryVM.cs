using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.Data.ViewModels
{
    public class SummaryVM
    {
        public int TotalEmployees { get; set; }
        public int TotalSupervisor { get; set; }
        public int TotalSurbodinates { get; set; }
    }
}
