using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public class CompanyDTO
    {
        public string Id { get; set; }
        public string? CompanyName { get; set; }

        public CompanyDTO(string Id, string CompanyName)
        {
            this.Id = Id;
            this.CompanyName = CompanyName;
        }
    }
}
