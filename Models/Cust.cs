using System;
using System.Collections.Generic;

#nullable disable

namespace BookAuthor.Models
{
    public partial class Cust
    {
        public Cust()
        {
            InverseReffByNavigation = new HashSet<Cust>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ReffBy { get; set; }

        public virtual Cust ReffByNavigation { get; set; }
        public virtual ICollection<Cust> InverseReffByNavigation { get; set; }
    }
}
