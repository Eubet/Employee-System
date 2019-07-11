using System;
using System.Collections.Generic;

namespace EmployeeSystem.Data.DataAccess
{
    public partial class Region
    {
        public Region()
        {
            Employee = new HashSet<Employee>();
        }

        public int RegionId { get; set; }
        public string RegionName { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
