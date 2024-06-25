using System;
using System.Collections.Generic;

namespace Kurs.Entities
{
    public partial class TblNotlar
    {
        public int Id { get; set; }
        public int DersId { get; set; }
        public int OgrId { get; set; }
        public short? Sinav1 { get; set; }
        public short? Sinav2 { get; set; }
        public short? Sinav3 { get; set; }
        public decimal? Ortalama { get; set; }

        public virtual TblDersler Ders { get; set; } = null!;
        public virtual TblOgrenciler Ogr { get; set; } = null!;
    }
}
