using EmployeeSystem.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.Data.ViewModels
{
    public class UserViewModel
    {
        public List<AspNetUsers> Users { get; set; }
        public AspNetUsers User { get; set; }
    }
}
