using Microsoft.EntityFrameworkCore;
using PSR_Automation.Data.Model;

namespace PSR_Automation.Data.DBConnection
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }      

        public DbSet<AllSubmission> AllSubmissions { get; set; }
    }
}
