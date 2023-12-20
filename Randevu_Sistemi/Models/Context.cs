using Microsoft.EntityFrameworkCore;
using RandevuSistemi.Models.Entities;

namespace RandevuSistemi.Models
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-74OJ9AT\\SQLEXPRESS;Initial Catalog=RandevuSistemi;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public DbSet<AnaBilimDali> AnaBilimDallari { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Doktor> Doktorlar { get; set; }
        public DbSet<Poliklinik> Poliklinikler { get; set; }
        public DbSet<Randevu> Randevular { get; set; }
        public DbSet<Hizmetler> Hizmetler { get; set; }
        public DbSet<CalismaSaatleri> CalismaSaatleri { get; set; }
    }
}
