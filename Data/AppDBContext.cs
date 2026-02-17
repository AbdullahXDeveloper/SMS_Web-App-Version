using Microsoft.EntityFrameworkCore;
using SMS_Web_App_Version.Models;

namespace SMS_Web_App_Version.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> students { get; set; }
    }
}
