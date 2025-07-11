using System;
using System.Configuration;
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
            CorePage.SeleniumInit(ConfigurationManager.AppSettings["Browser"].ToString());
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
            loginPage.Login("https://adactinhotelapp.com/", "AmirTester", "AmirTester");
            string actualText = CorePage.driver.FindElement(By.ClassName("welcome_menu")).Text;
            string expectedText = "Welcome to Adactin Group of Hotels";
            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void LoginWithInvalidCredentials_TC002()
        { 
            loginPage.Login("https://adactinhotelapp.com/", "AmirTester", "AmirTester123");
            string actualText = CorePage.driver.FindElement(By.ClassName("auth_error")).Text;
            string expectedText = "Invalid Login details or Your Password might have expired. Click here to reset your password";
            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]

        public void SearchHotel_TC003()
        {
            loginPage.Login("https://adactinhotelapp.com/", "AmirTester", "AmirTester");
            searchPage.SearchHotel();
        }

        [TestMethod]
        public void SelectHotel_TC004()
        {

            loginPage.Login("https://adactinhotelapp.com/", "AmirTester", "AmirTester");
            searchPage.SearchHotel();
            selectPage.SelectHotel();

        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "BookHotel_TC005", DataAccessMethod.Sequential)]
        public void BookHotel_TC005()
        {
            string url = TestContext.DataRow["url"].ToString();
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();

            loginPage.Login(url, user, pass);
            searchPage.SearchHotel();
            selectPage.SelectHotel();
            bookingPage.BookHotel();

        }
    }
}
