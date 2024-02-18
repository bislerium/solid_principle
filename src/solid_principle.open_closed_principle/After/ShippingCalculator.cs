namespace solid_principle.open_closed_principle.After
{
    public class ShippingCalculator
    {
        public decimal CalculateShippingCost(Product product)
        {
            return product.CalculateShippingCost();
        }
    }
}
