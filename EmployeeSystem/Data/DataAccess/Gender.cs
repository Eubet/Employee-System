using System;
using System.Collections.Generic;

namespace EmployeeSystem.Data.DataAccess
{
    public partial class Gender
    {
        public Gender()
        {
            Employee = new HashSet<Employee>();
        }

        public int GenderId { get; set; }
        public string GenderName { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
