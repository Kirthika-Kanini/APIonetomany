using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace APIonetomany.Models
{
    public class Department
    {
        [Key]
        public int Deptid { get; set; }
        public string ? Deptname { get; set; }
        public ICollection<Employee> ? Employees { get; set; }
    }
}
