namespace solid_principle.open_closed_principle.Before
{
    public class ShippingCalculator
    {
        public decimal CalculateShippingCost(Product product)
        {
            decimal shippingCost = 0;

            if (product.Type == ProductType.Standard)
            {
                // Calculate standard shipping cost logic
                shippingCost = product.Price * 0.05m;
            }
            else if (product.Type == ProductType.Oversized)
            {
                // Calculate oversized shipping cost logic
                shippingCost = product.Price * 0.2m;
            }

            return shippingCost;
        }
    }
}
