using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Salary { get; set; }
        public bool UnionMember { get; set; }


        public EmployeeDTO(int Id, string FirstName, string LastName, int Salary, bool UnionMember)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Salary = Salary;
            this.UnionMember = UnionMember;
        }
    }
}
