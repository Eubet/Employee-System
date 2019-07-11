using System;
using System.Collections.Generic;

namespace EmployeeSystem.Data.DataAccess
{
    public partial class PhoneNumber
    {
        public int PhoneNumberId { get; set; }
        public string PhoneNumber1 { get; set; }
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}
