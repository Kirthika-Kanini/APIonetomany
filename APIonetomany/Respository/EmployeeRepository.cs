using APIonetomany.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIonetomany.Respository
{

    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly OrganizationContext _organizationContext;
        public EmployeeRepository(OrganizationContext con)
        {
            _organizationContext = con;
        }

      

        public IEnumerable<Employee> GetEmployees()
        {
            return  _organizationContext.Employees.ToList();
        }
        public Employee GetEmployeesById(int id)
        {
             return _organizationContext.Employees.FirstOrDefault(x => x.Empid == id);
        }

        public Employee PostEmployee(Employee employee)
        {

            var emp = _organizationContext.Departments.Find(employee.Department.Deptid);
            employee.Department = emp;
            _organizationContext.Add(employee);
            _organizationContext.SaveChanges();
            return employee;
        }

        public Employee PutEmployee(int id, Employee employee)
        {
            var emp = _organizationContext.Departments.Find(employee.Department.Deptid);
            employee.Department = emp;
            _organizationContext.Entry(employee).State = EntityState.Modified;
            _organizationContext.SaveChangesAsync();
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {

            var emp =  _organizationContext.Employees.Find(id);

           
            _organizationContext.Employees.Remove(emp);
            _organizationContext.SaveChanges();

            return emp;
        }
    }
}
