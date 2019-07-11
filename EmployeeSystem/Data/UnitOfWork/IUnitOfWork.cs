﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.Data.UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        int CommitAll();
    }
}
