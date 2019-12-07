using GuestBook.data.Model;
using Microsoft.EntityFrameworkCore;

namespace GuestBook.data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<Context.DataContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
            {
                id = 1,
                Username = "admin",
                Password = "12345678"
            });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<GuestNote> GuestNotes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
