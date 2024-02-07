using RocketseatAuction.Application.Contracts.Repositories;

namespace RocketseatAuction.Infraestructure.Contexts;
public class UnityOfWork : IUnityOfWork
{
    private readonly IAuctionRepository _auctionRepository;
    public UnityOfWork(IAuctionRepository auctionRepository)
    {
        _auctionRepository = auctionRepository;
    }

    public IAuctionRepository Auction { get => _auctionRepository; }
}
