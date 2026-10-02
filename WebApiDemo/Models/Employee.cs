using System.ComponentModel.DataAnnotations;

namespace WebApiDemo.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName{ get; set; }
        public  string Designation{ get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public float Salary { get; set; }
    }
}
