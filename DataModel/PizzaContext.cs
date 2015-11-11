using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class PizzaContext : DbContext
    {
        public PizzaContext()
            : base("defaultConn")
        {
            Database.SetInitializer<PizzaContext>(null);
        }

        public DbSet<Pizza>      Pizzas { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Order>      Orders { get; set; }
        public DbSet<OrderItem>  OrderItems { get; set; }
        public DbSet<Customer>   Customers { get; set; }
    }
}
