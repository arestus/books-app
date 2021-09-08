using System;
using System.Collections.Generic;

#nullable disable

namespace BookAuthor.Models
{
    public partial class Store
    {
        public Store()
        {
            Sale1s = new HashSet<Sale1>();
        }

        public string StorId { get; set; }
        public string StorName { get; set; }
        public string StorAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public virtual ICollection<Sale1> Sale1s { get; set; }
    }
}
