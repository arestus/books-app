using System;
using System.Collections.Generic;

#nullable disable

namespace BookAuthor.Models
{
    public partial class Salary
    {
        public Salary()
        {
            Employeesalaries = new HashSet<Employeesalary>();
        }

        public int SalId { get; set; }
        public int? Basic { get; set; }
        public int? Hra { get; set; }
        public int? Da { get; set; }
        public int? Deduction { get; set; }

        public virtual ICollection<Employeesalary> Employeesalaries { get; set; }
    }
}
