using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebAppEF.Model.Entity;

namespace WebAppEF.DataAccess.DB_Context
{
    public class SchoolContext : DbContext
    {

        public SchoolContext() : base("SchoolContext")  //connection string name
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
