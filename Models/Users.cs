using System;
using System.Collections.Generic;

namespace NewCariDefteri.Models
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string Ad { get; set; }
        public string Parola { get; set; }

        public virtual Person Person { get; set; }
    }
}
