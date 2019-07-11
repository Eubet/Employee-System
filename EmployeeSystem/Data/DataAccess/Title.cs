using System;
using System.Collections.Generic;

namespace EmployeeSystem.Data.DataAccess
{
    public partial class Title
    {
        public Title()
        {
            Employee = new HashSet<Employee>();
        }

        public int TitleId { get; set; }
        public string TitleName { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
