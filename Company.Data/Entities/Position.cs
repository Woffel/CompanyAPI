using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Company.Data.Interfaces;


namespace Company.Data.Entities
{
    public class Position : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<EmployeePositions> Employees { get; set; }
    }
}
