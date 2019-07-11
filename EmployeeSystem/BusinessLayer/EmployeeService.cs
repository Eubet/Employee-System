using EmployeeSystem.Data.DataAccess;
using EmployeeSystem.Data.DataAccess.Repository;
using EmployeeSystem.Data.UnitOfWork;
using EmployeeSystem.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.BusinessLayer
{
    public class EmployeeService
    {
        public readonly UnitOfWork unitofWork;

        public EmployeeService(IUnitOfWork _unitofWork)
        {
            unitofWork = _unitofWork as UnitOfWork;           
        }          

        public KeyValuePair<bool, string> Delete(int employeeId)
        {
            unitofWork.employeeRepository.Delete(employeeId);
            if (unitofWork.CommitAll() == 1)
                return new KeyValuePair<bool, string>(true, "Commit saved successfully");
            else
                return new KeyValuePair<bool, string>(false, "Commit didn't execute");            
        }

    }
}
