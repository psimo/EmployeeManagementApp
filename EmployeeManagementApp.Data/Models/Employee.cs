using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementApp.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string  Address { get; set; }
        public Project Project { get; set; }

        [Display(Name = "Project")]
        public int ProjectId { get; set; }

    }
}
