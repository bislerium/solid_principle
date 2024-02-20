namespace solid_principle.liskov_substitution.After
{
    public class Square : IShape
    {
        public int SideLength { get; set; }

        public int CalculateArea()
        {
            return SideLength * SideLength;
        }
    }
}
