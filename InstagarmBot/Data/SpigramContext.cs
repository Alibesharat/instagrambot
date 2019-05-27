using InstagarmBot.Models;
using Microsoft.EntityFrameworkCore;

namespace InstagarmBot.Data
{
   public class SpigramContext : DbContext
    {

      
        public SpigramContext(DbContextOptions<SpigramContext> options)
              : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {


            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<user> users { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}
