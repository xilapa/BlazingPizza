using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Data;

public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions opts) : base(opts)
    { }

    public DbSet<PizzaSpecial> Specials { get; set; }
}