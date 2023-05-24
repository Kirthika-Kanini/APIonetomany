using APIonetomany.Models;
using APIonetomany.Respository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIonetomany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository emp;
        public EmployeeController(IEmployeeRepository emp)
        {
            this.emp = emp;
        } 
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return emp.GetEmployees();
        }

        [HttpGet("{id}")]
        public Employee GetById(int id)
        {
            return emp.GetEmployeesById(id);
        }

        [HttpPost]
        public Employee PostEmployee(Employee employee)
        {
            return emp.PostEmployee(employee);
        }
        [HttpPut("{id}")]
        public Employee PutEmployee(int id,Employee employee)
        {
            return emp.PutEmployee(id, employee);
        }
        [HttpDelete("{id}")]
        public Employee DeleteEmployee(int id)
        {
            return emp.DeleteEmployee(id);
        }

    }
}
