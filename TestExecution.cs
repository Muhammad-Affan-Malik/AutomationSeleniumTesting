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

        #region Setups and Cleanups

        public TestContext instance;

        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {

        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
           /* if (CorePage.driver != null)
            {
                CorePage.driver.Quit();
            }*/
        }

        [TestInitialize()]
        public void TestInit()
        {
            CorePage.SeleniumInit("Chrome");
        }


        [TestCleanup()]
        public void TestCleanup()
        {
            /*if (CorePage.driver != null)
            {
                CorePage.driver.Quit();
            }*/
            CorePage.driver.Close();
        }

        #endregion

        //IWebDriver driver = new ChromeDriver();

        LoginPage loginPage = new LoginPage();
        SearchPage searchPage = new SearchPage();
        SelectPage selectPage = new SelectPage();
        BookingPage bookingPage = new BookingPage();

        [TestMethod]
        public void LoginWithValidCredentials_TC001()
        {
            CorePage.SeleniumInit("MicrosoftEdge");
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

 
        public void BookHotel_TC005()
        {
            loginPage.Login("https://adactinhotelapp.com/", "AmirTester", "AmirTester");
            searchPage.SearchHotel();
            selectPage.SelectHotel();
            bookingPage.BookHotel();

        }
    }
}
