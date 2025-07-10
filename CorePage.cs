using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationSeleniumTesting
{
    internal class CorePage
    {
        public static IWebDriver driver;

        public static void SeleniumInit(string browser)
        {
            if (browser == "Chrome")
            {
                var chromeOptions = new ChromeOptions();
                chromeOptions.AddArguments("--start-maximized");
                chromeOptions.AddArguments("--incognito");
                IWebDriver chromeDriver = new ChromeDriver(chromeOptions);
                driver = chromeDriver;

            }
        }
    }
}
