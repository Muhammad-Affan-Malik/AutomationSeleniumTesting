using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationSeleniumTesting
{
    [TestClass]
    public class TestExecution
    {
        IWebDriver driver = new ChromeDriver();

        [TestMethod]
        public void LoginWithValidCredentials_TC001()
        {
            Login("https://adactinhotelapp.com/", "AmirTester", "AmirTester");


            string actualText = driver.FindElement(By.ClassName("welcome_menu")).Text;
            string expectedText = "Welcome to Adactin Group of Hotels";
            Assert.AreEqual(expectedText, actualText);
            driver.Close();
        }

        [TestMethod]
        public void LoginWithInvalidCredentials_TC002()
        {
            Login("https://adactinhotelapp.com/", "AmirTester", "AmirTester123");


            string actualText = driver.FindElement(By.ClassName("auth_error")).Text;
            string expectedText = "Invalid Login details or Your Password might have expired. Click here to reset your password";
            Assert.AreEqual(expectedText, actualText);
            driver.Close();
        }

        public void Login( string url, string username, string password)
        {
            

            driver.Url = url;
            driver.FindElement(By.Id("username")).SendKeys(username);
            driver.FindElement(By.Id("password")).SendKeys(password);
            driver.FindElement(By.Id("login")).Click();


        }
    }
}
