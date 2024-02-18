namespace solid_principle.open_closed_principle.After
{
    public class StandardProduct : Product
    {
        public override decimal CalculateShippingCost()
        {
            // Calculate standard shipping cost logic
            return Price * 0.05m;
        }
    }
}
