using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.Data.DataAccess
{
    public class ApplicationUser:IdentityUser
    {
        public ApplicationUser()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
    }
}
