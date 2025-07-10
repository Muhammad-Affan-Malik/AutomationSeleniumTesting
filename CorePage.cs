using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;

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

            else if (browser == "MicrosoftEdge")
            {
                var options = new EdgeOptions();

                options.AddArgument("--inprivate"); 
                options.AddArgument("--disable-notifications");
                options.AddArgument("--start-maximized");
                driver = new EdgeDriver(options);

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }

        }
    }
}
