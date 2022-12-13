using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class OduncKitap:BaseEntity
    {
        public int KitapId { get; set; }
        public int UyeId { get; set; }
        public DateTime AlisTarihi { get; set; }
        public DateTime TeslimEdilecegiTarih { get; set; }
        public DateTime TeslimTarihi { get; set; }


    }
}
