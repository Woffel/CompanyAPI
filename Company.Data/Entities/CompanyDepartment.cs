using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Company.Data.Entities
{
    public class CompanyDepartment
    {
        [Required]
        public int CompanyId { get; set; } 

        public Company? Company { get; set; }

        public int DepartmentId { get; set; }

        public Department? Department { get; set; }

        public ICollection<Employee> Employees { get; set; }

    }
}
