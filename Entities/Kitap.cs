using System;
using System.Collections.Generic;

namespace Entities
{
    public class Kitap : BaseEntity
    {
        public string Ad { get; set; }
        public string SiraNo { get; set; }
        public int Adet { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public int YazarID { get; set; }
        public Yazar Yazar { get; set; }
        public List<Kategori> Kategoriler { get; set; }

    }
}
