using Microsoft.EntityFrameworkCore;
using WebApiDemo.Models;

namespace WebApiDemo.Services
{
    public class EmployeeService : IEmployeeService
    {
        CompanyApiTaskDBContext db;
        public EmployeeService(CompanyApiTaskDBContext db)
        {
            this.db = db;
        }
        public async Task<Employee> AddEmployee(Employee e)
        {
            await db.TblEmployees.AddAsync(e);
            await db.SaveChangesAsync();
            return e;
        }

        public async Task<string> DeleteEmployee(int Id)
        {
            Employee emp = await GetEmployee(Id);
            db.TblEmployees.Remove(emp);
            await db.SaveChangesAsync();
            return "Employee Deleted Successfully";

        }

        public async Task<Employee> GetEmployee(int Id)
        {
            Employee emp =await db.TblEmployees.FindAsync(Id);
            return emp;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await db.TblEmployees.ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee e)
        {
              db.TblEmployees.Update(e);
            await db.SaveChangesAsync();
            return e;
        }
    }
}
