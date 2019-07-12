using EmployeeSystem.Data.DataAccess;
using EmployeeSystem.Data.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeSystem.BusinessLayer;

namespace EmployeeSystem.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        //private readonly ApplicationDbContext employeeMSContext;
        private readonly EmployeeMSContext employeeMSContext;
        public EmployeeRepository   employeeRepository { get; private set; }
        public AuditRepository  auditRepository { get; private set; }
        public UserRepository  userRepository { get; private set; }
      
        public EmployeeService   employeeManager { get; private set; }
        public GenderRepository genderRepository { get; private set; }
        public RegionRepository regionRepository { get; private set; }
        public TitleRepo titleRepos { get; set; }
        public UnitOfWork(EmployeeMSContext _employeeMSContext)
        {
            this.employeeMSContext = _employeeMSContext;
            employeeRepository = new EmployeeRepository(employeeMSContext);
            auditRepository = new AuditRepository(employeeMSContext);
            genderRepository = new GenderRepository();
            regionRepository = new RegionRepository();
            titleRepos = new TitleRepo();
            userRepository = new UserRepository(employeeMSContext);

        }

        public int CommitAll()
        {
            return employeeMSContext.SaveChanges();
        }

        public void Dispose()
        {
            employeeMSContext.Dispose();
        }
    }
}
