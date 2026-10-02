using Microsoft.EntityFrameworkCore;

namespace WebApiDemo.Models
{
    public class CompanyApiTaskDBContext:DbContext
    {
        public CompanyApiTaskDBContext(DbContextOptions<CompanyApiTaskDBContext> options) : base(options)
        {

        }
        public DbSet<Employee> TblEmployees { get; set; }
    }
}
