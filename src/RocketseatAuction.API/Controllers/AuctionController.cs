using MediatR;
using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.Application.Contracts.Services;
using RocketseatAuction.Application.Queries.Auction.GetCurrentAuction;
using RocketseatAuction.Domain.Entities;

namespace RocketseatAuction.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AuctionController : ControllerBase
{
    private readonly IAuctionService _auctionService;
    private readonly IMediator _bus;
    public AuctionController(IAuctionService auctionService, IMediator bus)
    {
        _auctionService = auctionService;
        _bus = bus;
    }

    [HttpGet]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetCurrentAuction(
        [FromQuery] GetCurrentAuctionQuery query)
    {
        var auction = await _bus.Send<GetCurrentAuctionResponse>(query);

        if (auction is null)
            return NoContent();

        return Ok(auction);
    }
}
