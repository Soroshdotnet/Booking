using Booking.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Booking.Data
{
    public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>();
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Booking;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new ApplicationDbContext(options.Options);

        }
    }
}
