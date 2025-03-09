namespace LocoParser.Core.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public DateTime CreatedAt { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public ICollection<Price> Prices { get; set; } = new List<Price>();
}