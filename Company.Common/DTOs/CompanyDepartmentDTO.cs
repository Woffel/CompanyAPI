using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public class CompanyDepartmentDTO
    {
        public int CompanyId { get; set; }
        public int DepartmentId { get; set; }

        public CompanyDepartmentDTO(int CompanyId, int DepartmentId)
        {
            this.CompanyId = CompanyId;
            this.DepartmentId = DepartmentId;
        }

    }
}
