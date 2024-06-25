using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Entities
{
    public class SPEntity
    {
        public int? Id { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? DersAdi { get; set; }
        public short? Sinav1 { get; set; } 
        public short? Sinav2 { get; set; }
        public short? Sinav3 { get; set; }
        public decimal? Ortalama { get; set; }
    }
}
