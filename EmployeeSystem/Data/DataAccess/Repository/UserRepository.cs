using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.Data.DataAccess.Repository
{
    public class UserRepository : BaseRepository<AspNetUsers>
    {
        public UserRepository(EmployeeMSContext _context) : base(_context)
        {

        }

        public  IQueryable<AspNetUsers> GetAllUser()
        {
            return GetAll();
        }

        public void Delete(string id)
        {

            var user = FindBy(m => m.Id == id).SingleOrDefault();
            user.IsActive = false;

        }

        public IQueryable<AspNetUsers> GetUserById(string Id)
        {
            return FindBy(m => m.Id == Id && m.IsActive == true);
        }

    }
}
