using GuestBook.data.Model;
using Microsoft.EntityFrameworkCore;

namespace GuestBook.data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<Context.DataContext> options) : base(options)
        { }

        public DbSet<GuestNote> GuestNote { get; set; }
    }
}
