using WebApiDemo.Models;

namespace WebApiDemo.Services
{
    public interface IEmployeeService
    {
        Task<Employee> AddEmployee(Employee e);
        Task<Employee> UpdateEmployee(Employee e);
        Task<string>  DeleteEmployee(int Id);
        Task<List<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int Id);

    }
}
