using System;
using System.Collections.Generic;

#nullable disable

namespace BookAuthor.Models
{
    public partial class Sale1
    {
        public string StorId { get; set; }
        public string OrdNum { get; set; }
        public DateTime OrdDate { get; set; }
        public short Qty { get; set; }
        public string Payterms { get; set; }
        public string TitleId { get; set; }

        public virtual Store Stor { get; set; }
        public virtual Title Title { get; set; }
    }
}
