using OpenQA.Selenium;

namespace ConsoleApp1.DesignPattern
{
    /// <summary>
    /// User defined object
    /// </summary>
    public abstract class Generics
    {
        // I want all objects that use common interfaces to use this abstract class
        public abstract void Login(string username, string passwd);

        public Generics MyProperty { get; set; }
        public IWebDriver Driver { get; set; }
    }
}
