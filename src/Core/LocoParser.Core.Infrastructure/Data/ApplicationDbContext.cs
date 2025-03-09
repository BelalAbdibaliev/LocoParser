using LocoParser.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LocoParser.Core.Infrastructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Store> Stores { get; set; }
    public DbSet<Price> Prices { get; set; }
}