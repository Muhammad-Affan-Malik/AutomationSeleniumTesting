using System;
using AutomationSeleniumTesting.WebApp.BookingHotelPage;
using AutomationSeleniumTesting.WebApp.SelectHotelPage;
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
        SearchPage searchPage = new SearchPage();
        SelectPage selectPage = new SelectPage();
        BookingPage bookingPage = new BookingPage();

        [TestMethod]
        public void LoginWithValidCredentials_TC001()
        {
            CorePage.SeleniumInit("Chrome");
            loginPage.Login("https://adactinhotelapp.com/", "AmirTester", "AmirTester");
            string actualText = CorePage.driver.FindElement(By.ClassName("welcome_menu")).Text;
            string expectedText = "Welcome to Adactin Group of Hotels";
            Assert.AreEqual(expectedText, actualText);
            CorePage.driver.Close();
        }

        [TestMethod]
        public void LoginWithInvalidCredentials_TC002()
        {
            CorePage.SeleniumInit("Chrome"); 
            loginPage.Login("https://adactinhotelapp.com/", "AmirTester", "AmirTester123");
            string actualText = CorePage.driver.FindElement(By.ClassName("auth_error")).Text;
            string expectedText = "Invalid Login details or Your Password might have expired. Click here to reset your password";
            Assert.AreEqual(expectedText, actualText);
            CorePage.driver.Close();
        }

        [TestMethod]

        public void SearchHotel_TC003()
        {
            CorePage.SeleniumInit("Chrome");
            loginPage.Login("https://adactinhotelapp.com/", "AmirTester", "AmirTester");
            searchPage.SearchHotel();
            CorePage.driver.Close();
        }

        [TestMethod]
        public void SelectHotel_TC004()
        {
            CorePage.SeleniumInit("Chrome");
            loginPage.Login("https://adactinhotelapp.com/", "AmirTester", "AmirTester");
            searchPage.SearchHotel();
            selectPage.SelectHotel();
            CorePage.driver.Close();
        }

        [TestMethod]

        // FIXING ERROR : The method or operation is not implemented. its causing error 
        public void BookHotel_TC005()
        {
            CorePage.SeleniumInit("Chrome");
            loginPage.Login("https://adactinhotelapp.com/", "AmirTester", "AmirTester");
            searchPage.SearchHotel();
            selectPage.SelectHotel();
            bookingPage.BookHotel();
            CorePage.driver.Close();
        }
    }
}
