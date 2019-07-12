using EmployeeSystem.Data.DataAccess.Interfaces;
using EmployeeSystem.Data.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;



namespace EmployeeSystem.Data.DataAccess.Repository
{
    public class EmployeeRepository : BaseRepository<Employee>    {
        public EmployeeRepository(EmployeeMSContext _context) : base(_context)
        {

        }

        
        private UserManager<IdentityUser> userManager;
       

          public void AddEmployee(Employee employee)
        {
            Add(employee);
           
        }
        

        //public KeyValuePair<bool, string> AddNewEmployee(Employee model, string userName)
        //{
        //    try
        //    {
                
        //        Add(model);
        //        model.IsActive = true;
        //        model.AuditInfo = new AuditInfo
        //        {
        //            CreatedBy = userName,
        //            CreatedOn = DateTime.Now,
        //            UpdatedBy = userName,
        //           UpdatedOn = DateTime.Now,
        //            Operation = "INS"
        //        };                
                
        //        if (model.SupervisorId == 0)
        //        {
        //            model.SupervisorId = null;
        //        }

        //        return new KeyValuePair<bool, string>(true, "Saved successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        return new KeyValuePair<bool, string>(false, ex.Message);
        //    }
        //}


        public IQueryable<Employee> GetSubordinates()
        {

            var subordinates = FindBy(x => x.SupervisorId != null);
            return subordinates;
        }


        public  void Delete(int id)
        {

            var employee = FindBy(m => m.EmployeeId == id).SingleOrDefault();
            employee.IsActive = false;
            
        }

       
        public IQueryable<Employee> GetEmployeeById(int Id)
        {

            return FindBy(m => m.EmployeeId == Id && m.IsActive==true).Include(g => g.Gender)
                                                    .Include(r => r.Region)
                                                    .Include(s => s.Supervisor)
                                                    .Include(t => t.Title)
                                                   
                                                    .Include(a=>a.AuditInfo).Where(a=>a.AuditInfoId == a.AuditInfo.AuditInfoId);
           
        }


        public void Update(Employee employee)
        {
            Edit(employee);
        }




        //public void UpdateEmployee(Employee employee)
        //{
        //   // CheckEmployeeExists(employee.EmployeeId);  
        //    employee.IsActive = true;
        //    //employee.AuditInfo.UpdatedBy = username;
        //    //employee.AuditInfo.UpdatedOn = DateTime.Now;
        //    //employee.AuditInfo.Operation = "UPD";

        //    Update(employee);
        //}

        //public override IQueryable<Employee> GetAll()
        //{
        //    return Context.Set<Employee>()
        //        .Include(a => a.Region)
        //        .Include(b => b.Gender)
        //        .Include(c => c.Supervisor)
        //        .Include(d=>d.AuditInfo)
        //        .Where(x=>x.IsActive==true);
        //}

        public override IQueryable<Employee> GetAll()
        {
            return Context.Set<Employee>()
                .Include(a => a.Region)
                .Include(b => b.Gender)
                .Include(c => c.Supervisor)
                .Include(d => d.AuditInfo)
                .Where(x => x.IsActive == true);
        }
        public  IQueryable<Employee> GetSupervisors()
        {
            return FindBy(x => x.SupervisorId == null && x.IsActive == true);
           // return Context.Set<Employee>().Where(x=>x.SupervisorId==null && x.IsActive==true);
                
        }
        public IQueryable<Employee> GetSurbodinates()
        {
            return FindBy(x => x.SupervisorId != null && x.IsActive == true)
                        .Include(g=>g.Gender)
                        .Include(m=>m.Title)
                        .Include(r=>r.Region);
            //return Context.Set<Employee>().Where(x => x.SupervisorId != null && x.IsActive == true);

        }
        public IQueryable<Employee> Audit(int id)
        {
            var employee = GetEmployeeById(id);
            
            return employee.Where(m => m.AuditInfoId == m.AuditInfo.AuditInfoId);
        }

      
    }


    }
