﻿using login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace login.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
