using System;
using System.Collections.Generic;

namespace Kurs.Entities
{
    public partial class TblDersler
    {
        public TblDersler()
        {
            TblNotlars = new HashSet<TblNotlar>();
        }

        public int Id { get; set; }
        public string? Adi { get; set; }

        public virtual ICollection<TblNotlar> TblNotlars { get; set; }
    }
}
