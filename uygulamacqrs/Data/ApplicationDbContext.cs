using Microsoft.EntityFrameworkCore;

namespace uygulamacqrs.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
 public DbSet<Student>Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student[] { new Student() { Name = "Aleyna", Age = 23, Surname = "Kırşen", Id = 1 }, new Student() { Name = "Alper", Age = 19, Surname = "Kırşen", Id = 2 } });
            base.OnModelCreating(modelBuilder);
        }
    }
}
