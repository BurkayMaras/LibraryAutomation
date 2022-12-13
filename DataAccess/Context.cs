using Entities;
using System.Data.Entity;

namespace DataAccess
{
    public class Context : DbContext
    {
        public Context() : base("Context")
        {
            
        }
       
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<OduncKitap> OduncKitaplar { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }


    }
}

