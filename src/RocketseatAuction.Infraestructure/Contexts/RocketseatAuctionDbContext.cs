using Microsoft.EntityFrameworkCore;
using RocketseatAuction.Domain.Entities;

namespace RocketseatAuction.Infraestructure.Contexts;
public class RocketseatAuctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<Item> Items { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\ferna\\Documents\\Dev\\Dotnet\\Rocketseat\\leilaoDbNLW.db");
    }
}
