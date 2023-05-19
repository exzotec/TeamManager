using Microsoft.EntityFrameworkCore;
using TeamManager.Data.Models;

namespace TeamManager.Data.DataContext
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Employee> employee { get; set; } = null!;
        public DbSet<AssignmentCard> assignmentCard { get; set; } = null!;
        public DbSet<userAuth> auth { get; set; } = null!;
        public DbSet<client> Client { get; set; } = null!;
    

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=TeamManager;Username=admin;Password=900900786");
        }
    }
}
