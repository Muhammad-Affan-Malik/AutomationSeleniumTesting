using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationSeleniumTesting
{
    [TestClass]
    public class TestExecution
    {
        //IWebDriver driver = new ChromeDriver();

        LoginPage loginPage = new LoginPage();

        [TestMethod]
        public void LoginWithValidCredentials_TC001()
        {
            CorePage.SeleniumInit();
            loginPage.Login("https://adactinhotelapp.com/", "AmirTester", "AmirTester");
            string actualText = CorePage.driver.FindElement(By.ClassName("welcome_menu")).Text;
            string expectedText = "Welcome to Adactin Group of Hotels";
            Assert.AreEqual(expectedText, actualText);
            CorePage.driver.Close();
        }

        [TestMethod]
        public void LoginWithInvalidCredentials_TC002()
        {
            CorePage.SeleniumInit(); 
            loginPage.Login("https://adactinhotelapp.com/", "AmirTester", "AmirTester123");
            string actualText = CorePage.driver.FindElement(By.ClassName("auth_error")).Text;
            string expectedText = "Invalid Login details or Your Password might have expired. Click here to reset your password";
            Assert.AreEqual(expectedText, actualText);
            CorePage.driver.Close();
        }


    }
}
