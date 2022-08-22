using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignPattern
{
    // Server
    public class Base
    {
        public int Count = 0;
        public Base(IWebDriver driver)
        {
            Driver = driver;    
        }

        public IWebDriver Driver { get; private set; } = new ChromeDriver();
    }
}
