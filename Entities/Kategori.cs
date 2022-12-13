using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Kategori:BaseEntity
    {
        public string Ad { get; set; }
        public List<Kitap> Kitaplar { get; set; }

    }
}
