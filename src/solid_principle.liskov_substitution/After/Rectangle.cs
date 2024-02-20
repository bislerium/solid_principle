namespace solid_principle.liskov_substitution.After
{
    public class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int CalculateArea()
        {
            return Width * Height;
        }
    }
}
