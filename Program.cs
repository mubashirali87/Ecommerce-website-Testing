using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EcommerceGuru99websiteTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://live.demoguru99.com/index.php/");
            string mytitle= driver.Title;
            Console.WriteLine(mytitle);
            //driver.FindElement(By.CssSelector(".large"));
            driver.FindElement(By.CssSelector("li.level0:nth-child(1) > a:nth-child(1)")).Click();
            string mytitle1 = driver.Title;
            Console.WriteLine(mytitle1);
            SelectElement maindrop = new SelectElement(driver.FindElement(By.CssSelector(".category-products > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > select:nth-child(2)")));
            Thread.Sleep(2000);
            maindrop.SelectByValue("http://live.demoguru99.com/index.php/mobile.html?dir=asc&order=name");
            //SelectElement dropd=new SelectElement(driver.FindElement(By.CssSelector("body > div > div > div.main-container.col3-layout > div > div.col-wrapper > div.col-main > div.category-products > div.toolbar > div.sorter > div > select")));

        }
    }
}
