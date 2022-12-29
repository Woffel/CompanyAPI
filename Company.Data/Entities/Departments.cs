using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Company.Data.Entities
{
    public class Departments
    {
        public int Id { get; set; }

        [MaxLength(80), Required]
        public string? DepartmentName { get; set; }
    }
}
