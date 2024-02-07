namespace RocketseatAuction.Domain.Entities;
public class Auction : Entity
{
    public string Name { get; set; }
    public DateTime Starts { get; set; }
    public DateTime Ends { get; set; }
    public IList<Item> Items { get; set; } = [];
}
