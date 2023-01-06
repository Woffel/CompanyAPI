using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Company.Data.Interfaces;

namespace Company.Data.Entities
{
    public class Department : IEntity
    {
        public int Id { get; set; }

        [MaxLength(80), Required]
        public string? DepartmentName { get; set; }

        public ICollection<CompanyDepartment>? Companies { get; set; }
    }
}
