using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Models;
using WebApiDemo.Services;

namespace WebApiDemo.Controllers
{
  //  [Route("api/[controller]")]
    [ApiController]
    public class EmployeeApiController : ControllerBase
    {
        IEmployeeService employeeService;
        public EmployeeApiController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        [HttpGet]
        [Route("api/employee")]
        public async Task<List<Employee>> GetAll()
        {
            return await employeeService.GetEmployees();
        }
        [HttpGet]
        [Route("api/employee/{id}")]
        public async Task<Employee> GetById(int id)
        {
            return await employeeService.GetEmployee(id);
        }
        [HttpPost]
        [Route("api/employee")]
        public async Task<Employee> AddEmployee(Employee e)
        {
            Employee emp = await employeeService.AddEmployee(e);
            return emp;
        }
        [HttpPut]
        [Route("api/employee/{id}")]
        public async Task<Employee> UpdateEmployee(int id,Employee e)
        {
            e.EmployeeId = id;
            Employee emp = await employeeService.UpdateEmployee(e);
            return emp;
        }
        [HttpDelete]
        [Route("api/employee/{id}")]
        public async Task<string> DeleteEmployee(int id)
        {
             
            string msg=await employeeService.DeleteEmployee(id);
            return msg;
        }
    }
}
