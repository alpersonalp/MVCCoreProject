using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCCoreProject.Models.Entities;

namespace MVCCoreDependencyInjection2.Models.EntitiesConfiguration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(c => c.id);
            builder.Property(c => c.id).HasColumnName("CustomerID");
            builder.Property(c => c.Title).HasColumnName("ContactTitle");

        }
    }
}