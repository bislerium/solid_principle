namespace solid_principle.open_closed_principle.After
{
    public class OversizedProduct : Product
    {
        public override decimal CalculateShippingCost()
        {
            // Calculate oversized shipping cost logic
            return Price * 0.2m;
        }
    }
}
