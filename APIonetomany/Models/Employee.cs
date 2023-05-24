using System.ComponentModel.DataAnnotations;

namespace APIonetomany.Models
{
    public class Employee
    {
        [Key]
        public int Empid { get; set; }
        public string Empname { get; set; }
        public Department Department { get; set; }

    }
}
