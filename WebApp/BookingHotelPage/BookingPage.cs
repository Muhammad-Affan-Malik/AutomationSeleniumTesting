using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationSeleniumTesting.WebApp.BookingHotelPage
{
    internal class BookingPage : CorePage
    {
        #region Locators
        By fnameTxt = By.Id("first_name");
        By lnameTxt = By.Id("last_name");
        By addressTxt = By.Id("address");
        By cCNumTxt = By.Id("cc_num");
        By cCTypeDropDown = By.Id("cc_type");
        By expiryMonthDropDown = By.Id("cc_exp_month");
        By expiryYearDropDown = By.Id("cc_exp_year");
        By cCcvTxt = By.Id("cc_cvv");
        By bookNowBtn = By.Id("book_now");
        By cancelBtn = By.Id("cancel");
        By orderNoTxt = By.Id("order_no");
        #endregion


        public void BookHotel()
        {
            driver.FindElement(fnameTxt).SendKeys("Amir");
            driver.FindElement(lnameTxt).SendKeys("Tester");
            driver.FindElement(addressTxt).SendKeys("123 Test Street, Test City, NSW 2000, Australia");
            driver.FindElement(cCNumTxt).SendKeys("12345678901234567");
            driver.FindElement(cCTypeDropDown).SendKeys("VISA");
            driver.FindElement(expiryMonthDropDown).SendKeys("January");
            driver.FindElement(expiryYearDropDown).SendKeys("2025");
            driver.FindElement(cCcvTxt).SendKeys("123");
            driver.FindElement(bookNowBtn).Click();
        }
    }
}
