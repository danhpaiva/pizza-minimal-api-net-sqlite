using Microsoft.EntityFrameworkCore;
using PizzaApi.Models;

namespace PizzaApi.Data;

class PizzaDb : DbContext
{
    public PizzaDb(DbContextOptions<PizzaDb> options) : base(options) { }
    public DbSet<Pizza> Pizzas { get; set; } = null!;
}
