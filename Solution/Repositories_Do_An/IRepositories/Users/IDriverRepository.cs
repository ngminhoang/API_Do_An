﻿using Repositories_Do_An.DBcontext_vs_Entities;
using Repositories_Do_An.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories_Do_An.IRepositories.Users
{
    public interface IDriverRepository : IRepository<Driver>
    {
        Driver read(string name);
        Driver read(string mail, string password, int roleId);
        bool check(string mail);
    }
}
