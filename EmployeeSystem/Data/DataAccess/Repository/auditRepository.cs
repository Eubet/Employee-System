using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.Data.DataAccess.Repository
{
    public class AuditRepository:BaseRepository<AuditInfo>
    {
        public AuditRepository(EmployeeMSContext _context):base(_context)
        {

        }

        public IQueryable<AuditInfo> GetAuditById(int id)
        {
            return Context.AuditInfo.Include(i => i.Employee).Where(a => a.AuditInfoId == id);
            
        }

    }
}
