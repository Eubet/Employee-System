using EmployeeSystem.Data.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.Data.DataAccess.Repository
{
    public class RegionRepository : IPopulate<Region>
    {
        public List<Region> Populate()
        {
            var regions = new  List<Region>()
            {
                new Region{RegionId = 1, RegionName="Ashanti"},
                new Region{RegionId = 2, RegionName="Greater Accra"},
                new Region{RegionId = 3, RegionName="Bono"},
                new Region{RegionId = 4, RegionName="Bono East"},
                new Region{RegionId = 5, RegionName="Ahafo"},
                new Region{RegionId = 6, RegionName="Central"},
                new Region{RegionId = 7, RegionName="Eastern"},
                new Region{RegionId = 8, RegionName="Northern"},
                new Region{RegionId = 9, RegionName="Savannah"},
                new Region{RegionId = 10, RegionName="North East"},
                new Region{RegionId = 11, RegionName="Upper East"},
                new Region{RegionId = 12, RegionName="Upper West"},
                new Region{RegionId = 13, RegionName="Volta"},
                new Region{RegionId = 14, RegionName="Oti"},
                new Region{RegionId = 15, RegionName="Western"},
                new Region{RegionId = 16, RegionName="Western North"},
            };

            return regions;
        }
    }
}
