using ConsoleApp1.RunTest;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main()
        {
            Triangle t = new Triangle();
            t.TriangleTest(new Circle().MyProperty);
            Console.WriteLine();
        }
    }
}