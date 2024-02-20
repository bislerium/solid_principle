namespace solid_principle.liskov_substitution.Before
{
    public class Program
    {
        public static void Main()
        {
            Rectangle rectangle = new Square();
            rectangle.Width = 5;
            rectangle.Height = 10;

            // Calling CalculateArea on a Square, violating LSP
            int area = rectangle.CalculateArea();
            Console.WriteLine($"Area: {area}");
        }

    }
}
