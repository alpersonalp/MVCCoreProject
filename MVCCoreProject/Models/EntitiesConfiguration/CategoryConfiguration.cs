﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCCoreProject.Models.Entities;

namespace MVCCoreProject.Models.EntitiesConfiguration
{
    // IEntityTypeConfiguration => tablo ile class arasında mapping yapmak için kullanılan interface'dir...

    // Fluent Api yöntemi ile db sınıfları configure edilirken modelCreating metodu yerine configuration dosyaları oluşturup bu işlemi yapmak daha iyidir..
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("CategoryID"); 
            builder.Property(c => c.Name).HasColumnName("CategoryName");
            builder.Property(c=> c.Description).HasColumnType("nvarchar").HasMaxLength(15);

           
        }
    }
}
