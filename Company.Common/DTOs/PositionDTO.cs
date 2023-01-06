using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public class PositionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public PositionDTO(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
