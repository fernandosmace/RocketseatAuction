using MediatR;
using RocketseatAuction.Application.Contracts.Repositories;

namespace RocketseatAuction.Application.Queries.Auction.GetCurrentAuction;
public class GetCurrentAuctionQueryHandler : IRequestHandler<GetCurrentAuctionQuery, GetCurrentAuctionResponse>
{
    private readonly IUnityOfWork _uow;
    public GetCurrentAuctionQueryHandler(IUnityOfWork uow)
    {
        _uow = uow;
    }

    public async Task<GetCurrentAuctionResponse> Handle(GetCurrentAuctionQuery request, CancellationToken cancellationToken)
    {
        var auction = await _uow.Auction.GetCurrentAuction();

        return new GetCurrentAuctionResponse
        {
            Auction = auction
        };
    }
}
