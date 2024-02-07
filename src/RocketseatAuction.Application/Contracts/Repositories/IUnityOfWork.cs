namespace RocketseatAuction.Application.Contracts.Repositories;
public interface IUnityOfWork
{
    public IAuctionRepository Auction { get; }
}
