using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.Data.DataAccess.Interfaces
{
    public interface IEmployeeRepository:IRepository<Employee>  { 
        List<Employee> GetAllEmployee();
    }
}
