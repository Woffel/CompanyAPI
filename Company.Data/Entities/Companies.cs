using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Company.Data.Entities
{
    public class Companies
    {
        public string Id { get; set; }

        [MaxLength(80), Required]
        public string? CompanyName { get; set; }
    }
}
