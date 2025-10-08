using efcore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

namespace efcoreApp.Data
{

    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext>options):base (options)

        {
            

        }
        public DbSet<Kurs> Kurslar => Set<Kurs>();

        public DbSet<Ogrenci> Ogrenciler => Set<Ogrenci>();
       

        public DbSet<KursKayit> KursKayitlari => Set<KursKayit>();

    }
    
}