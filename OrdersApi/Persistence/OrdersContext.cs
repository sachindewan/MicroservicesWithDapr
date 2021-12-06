using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrdersApi.Models;

namespace OrdersApi.Persistence
{
    public class OrdersContext:DbContext
    {
        public OrdersContext(DbContextOptions<OrdersContext> dbContextOptions):base(dbContextOptions)
        {

        }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var converter = new EnumToStringConverter<Status>();
            modelBuilder
                .Entity<Order>()
                .Property(p => p.Status)
                .HasConversion(converter);
        }

    }
}
