using ConsoleApp1.DesignPattern;
using ConsoleApp1.RunTest;
using OpenQA.Selenium;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main()
        {
            IWebDriver driver = null;
            LoginPage loginPage = new(driver, 200);
            Triangle t = new Triangle();
            t.TriangleTest(new Circle().MyProperty, loginPage);
            Console.WriteLine();
        }
    }
}