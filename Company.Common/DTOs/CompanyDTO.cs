﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public class CompanyDTO
    {
        public int Id { get; set; }
        public string? CompanyName { get; set; }

        public CompanyDTO(int Id, string CompanyName)
        {
            this.Id = Id;
            this.CompanyName = CompanyName;
        }
    }
}
