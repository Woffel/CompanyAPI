﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Interfaces;

namespace Company.Data.Entities
{
    public class EmployeePositions : IReferenceEntity
    {
        public int EmployeeId { get; set; }

        public Employee? Employee { get; set; }

        public int PositionId { get; set; }

        public Position? Position { get; set; }
    }
}
