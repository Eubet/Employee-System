using EmployeeSystem.Data.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.Data.DataAccess.Repository
{
    public class GenderRepository:IPopulate<Gender>
    {
        public List<Gender> Populate()
        {
            var genderList = new List<Gender> {
                new Gender{GenderId = 1, GenderName="Male"},
                new Gender{GenderId = 2, GenderName="Female"}
                };
            return genderList;
        }
    }
}
