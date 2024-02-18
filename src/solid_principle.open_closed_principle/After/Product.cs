namespace solid_principle.open_closed_principle.After
{
    public abstract class Product
    {
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public abstract decimal CalculateShippingCost();
    }
}
