using APIonetomany.Models;

namespace APIonetomany.Respository
{
    public interface IEmployeeRepository
    {
        public IEnumerable<Employee> GetEmployees();
        public Employee GetEmployeesById(int id);
        public Employee PostEmployee(Employee employee);
        public Employee PutEmployee(int id,Employee employee);
        public Employee DeleteEmployee(int id);
    }
}
