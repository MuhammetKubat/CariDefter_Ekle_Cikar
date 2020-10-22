using System;
using System.Collections.Generic;

namespace NewCariDefteri.Models
{
    public partial class Person
    {
        public int PersonId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int? UserId { get; set; }

        public virtual Users User { get; set; }
        public virtual Info Info { get; set; }
    }
}
