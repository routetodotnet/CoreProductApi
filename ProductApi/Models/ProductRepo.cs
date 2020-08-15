using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Models
{

    public class ProductDataContext : DbContext
    { 
        public DbSet<Product> Products { set; get; }

        public ProductDataContext(DbContextOptions<ProductDataContext> options) : base(options)
        { 
        
        }
        

    }

    public static class DbInitializer
    {
        public static void Initialize(ProductDataContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            var prods = new Product[] {

               new Product(){ id=1,name="laptop",desc="mac white"},
                new Product(){ id=2,name="phone",desc="samsung"},
                new Product(){ id=3,name="bat",desc="black"}
            };
            foreach (var item in prods)
            {
                context.Products.Add(item);
            }
            context.SaveChanges();

          
           
        }
    }
    public class ProductRepo
    {
    }
}
