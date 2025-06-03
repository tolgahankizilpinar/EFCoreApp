using Microsoft.EntityFrameworkCore;

namespace EFCoreApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }


        public DbSet<Kurs> Kurslar { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<KursKayit> KursKayitlari { get; set; }
    }
}