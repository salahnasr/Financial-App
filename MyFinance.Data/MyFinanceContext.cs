using System.Data.Entity;
using MyFinance.Data.Configurations;
using MyFinance.Domain.Entities;

namespace MyFinance.Data
{
    public class MyFinanceContext : DbContext
    {
        public MyFinanceContext() : base("Name=DefaultConnection")
        {
//            Database.SetInitializer(new InitializerContext());
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new AdresseConfiguration());
        }
        
    }

   /* public class InitializerContext : DropCreateDatabaseIfModelChanges<MyFinanceContext>
        {
            protected override void Seed(MyFinanceContext ctx)
            {
                var listCategory = new List<Category>
                {
                    new Category
                    {
                        Name = "Cat1"
                    },
                    new Category
                    {
                        Name = "Cat2"
                    },
                };
    
                ctx.Categories.AddRange(listCategory);
                ctx.SaveChanges();
            }
        }*/
}