using System;
using System.Collections.Generic;

namespace NewCariDefteri.Models
{
    public partial class Info
    {
        public int InfoId { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public int? PersonId { get; set; }

        public virtual Person Person { get; set; }
    }
}
