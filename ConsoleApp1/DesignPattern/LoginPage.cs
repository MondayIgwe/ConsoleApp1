using OpenQA.Selenium;

namespace ConsoleApp1.DesignPattern
{
    // Client
    public class LoginPage : Base
    {
        Stream stream;

        public LoginPage(IWebDriver driver, int count) : base(driver)
        {
            stream = new MemoryStream();
            Count = count;
            Driver.Close();
            Driver.Quit();
        }
    }
}
