using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\11035928\Downloads\SeleniumTesting\SeleniumTesting");
            string url = "http://localhost:62399/Pizzas";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            IWebElement element1 = driver.FindElement(By.Id("details"));
            Thread.Sleep(2000);
            element1.Click();
            Thread.Sleep(1000);

            IWebElement element2 = driver.FindElement(By.Id("order"));
            Thread.Sleep(2000);
            element2.Click();
            Thread.Sleep(1000);

            IWebElement element3 = driver.FindElement(By.Id("list"));
            Thread.Sleep(2000);
            element3.Click();

            Thread.Sleep(10000);
            driver.Quit();
        }
    }
}