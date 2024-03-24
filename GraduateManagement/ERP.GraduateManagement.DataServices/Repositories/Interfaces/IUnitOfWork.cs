﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.GraduateManagement.DataServices.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IGraduateRepository Graduates {  get; }

        Task<bool> CompleteAsync();
    }
}
