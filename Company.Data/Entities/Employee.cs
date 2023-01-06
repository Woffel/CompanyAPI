using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Company.Data.Interfaces;


namespace Company.Data.Entities
{
    public class Employee : IEntity
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

        public CompanyDepartment? CompanyDepartment { get; set; }
        public ICollection<EmployeePositions> Positions { get; set; }
    }
}
