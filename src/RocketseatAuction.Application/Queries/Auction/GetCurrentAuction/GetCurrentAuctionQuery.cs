using MediatR;

namespace RocketseatAuction.Application.Queries.Auction.GetCurrentAuction;
public record GetCurrentAuctionQuery : IRequest<GetCurrentAuctionResponse>
{
}
