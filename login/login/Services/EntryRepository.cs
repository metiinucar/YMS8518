using login.Interfaces;
using login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace login.Services
{
    public class EntryRepository : Repository<Entry>,IEntryRepository
    {
        
        public EntryRepository(DataContext dataContext) : base(dataContext)
        {
            
        }
    }
}
