using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .HasKey(c => c.Name);

            builder
                .Property(c => c.Name)
                .IsRequired();

            builder
                .Property(c => c.Description)
                .IsRequired(false);

            builder
                .HasMany(c => c.Recipes)
                .WithOne(r => r.Category);
        }
    }
}
