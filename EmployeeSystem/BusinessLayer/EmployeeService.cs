using EmployeeSystem.Data.DataAccess;
using EmployeeSystem.Data.DataAccess.Repository;
using EmployeeSystem.Data.UnitOfWork;
using EmployeeSystem.Data.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.BusinessLayer
{
    public class EmployeeService
    {
        public readonly UnitOfWork unitofWork;
        public readonly EmployeeMSContext context;

        public EmployeeService(IUnitOfWork _unitofWork, EmployeeMSContext _context)
        {
            unitofWork = _unitofWork as UnitOfWork;
            context = _context;
        }

        public List<Employee> GetSubordinates()
        {

            var subordinates = GetSubordinates().ToList();
            return subordinates;
        }
        public KeyValuePair<bool, string> Delete(int employeeId)
        {
            unitofWork.employeeRepository.Delete(employeeId);
            if (unitofWork.CommitAll() == 1)
                return new KeyValuePair<bool, string>(true, "Commit saved successfully");
            else
                return new KeyValuePair<bool, string>(false, "Commit didn't execute");            
        }

       public List<Employee> GetAllEmployees()
        {
            return unitofWork.employeeRepository.GetAll().ToList();
        }

        public void UpdateEmployee(Employee employee, string username)
        {
            employee.IsActive = true;
           
            //employee.AuditInfo.UpdatedBy = username;
            ////employee.AuditInfo.UpdatedBy = username;
            //employee.AuditInfo.UpdatedOn = DateTime.Now;
            //employee.AuditInfo.Operation = "UPD";

            unitofWork.employeeRepository.Update(employee);
        }


        
        public EmployeeViewModel GetEmployeeDetails(int id)
        {
            var employee = unitofWork.employeeRepository.GetEmployeeById(id).FirstOrDefault();

            EmployeeViewModel viewModel = new EmployeeViewModel
            {
                EmployeeId = employee.EmployeeId,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Dob = employee.Dob,
                EmployedOn= employee.EmployedOn,
                Email= employee.Email,
                AuditInfoId=employee.AuditInfoId,
                GenderId=employee.GenderId,
                RegionId=employee.RegionId,
                TitleId=employee.TitleId,
                Genders = new SelectList(unitofWork.genderRepository.Populate(),"Id", "Gender"),
                Regions = new SelectList(unitofWork.regionRepository.Populate(), "Id", "Region"),
                Titles = new SelectList(unitofWork.titleRepos.Populate(), "Id", "Title"),
                CreatedBy = employee.AuditInfo.CreatedBy,
                CreatedOn = employee.AuditInfo.CreatedOn,
                UpdatedBy = employee.AuditInfo.UpdatedBy,
                UpdatedOn = employee.AuditInfo.UpdatedOn
            };

            return viewModel;
        }

        public Employee GetEmployeeById(int id)
        {
            return unitofWork.employeeRepository.GetEmployeeById(id).FirstOrDefault();
        }

        public KeyValuePair<bool, string> AddNewEmployee(Employee model, string userName)
        {
            try
            {

               
                model.IsActive = true;
                model.AuditInfo = new AuditInfo
                {
                    CreatedBy = userName,
                    CreatedOn = DateTime.Now,
                    UpdatedBy = userName,
                    UpdatedOn = DateTime.Now,
                    Operation = "INS"
                };

                if (model.SupervisorId == 0)
                {
                    model.SupervisorId = null;
                }
                unitofWork.employeeRepository.AddEmployee(model);
                return new KeyValuePair<bool, string>(true, "Saved successfully");
            }
            catch (Exception ex)
            {
                return new KeyValuePair<bool, string>(false, ex.Message);
            }
        }

        public List<Gender> PopulateGender()
        {
            return unitofWork.genderRepository.Populate().ToList();
        }
        public List<Title> PopulateTitle()
        {
            return unitofWork.titleRepos.Populate().ToList();
        } public List<Region> PopulateRegion()
        {
            return unitofWork.regionRepository.Populate().ToList();
        }
    }
}
