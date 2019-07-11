using System;
using System.Collections.Generic;

namespace EmployeeSystem.Data.DataAccess
{
    public partial class Address
    {
        public string AddressId { get; set; }
        public string Address1 { get; set; }
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}
