﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{

    //Seeds kullanmamızın sebebi database tarafına default degerler girmemiz için kullanılıyor.
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
            new Category { Id = 1, Name = "Kalemler" },
            new Category { Id = 2, Name = "Kitaplar" },
            new Category { Id = 3, Name = "Defterler" });
        }
    }
}
