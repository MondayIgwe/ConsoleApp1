using ConsoleApp1.DesignPattern;

namespace ConsoleApp1.RunTest
{
    public class Triangle
    {

        private Circle? circle { get; set; }

        List<Base> triangles { get; set; }
        public Triangle()
        {
            circle = new Rectangle();
            triangles = new List<Base>();
        }

        // Delegate the task from the circl request
        public void TriangleTest(Circle c, LoginPage loginPage)
        {
            triangles.Add(loginPage);
            circle = c;
            circle.Area();
        }
    }
}
