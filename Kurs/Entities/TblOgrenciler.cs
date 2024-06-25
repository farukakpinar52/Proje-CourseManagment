using System;
using System.Collections.Generic;

namespace Kurs.Entities
{
    public partial class TblOgrenciler
    {
        public TblOgrenciler()
        {
            TblNotlars = new HashSet<TblNotlar>();
        }

        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? Foto { get; set; }

        public virtual ICollection<TblNotlar> TblNotlars { get; set; }
    }
}
