using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationSeleniumTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://adactinhotelapp.com/";
            driver.FindElement(By.Id("username")).SendKeys("AmirTester");
            driver.FindElement(By.Id("password")).SendKeys("AmirTester");
            driver.FindElement(By.Id("login")).Click();


            string actualText = driver.FindElement(By.ClassName("welcome_menu")).Text;
            string expectedText = "Welcome to Adactin Group of Hotels";
            Assert.AreEqual(expectedText, actualText);
            driver.Close();
        }
    }
}
