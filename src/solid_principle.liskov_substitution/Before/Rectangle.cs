namespace solid_principle.liskov_substitution.Before
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int CalculateArea()
        {
            return Width * Height;
        }
    }
}
