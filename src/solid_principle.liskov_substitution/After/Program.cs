namespace solid_principle.liskov_substitution.After
{
    public class Program
    {
        public static void Main()
        {
            IShape rectangle = new Rectangle()
            {
                Width = 5,
                Height = 10,
            };

            int area = rectangle.CalculateArea();
            Console.WriteLine($"Area: {area}");

            IShape square = new Square()
            {
                SideLength = 5,
            };

            area = square.CalculateArea();
            Console.WriteLine($"Area: {area}");
        }

    }
}
