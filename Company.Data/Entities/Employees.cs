using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Company.Data.Entities
{
    public class Employees
    {
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public bool UnionMember { get; set; }
        [Required]
        public CompanyDepartments? DepartmentId { get; set; }
        [Required]
        public CompanyDepartments? CompanyId { get; set; }

    }
}
