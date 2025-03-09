namespace LocoParser.Core.Domain.Entities;

public class Price
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int StoreId { get; set; }
    public Store Store { get; set; }
    public decimal Value { get; set; }
    public string Currency { get; set; } = string.Empty;
    public decimal DiscountPrice { get; set; }
    public string ItemUrl {get; set;} = string.Empty;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}