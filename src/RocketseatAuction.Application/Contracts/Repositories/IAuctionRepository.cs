using RocketseatAuction.Domain.Entities;

namespace RocketseatAuction.Application.Contracts.Repositories;
public interface IAuctionRepository
{
    public Task<Auction> GetCurrentAuction();
}
