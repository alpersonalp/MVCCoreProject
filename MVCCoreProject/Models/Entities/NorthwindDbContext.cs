using Microsoft.EntityFrameworkCore;
using MVCCoreDependencyInjection2.Models.EntitiesConfiguration;
using MVCCoreProject.Models.EntitiesConfiguration;
using MVCCoreProject.Models.ViewModels;
using System.Linq;

namespace MVCCoreProject.Models.Entities
{
    public class NorthwindDbContext : DbContext
    {
        public NorthwindDbContext(DbContextOptions<NorthwindDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }

        public DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        }

        public DbSet<MVCCoreProject.Models.ViewModels.CustomerViewModel>? CustomerViewModel { get; set; }
    }


    // Base sinifa ctroda parametre gönderme örneki
    //public class BaseSinif
    //{
    //    string isim;
    //    public BaseSinif(string i)
    //    {
    //        isim = i;
    //    }
    //    public void Goster()
    //    {
    //        Console.WriteLine(isim);
    //    }
    //}

    //public class AltSinif : BaseSinif
    //{
    //    public AltSinif(string str) : base(str)
    //    {
    //    }
    //}

}
