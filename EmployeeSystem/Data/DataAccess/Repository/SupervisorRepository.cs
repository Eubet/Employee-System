using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.Data.DataAccess.Repository
{
    public class SupervisorRepository : BaseRepository<Employee>
    {
        public SupervisorRepository(EmployeeMSContext _context) : base(_context)
        {

        }

    }
}
