
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp1.DesignPattern
{
    public class WebBasedAPP : Generics
    {
        public override void Login(string username, string passwd)
        {
            Driver = new ChromeDriver();

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("", "");

            WebBasedAPP we =  (WebBasedAPP)MyProperty;

            try
            {
                Console.WriteLine($"Web app logins: {username},{passwd}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Expected: " + e.Message);
            }
        }
    }
}
