using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor for ApplicationDbContext that takes DbContextOptions as a parameter
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            // The constructor calls the base class (DbContext) constructor with the provided options
            // The options typically include the database connection string and other configurations
            // This constructor is used during the configuration of dependency injection in the application
        }

        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Task as a keyless entity type
            modelBuilder.Entity<Task>().HasNoKey();
            
            // Other configurations if needed

            base.OnModelCreating(modelBuilder);
        }
    }
}
