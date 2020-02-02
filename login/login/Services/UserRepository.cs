using login.Interfaces;
using login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace login.Services
{
    public class UserRepository : Repository<User>, IUserRepository
    {

        public UserRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
