public class UpdatedOrderEvent
{
    public Guid Id{ get; set; }
    public int IdCliente { get; set; }
    public decimal TotalPrice { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal DiscountedPrice { get; set; }

    public IEnumerable<int> ProductsIds { get; set; }
}