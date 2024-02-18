namespace solid_principle.open_closed_principle.After
{
    public class FragileProduct : Product
    {
        public override decimal CalculateShippingCost()
        {
            // Calculate fragile shipping cost logic
            return Price * 0.15m;
        }
    }
}
