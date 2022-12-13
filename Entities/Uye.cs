using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Uye:BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tc { get; set; }
        public string Tel { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
        public int Ceza { get; set; }
        public char Yetki { get; set; }
        public List<OduncKitap> Kitaplar { get; set; }

    }
}
