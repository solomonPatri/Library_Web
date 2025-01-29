using Library_Web.Libraries.Model;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace Library_Web.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {






        }



        public virtual DbSet<Library> Libraries
        {
            get;set;

        }






    }
}
