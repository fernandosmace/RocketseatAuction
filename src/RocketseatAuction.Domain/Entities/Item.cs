﻿using RocketseatAuction.Domain.Enums;

namespace RocketseatAuction.Domain.Entities;
public class Item : Entity
{
    public string Name { get; set; } = string.Empty;
    public string Brand { get; set; } = string.Empty;
    public ECondition Condition { get; set; }
    public decimal BasePrice { get; set; }
    public int AuctionId { get; set; }
}
