using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public class DepartmentDTO
    {
        public int Id { get; set; }
        public string? DepartmentName { get; set; }

        public DepartmentDTO(int Id, string DepartmentName)
        {
            this.Id = Id;
            this.DepartmentName = DepartmentName;
        }
    }
}
