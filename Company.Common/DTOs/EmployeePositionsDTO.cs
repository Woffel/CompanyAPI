using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public class EmployeePositionsDTO
    {
        public int EmployeeId { get; set; }

        public int PositionId { get; set; }

        public EmployeePositionsDTO(int EmployeeId, int PositionId)
        {
            this.EmployeeId = EmployeeId;
            this.PositionId = PositionId;   
        }

    }
}
