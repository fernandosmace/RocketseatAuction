namespace RocketseatAuction.Application.Queries.Auction.GetCurrentAuction;
public record GetCurrentAuctionResponse
{
    public Domain.Entities.Auction Auction { get; set; }
}
