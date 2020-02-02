using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace login.Interfaces
{
    public interface IUnitOfWork : IDisposable 
    {
        DataContext GetDataContext();
        IUserRepository UserRepository { get; set; }
        IEntryRepository EntryRepository { get; set; }

        int Complete();

    }
}
