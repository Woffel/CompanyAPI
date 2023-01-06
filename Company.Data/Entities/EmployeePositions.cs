using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities
{
    public class EmployeePositions
    {
        public int EmployeeId { get; set; }

        public Employee? Employee { get; set; }

        public int PositionId { get; set; }

        public Position? Position { get; set; }
    }
}
