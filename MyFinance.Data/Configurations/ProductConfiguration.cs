using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFinance.Domain.Entities;

namespace MyFinance.Data.Configurations
{
   public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasOptional(l => l.MyCategory).WithMany(c => c.ListProduct).HasForeignKey(f=>f.CategoryId).WillCascadeOnDelete(false);
            HasMany(p => p.ListProvider).WithMany(p => p.ListProduct).Map(
                c =>
                {
                    c.ToTable("Product_Provider");
                    c.MapLeftKey("ProductId");
                    c.MapRightKey("ProviderId");

                });

            Map<Biological>(c => c.Requires("isBio").HasValue(1));
            Map<Chemical>(c => c.Requires("isBio").HasValue(0));
        }
    }
}
