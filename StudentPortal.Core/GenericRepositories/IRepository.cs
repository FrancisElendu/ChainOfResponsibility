﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Core.GenericRepositories
{
    // Generic Repository Interface
    public interface IRepository<T>
    {
        Task AddAsync(T entity);
    }
}
