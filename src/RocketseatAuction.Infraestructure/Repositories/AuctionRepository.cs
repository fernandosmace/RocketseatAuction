using Microsoft.EntityFrameworkCore;
using RocketseatAuction.Application.Contracts.Repositories;
using RocketseatAuction.Domain.Entities;
using RocketseatAuction.Infraestructure.Contexts;

namespace RocketseatAuction.Infraestructure.Repositories;
public class AuctionRepository : IAuctionRepository
{
    private readonly RocketseatAuctionDbContext _context;
    public AuctionRepository(RocketseatAuctionDbContext context)
    {
        _context = context;
    }
    public async Task<Auction> GetCurrentAuction()
        => await _context.Auctions
             .Where(auction => DateTime.Now >= auction.Starts && DateTime.Now <= auction.Ends)
             .Include(auction => auction.Items)
             .FirstOrDefaultAsync();

}
