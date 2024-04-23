using System.ComponentModel.DataAnnotations;

namespace employee_register_api.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
    }
}
