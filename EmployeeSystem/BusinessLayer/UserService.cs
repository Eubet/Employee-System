using EmployeeSystem.Data.DataAccess;
using EmployeeSystem.Data.UnitOfWork;
using EmployeeSystem.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.BusinessLayer
{
    public class UserService
    {
        public readonly UnitOfWork unitofWork;
        public readonly EmployeeMSContext context;

        public UserService(IUnitOfWork _unitofWork, EmployeeMSContext _context)
        {
            this.unitofWork = _unitofWork as UnitOfWork;
            this.context = _context;
        }

        public List<AspNetUsers> GetAllUsers()
        {
            return unitofWork.userRepository.GetAllUser().ToList();
        }

        public KeyValuePair<bool, string> Delete(string Id)
        {
            unitofWork.userRepository.Delete(Id);
            if (unitofWork.CommitAll() == 1)
                return new KeyValuePair<bool, string>(true, "Commit saved successfully");
            else
                return new KeyValuePair<bool, string>(false, "Commit didn't execute");
        }

        public UserViewModel GetUserDetails(string id)
        {
            var user = unitofWork.userRepository.GetUserById(id).FirstOrDefault();

            var userModel = new UserViewModel();
            userModel.User = user;

            return userModel;
        }
    }
}
