using EmployeeSystem.Data.DataAccess.Interfaces;
using System.Collections.Generic;

namespace EmployeeSystem.Data.DataAccess.Repository
{
    public class TitleRepo : IPopulate<Title>
    {
        public List<Title> Populate()
        {
            var titles = new List<Title> {
                new Title{TitleId = 1, TitleName="Mr"},
                new Title{TitleId = 2, TitleName="Mrs"},
                new Title{TitleId = 3, TitleName="Dr"},
                new Title{TitleId = 4, TitleName="Madam"},
                new Title{TitleId = 5, TitleName="Alhaji"}
                };
            return titles;

        }
    }
}